#pragma checksum "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\MultipleChoiceQuestion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad34b048abc353db802045f7ff5b3d81645f3da0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Create_MultipleChoiceQuestion), @"mvc.1.0.view", @"/Views/Create/MultipleChoiceQuestion.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Create/MultipleChoiceQuestion.cshtml", typeof(AspNetCore.Views_Create_MultipleChoiceQuestion))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\_ViewImports.cshtml"
using WBK;

#line default
#line hidden
#line 2 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\_ViewImports.cshtml"
using WBK.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad34b048abc353db802045f7ff5b3d81645f3da0", @"/Views/Create/MultipleChoiceQuestion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d0bc4e9b17a8b143e226c8e7b1c445550acc752", @"/Views/_ViewImports.cshtml")]
    public class Views_Create_MultipleChoiceQuestion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WBK.Models.Create.PageQuestionModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\MultipleChoiceQuestion.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(73, 284, true);
            WriteLiteral(@"
<div class=""question"">  
    <div class=mcWrapper>
        <label style=""display: inline-block;"">Maximaal aantal antwoorden:</label>
        <input style=""display: inline-block;"" class=""form-control"" data-val=""true"" data-val-required=""The AllowMultipleAnswers field is required.""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 357, "\"", 442, 5);
            WriteAttributeValue("", 362, "PagesList_", 362, 10, true);
#line 10 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\MultipleChoiceQuestion.cshtml"
WriteAttributeValue("", 372, Model.PageId, 372, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 387, "__Questions_", 387, 12, true);
#line 10 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\MultipleChoiceQuestion.cshtml"
WriteAttributeValue("", 399, Model.QuestionId, 399, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 418, "__MaximumNumberOfAnswers", 418, 24, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 443, "\"", 530, 5);
            WriteAttributeValue("", 450, "PagesList[", 450, 10, true);
#line 10 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\MultipleChoiceQuestion.cshtml"
WriteAttributeValue("", 460, Model.PageId, 460, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 475, "].Questions[", 475, 12, true);
#line 10 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\MultipleChoiceQuestion.cshtml"
WriteAttributeValue("", 487, Model.QuestionId, 487, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 506, "].MaximumNumberOfAnswers", 506, 24, true);
            EndWriteAttribute();
            BeginContext(531, 159, true);
            WriteLiteral(" type=\"number\" min=\"1\" max=\"10\" value=\"true\"/>\r\n        \r\n        <div class=\"MCOption\" style=\"margin-top: 10px;\">\r\n            <h4 style=\"float: left;\">Optie ");
            EndContext();
            BeginContext(692, 18, false);
#line 13 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\MultipleChoiceQuestion.cshtml"
                                       Write(Model.OptionId + 1);

#line default
#line hidden
            EndContext();
            BeginContext(711, 156, true);
            WriteLiteral(":</h4>\r\n\r\n            <div style=\"float: right;\" class=\"dropleft show\">\r\n                <a class=\"btn btn-secondary dropdown-toggle\" href=\"#\" role=\"button\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 867, "\"", 911, 2);
            WriteAttributeValue("", 872, "dropdownMenuQuestion", 872, 20, true);
#line 16 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\MultipleChoiceQuestion.cshtml"
WriteAttributeValue("", 892, Model.QuestionId, 892, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(912, 368, true);
            WriteLiteral(@" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                    =
                </a>
                <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuLink"">
                    <a style=""color: red;"" href="""" class=""removeMCOption"">Verwijderen</a>
                </div>
            </div>
            <input class=""form-control""");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1280, "\"", 1376, 7);
            WriteAttributeValue("", 1285, "PagesList_", 1285, 10, true);
#line 23 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\MultipleChoiceQuestion.cshtml"
WriteAttributeValue("", 1295, Model.PageId, 1295, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1310, "__Questions_", 1310, 12, true);
#line 23 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\MultipleChoiceQuestion.cshtml"
WriteAttributeValue("", 1322, Model.QuestionId, 1322, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 1341, "__Options_", 1341, 10, true);
#line 23 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\MultipleChoiceQuestion.cshtml"
WriteAttributeValue("", 1351, Model.OptionId, 1351, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 1368, "__Answer", 1368, 8, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 1377, "\"", 1475, 7);
            WriteAttributeValue("", 1384, "PagesList[", 1384, 10, true);
