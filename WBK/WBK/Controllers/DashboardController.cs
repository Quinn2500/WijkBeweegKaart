using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using DataModels;
using DataModels.Answers;
using Logic;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using MySqlX.XDevAPI.Relational;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using WBK.Models;
using WBK.Models.Dashboard;

namespace WBK.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly SurveyLogic _logic = new SurveyLogic();

        public DashboardController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            List<SurveyOverview> model = _logic.SurveyOverviewDataOfUser("test@test.nl");
            return View(model);
        }

        [HttpGet]
        public IActionResult AllAnswers(string surveyTitle)
        {
            Survey model = _logic.GetSurveyWithAllAnswers(surveyTitle);
            return View(model);
        }

        [HttpGet]
        public async Task<ActionResult> GetExcelOverview(string name)
        {
            Survey survey = _logic.GetSurveyWithAllAnswers(name);
            string sWebRootFolder = _hostingEnvironment.WebRootPath;
            string sFileName = @"Antwoorden "+ name +".xlsx";
            string URL = string.Format("{0}://{1}/{2}", Request.Scheme, Request.Host, sFileName);
            FileInfo file = new FileInfo(Path.Combine(sWebRootFolder, sFileName));
            var memory = new MemoryStream();
            using (var fs = new FileStream(Path.Combine(sWebRootFolder, sFileName), FileMode.Create, FileAccess.Write))
            {
                IWorkbook workbook;
                workbook = new XSSFWorkbook();
                ISheet excelSheet = workbook.CreateSheet(name);
                int rowCounter = 3;
                int cellCounter = 1;

                IRow row1 = excelSheet.CreateRow(1);
                IRow row2 = excelSheet.CreateRow(2);
                row2.CreateCell(0).SetCellValue("Respondent");

                foreach (Page page in survey.Pages)
                {
                    row1.CreateCell(cellCounter).SetCellValue(page.Title);
                    foreach (Question question in page.Questions)
                    {
                        row2.CreateCell(cellCounter).SetCellValue(question.Value);
                        cellCounter++;
                    }
                }

                IRow row = excelSheet.CreateRow(rowCounter);

                foreach (Answer answer1 in survey.Pages[0].Questions[0].Answers)
                {
                    row = excelSheet.CreateRow(rowCounter);
                    Respondant respondant = answer1.Respondant;
                    cellCounter = 0;
                    row.CreateCell(cellCounter).SetCellValue(respondant.SessionId);
                    cellCounter++;
                    foreach (Page page in survey.Pages)
                    {
                        foreach (Question question in page.Questions)
                        {
                            foreach (Answer answer in question.Answers)
                            {
                                if (answer.Respondant.SessionId == respondant.SessionId)
                                {
                                    switch (question.Type)
                                    {
                                        case TypeEnum.GeoVraag:
                                            var geo = answer as GeoAnswer;
                                            row.CreateCell(cellCounter).SetCellValue(geo.GeoData);
                                            break;

                                        case TypeEnum.NummerVraag:
                                            var number = answer as NumberAnswer;
                                            row.CreateCell(cellCounter).SetCellValue(number.NumberValue);
                                            break;

                                        case TypeEnum.SliderVraag:
                                            var slider = answer as NumberAnswer;
                                            row.CreateCell(cellCounter).SetCellValue(slider.NumberValue);
                                            break;

                                        case TypeEnum.OpenVraag:
                                            var open = answer as TextAnswer;
                                            row.CreateCell(cellCounter).SetCellValue(open.TextValue);
                                            break;

                                        case TypeEnum.MeerkeuzeVraag:
                                            var multipleChoiceAnswer = answer as MultipleChoiceAnswer;
                                            row.CreateCell(cellCounter).SetCellValue(multipleChoiceAnswer.ToString());
                                            break;
                                    }
                                    cellCounter++;
                                }

                            }
                        }

                    }

                    rowCounter++;
                }

                workbook.Write(fs);
            }

            using (var stream = new FileStream(Path.Combine(sWebRootFolder, sFileName), FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", sFileName);
        }

        [HttpGet]
        public IActionResult AnalyseGeoAnswers(string surveyTitle)
        {
            Survey model = _logic.GetSurveyWithAllAnswers(surveyTitle);
            return View(model);
        }

        [HttpGet]
        public IActionResult ProfileAverage(string surveyTitle, string profileString)
        {
            Survey surey = _logic.GetSurveyWithAllAnswers(surveyTitle);
            ProfileAverageViewModel model = new ProfileAverageViewModel();
            Enum.TryParse(profileString, out ProfileEnum profile);

            List<int> allAges = new List<int>();
            List<int> satifiesNNGB = new List<int>();
            List<int> doesSport = new List<int>();
            List<string> motivators = new List<string>();
            List<string> restains = new List<string>();
            foreach (Answer answer in surey.Pages[0].Questions[0].Answers)
            {
                Respondant respondant = answer.Respondant;
                if (answer.Respondant.Profile == profile)
                {
                    allAges.Add(respondant.Age);
                    model.RespondantsWithProfile.Add(respondant);
                    doesSport.Add(respondant.DoesSport ? 1 : 0);
                    satifiesNNGB.Add(respondant.SatifiesNngb ? 1 : 0);
                    motivators.Add(respondant.Motivator);
                    restains.Add(respondant.Restrain);
                }
            }

            model.AverageAge = Convert.ToInt32(Math.Round(allAges.Average()));
            model.BiggestMotivator = motivators.GroupBy(v => v)
                .OrderByDescending(g => g.Count())
                .First()
                .Key;
            model.BiggestRestrain = restains.GroupBy(v => v)
                .OrderByDescending(g => g.Count())
                .First()
                .Key;
            model.PercentageThatDoesSport = Convert.ToInt32(Math.Round(doesSport.Average() * 100));
            model.PercentageThatSatifiesNNGB = Convert.ToInt32(Math.Round(satifiesNNGB.Average() * 100));

            return View(model);
        }
    }
}
