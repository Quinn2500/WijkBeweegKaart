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
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using WBK.Models;

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
            string sFileName = @"Overzicht Certificaat " + ".xlsx";
            string URL = string.Format("{0}://{1}/{2}", Request.Scheme, Request.Host, sFileName);
            FileInfo file = new FileInfo(Path.Combine(sWebRootFolder, sFileName));
            var memory = new MemoryStream();
            using (var fs = new FileStream(Path.Combine(sWebRootFolder, sFileName), FileMode.Create, FileAccess.Write))
            {
                IWorkbook workbook;
                workbook = new XSSFWorkbook();
                ISheet excelSheet = workbook.CreateSheet(name);
                int i = 2;
                int j = 1;

                IRow row1 = excelSheet.CreateRow(0);
                IRow row2 = excelSheet.CreateRow(1);
                row2.CreateCell(0).SetCellValue("Gebruiker");
                IRow row = excelSheet.CreateRow(2);              
                foreach (Page page in survey.Pages)
                {
                    row1.CreateCell(j).SetCellValue(page.Title);
                    foreach (Question question in page.Questions)
                    {
                        row2.CreateCell(j).SetCellValue(question.Value);
                        j++;
                    }

                    foreach (Answer answer1 in page.Questions[0].Answers)
                    {
                        row = excelSheet.CreateRow(2);
                        Respondant respondant = answer1.Respondant;
                        row.CreateCell(0).SetCellValue(respondant.SessionId);
                        j = 1;
                        foreach(Question question in page.Questions)
                        {
                            foreach (Answer answer in question.Answers)
                            {
                                if (answer.Respondant.SessionId == respondant.SessionId)
                                {
                                    switch (question.Type)
                                    {
                                        case TypeEnum.GeoVraag:
                                            var geo = answer as GeoAnswer;
                                                    row.CreateCell(j).SetCellValue(geo.GeoData);
                                                break;

                                        case TypeEnum.NummerVraag:
                                            var number = answer as NumberAnswer;
                                                row.CreateCell(j).SetCellValue(number.NumberValue);
                                            break;

                                        case TypeEnum.SliderVraag:
                                            var slider = answer as NumberAnswer;
                                                row.CreateCell(j).SetCellValue(slider.NumberValue);
                                            break;

                                        case TypeEnum.OpenVraag:
                                            var open = answer as TextAnswer;
                                                row.CreateCell(j).SetCellValue(open.TextValue);
                                            break;

                                        case TypeEnum.MeerkeuzeVraag:
                                            var multipleChoiceAnswer = answer as MultipleChoiceAnswer;
                                                row.CreateCell(j).SetCellValue(string.Join(" ", multipleChoiceAnswer.AnsweredOptions.Select(t => t.Value)));
                                            break;
                                    }
                                }

                                j++;
                            }
                        }

                        i++;
                    }
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
    }
}
