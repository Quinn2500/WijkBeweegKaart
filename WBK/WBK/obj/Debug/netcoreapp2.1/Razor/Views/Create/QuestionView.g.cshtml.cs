#pragma checksum "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27ca4b5e12de9fbd1703f9054889f3225cc19577"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Create_QuestionView), @"mvc.1.0.view", @"/Views/Create/QuestionView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Create/QuestionView.cshtml", typeof(AspNetCore.Views_Create_QuestionView))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27ca4b5e12de9fbd1703f9054889f3225cc19577", @"/Views/Create/QuestionView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d0bc4e9b17a8b143e226c8e7b1c445550acc752", @"/Views/_ViewImports.cshtml")]
    public class Views_Create_QuestionView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WBK.Models.Create.PageQuestionModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(73, 64, true);
            WriteLiteral("\r\n<div class=\"questionDiv\">\r\n    <h3 style=\"float: left;\">Vraag ");
            EndContext();
            BeginContext(139, 20, false);
#line 8 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
                               Write(Model.QuestionId + 1);

#line default
#line hidden
            EndContext();
            BeginContext(160, 139, true);
            WriteLiteral("</h3>\r\n\r\n    <div style=\"float: right;\" class=\"dropleft show\">\r\n        <a class=\"btn btn-secondary dropdown-toggle\" href=\"#\" role=\"button\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 299, "\"", 364, 4);
            WriteAttributeValue("", 304, "dropdownMenu_Page", 304, 17, true);
#line 11 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 321, Model.PageId, 321, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 336, "_Question", 336, 9, true);
#line 11 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 345, Model.QuestionId, 345, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(365, 332, true);
            WriteLiteral(@" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            =
        </a>
        <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuLink"">
            <a style=""color: red;"" href="""" class=""removeQuestionClass"">Vraag verwijderen</a>
        </div>
    </div>
    <input class=""form-control"" required");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 697, "\"", 765, 5);
            WriteAttributeValue("", 702, "PagesList_", 702, 10, true);
#line 18 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 712, Model.PageId, 712, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 727, "__Questions_", 727, 12, true);
#line 18 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 739, Model.QuestionId, 739, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 758, "__Title", 758, 7, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 766, "\"", 836, 5);
            WriteAttributeValue("", 773, "PagesList[", 773, 10, true);
#line 18 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 783, Model.PageId, 783, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 798, "].Questions[", 798, 12, true);
#line 18 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 810, Model.QuestionId, 810, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 829, "].Title", 829, 7, true);
            EndWriteAttribute();
            BeginContext(837, 77, true);
            WriteLiteral(" type=\"text\" value=\"\" placeholder=\"Vraag\" />\r\n    <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 914, "\"", 985, 5);
            WriteAttributeValue("", 919, "PagesList_", 919, 10, true);
#line 19 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 929, Model.PageId, 929, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 944, "__Questions_", 944, 12, true);
#line 19 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 956, Model.QuestionId, 956, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 975, "__ImageUrl", 975, 10, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 986, "\"", 1059, 5);
            WriteAttributeValue("", 993, "PagesList[", 993, 10, true);
#line 19 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 1003, Model.PageId, 1003, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1018, "].Questions[", 1018, 12, true);
#line 19 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 1030, Model.QuestionId, 1030, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 1049, "].ImageUrl", 1049, 10, true);
            EndWriteAttribute();
            BeginContext(1060, 86, true);
            WriteLiteral(" type=\"text\" value=\"\" placeholder=\"Vraag Foto URL\" />\r\n    <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1146, "\"", 1220, 5);
            WriteAttributeValue("", 1151, "PagesList_", 1151, 10, true);
#line 20 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 1161, Model.PageId, 1161, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1176, "__Questions_", 1176, 12, true);
#line 20 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 1188, Model.QuestionId, 1188, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 1207, "__Description", 1207, 13, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 1221, "\"", 1297, 5);
            WriteAttributeValue("", 1228, "PagesList[", 1228, 10, true);
#line 20 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 1238, Model.PageId, 1238, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1253, "].Questions[", 1253, 12, true);
#line 20 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 1265, Model.QuestionId, 1265, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 1284, "].Description", 1284, 13, true);
            EndWriteAttribute();
            BeginContext(1298, 155, true);
            WriteLiteral(" type=\"text\" value=\"\" placeholder=\"Vraag Beschrijving\" />\r\n    <select class=\"form-control\" data-val=\"true\" data-val-required=\"The Type field is required.\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1453, "\"", 1520, 5);
            WriteAttributeValue("", 1458, "PagesList_", 1458, 10, true);
#line 21 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 1468, Model.PageId, 1468, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1483, "__Questions_", 1483, 12, true);
#line 21 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 1495, Model.QuestionId, 1495, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 1514, "__Type", 1514, 6, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 1521, "\"", 1590, 5);
            WriteAttributeValue("", 1528, "PagesList[", 1528, 10, true);
#line 21 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 1538, Model.PageId, 1538, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1553, "].Questions[", 1553, 12, true);
#line 21 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 1565, Model.QuestionId, 1565, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 1584, "].Type", 1584, 6, true);
            EndWriteAttribute();
            BeginContext(1591, 11, true);
            WriteLiteral(">\r\n        ");
            EndContext();
            BeginContext(1602, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fed3c3c35e06441685bdca9f43cca5b3", async() => {
                BeginContext(1620, 8, true);
                WriteLiteral("GeoVraag");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1637, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1647, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4cd737ccdbc4b459462b3002d8c408b", async() => {
                BeginContext(1665, 14, true);
                WriteLiteral("MeerkeuzeVraag");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1688, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1698, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7090ca354be64ea482d321b3299f75e2", async() => {
                BeginContext(1716, 9, true);
                WriteLiteral("OpenVraag");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1734, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1744, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d71b0079d50b4bf1894d81f0737fc607", async() => {
                BeginContext(1762, 11, true);
                WriteLiteral("SliderVraag");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1782, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1792, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d822644c8e04c3cbcf4a3aa45a56d1c", async() => {
                BeginContext(1810, 11, true);
                WriteLiteral("NummerVraag");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1830, 73, true);
            WriteLiteral("\r\n    </select>\r\n    <label for=\"QuestionCounter\" style=\"display: none;\">");
            EndContext();
            BeginContext(1905, 16, false);
#line 28 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
                                                    Write(Model.QuestionId);

#line default
#line hidden
            EndContext();
            BeginContext(1922, 58, true);
            WriteLiteral("</label>\r\n    <div class=\"question\">\r\n\r\n    </div>\r\n</div>");
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