#line 23 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\MultipleChoiceQuestion.cshtml"
WriteAttributeValue("", 1394, Model.PageId, 1394, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1409, "].Questions[", 1409, 12, true);
#line 23 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\MultipleChoiceQuestion.cshtml"
WriteAttributeValue("", 1421, Model.QuestionId, 1421, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 1440, "].Options[", 1440, 10, true);
#line 23 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\MultipleChoiceQuestion.cshtml"
WriteAttributeValue("", 1450, Model.OptionId, 1450, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 1467, "].Answer", 1467, 8, true);
            EndWriteAttribute();
            BeginContext(1476, 88, true);
            WriteLiteral(" type=\"text\" value=\"\" placeholder=\"Antwoord\" />\r\n            <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1564, "\"", 1662, 7);
            WriteAttributeValue("", 1569, "PagesList_", 1569, 10, true);
#line 24 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\MultipleChoiceQuestion.cshtml"
WriteAttributeValue("", 1579, Model.PageId, 1579, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1594, "__Questions_", 1594, 12, true);
#line 24 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\MultipleChoiceQuestion.cshtml"
WriteAttributeValue("", 1606, Model.QuestionId, 1606, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 1625, "__Options_", 1625, 10, true);
#line 24 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\MultipleChoiceQuestion.cshtml"
WriteAttributeValue("", 1635, Model.OptionId, 1635, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 1652, "__ImageUrl", 1652, 10, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 1663, "\"", 1763, 7);
            WriteAttributeValue("", 1670, "PagesList[", 1670, 10, true);
#line 24 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\MultipleChoiceQuestion.cshtml"
WriteAttributeValue("", 1680, Model.PageId, 1680, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1695, "].Questions[", 1695, 12, true);
#line 24 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\MultipleChoiceQuestion.cshtml"
WriteAttributeValue("", 1707, Model.QuestionId, 1707, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 1726, "].Options[", 1726, 10, true);
#line 24 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\MultipleChoiceQuestion.cshtml"
WriteAttributeValue("", 1736, Model.OptionId, 1736, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 1753, "].ImageUrl", 1753, 10, true);
            EndWriteAttribute();
            BeginContext(1764, 88, true);
            WriteLiteral(" type=\"text\" value=\"\" placeholder=\"Foto URL\" />\r\n            <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1852, "\"", 1953, 7);
            WriteAttributeValue("", 1857, "PagesList_", 1857, 10, true);
#line 25 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\MultipleChoiceQuestion.cshtml"
WriteAttributeValue("", 1867, Model.PageId, 1867, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1882, "__Questions_", 1882, 12, true);
#line 25 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\MultipleChoiceQuestion.cshtml"
WriteAttributeValue("", 1894, Model.QuestionId, 1894, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 1913, "__Options_", 1913, 10, true);
#line 25 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\MultipleChoiceQuestion.cshtml"
WriteAttributeValue("", 1923, Model.OptionId, 1923, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 1940, "__Description", 1940, 13, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 1954, "\"", 2057, 7);
            WriteAttributeValue("", 1961, "PagesList[", 1961, 10, true);
#line 25 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\MultipleChoiceQuestion.cshtml"
WriteAttributeValue("", 1971, Model.PageId, 1971, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1986, "].Questions[", 1986, 12, true);
#line 25 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\MultipleChoiceQuestion.cshtml"
WriteAttributeValue("", 1998, Model.QuestionId, 1998, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 2017, "].Options[", 2017, 10, true);
#line 25 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\MultipleChoiceQuestion.cshtml"
WriteAttributeValue("", 2027, Model.OptionId, 2027, 17, false);

#line default
#line hidden
            WriteAttributeValue("", 2044, "].Description", 2044, 13, true);
            EndWriteAttribute();
            BeginContext(2058, 115, true);
            WriteLiteral(" type=\"text\" value=\"\" placeholder=\"Beschrijving\" />\r\n            <label for=\"OptionCounter\" style=\"display: none;\">");
            EndContext();
            BeginContext(2175, 14, false);
#line 26 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\MultipleChoiceQuestion.cshtml"
                                                          Write(Model.OptionId);

#line default
#line hidden
            EndContext();
            BeginContext(2190, 181, true);
            WriteLiteral("</label>\r\n            </div>\r\n\r\n    </div>   \r\n\r\n    <div class=\"addMCOptions\">\r\n        <a href=\"\" class=\"addMCOption btn btn-info\">Voeg optie toe! </a>\r\n    </div>        \r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WBK.Models.Create.PageQuestionModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
