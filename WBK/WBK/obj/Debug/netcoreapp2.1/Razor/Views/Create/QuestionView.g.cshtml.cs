#pragma checksum "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e94809f6a2fcd73f2772a2b93d555981339baae1"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e94809f6a2fcd73f2772a2b93d555981339baae1", @"/Views/Create/QuestionView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d0bc4e9b17a8b143e226c8e7b1c445550acc752", @"/Views/_ViewImports.cshtml")]
    public class Views_Create_QuestionView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WBK.Models.Create.PageQuestionModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(73, 44, true);
            WriteLiteral("\r\n<div class=\"questionDiv\">\r\n    <h3>Vraag  ");
            EndContext();
            BeginContext(119, 16, false);
#line 8 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
           Write(Model.QuestionId);

#line default
#line hidden
            EndContext();
            BeginContext(136, 47, true);
            WriteLiteral("</h3>\r\n    <input class=\"form-control\" required");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 183, "\"", 251, 5);
            WriteAttributeValue("", 188, "PagesList_", 188, 10, true);
#line 9 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 198, Model.PageId, 198, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 213, "__Questions_", 213, 12, true);
#line 9 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 225, Model.QuestionId, 225, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 244, "__Title", 244, 7, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 252, "\"", 322, 5);
            WriteAttributeValue("", 259, "PagesList[", 259, 10, true);
#line 9 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 269, Model.PageId, 269, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 284, "].Questions[", 284, 12, true);
#line 9 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 296, Model.QuestionId, 296, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 315, "].Title", 315, 7, true);
            EndWriteAttribute();
            BeginContext(323, 77, true);
            WriteLiteral(" type=\"text\" value=\"\" placeholder=\"Vraag\" />\r\n    <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 400, "\"", 474, 5);
            WriteAttributeValue("", 405, "PagesList_", 405, 10, true);
#line 10 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 415, Model.PageId, 415, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 430, "__Questions_", 430, 12, true);
#line 10 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 442, Model.QuestionId, 442, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 461, "__Description", 461, 13, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 475, "\"", 551, 5);
            WriteAttributeValue("", 482, "PagesList[", 482, 10, true);
#line 10 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 492, Model.PageId, 492, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 507, "].Questions[", 507, 12, true);
#line 10 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 519, Model.QuestionId, 519, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 538, "].Description", 538, 13, true);
            EndWriteAttribute();
            BeginContext(552, 155, true);
            WriteLiteral(" type=\"text\" value=\"\" placeholder=\"Vraag Beschrijving\" />\r\n    <select class=\"form-control\" data-val=\"true\" data-val-required=\"The Type field is required.\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 707, "\"", 774, 5);
            WriteAttributeValue("", 712, "PagesList_", 712, 10, true);
#line 11 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 722, Model.PageId, 722, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 737, "__Questions_", 737, 12, true);
#line 11 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 749, Model.QuestionId, 749, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 768, "__Type", 768, 6, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 775, "\"", 844, 5);
            WriteAttributeValue("", 782, "PagesList[", 782, 10, true);
#line 11 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 792, Model.PageId, 792, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 807, "].Questions[", 807, 12, true);
#line 11 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 819, Model.QuestionId, 819, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 838, "].Type", 838, 6, true);
            EndWriteAttribute();
            BeginContext(845, 11, true);
            WriteLiteral(">\r\n        ");
            EndContext();
            BeginContext(856, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1e95b35b2d04f9d8b02c5667645efe0", async() => {
                BeginContext(874, 8, true);
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
            BeginContext(891, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(901, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0f732d6e7be48d59dc894481ac24d43", async() => {
                BeginContext(919, 14, true);
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
            BeginContext(942, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(952, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22822ab302ec465b95fa8466c9ee5a97", async() => {
                BeginContext(970, 9, true);
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
            BeginContext(988, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(998, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66cee672426a4e8f8deb970627ddd944", async() => {
                BeginContext(1016, 11, true);
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
            BeginContext(1036, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1046, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b83b6fb9a604837b4d7213601a9367e", async() => {
                BeginContext(1064, 11, true);
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
            BeginContext(1084, 117, true);
            WriteLiteral("\r\n    </select>\r\n    <select class=\"form-control\" data-val=\"true\" data-val-required=\"The Category field is required.\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1201, "\"", 1272, 5);
            WriteAttributeValue("", 1206, "PagesList_", 1206, 10, true);
#line 18 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 1216, Model.PageId, 1216, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1231, "__Questions_", 1231, 12, true);
#line 18 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 1243, Model.QuestionId, 1243, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 1262, "__Category", 1262, 10, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 1273, "\"", 1346, 5);
            WriteAttributeValue("", 1280, "PagesList[", 1280, 10, true);
#line 18 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 1290, Model.PageId, 1290, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1305, "].Questions[", 1305, 12, true);
#line 18 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 1317, Model.QuestionId, 1317, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 1336, "].Category", 1336, 10, true);
            EndWriteAttribute();
            BeginContext(1347, 11, true);
            WriteLiteral(">\r\n        ");
            EndContext();
            BeginContext(1358, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25e57c0c2e1046959c93db5c443ba913", async() => {
                BeginContext(1396, 7, true);
                WriteLiteral("Profiel");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
            BeginContext(1412, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1422, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "747193eefe2c4c1a84cae1ef83e94855", async() => {
                BeginContext(1440, 7, true);
                WriteLiteral("Locatie");
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
            BeginContext(1456, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1466, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c4019f9533340639d206e8fe79b6705", async() => {
                BeginContext(1484, 10, true);
                WriteLiteral("Gezondheid");
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
            BeginContext(1503, 73, true);
            WriteLiteral("\r\n    </select>\r\n    <label for=\"QuestionCounter\" style=\"display: none;\">");
            EndContext();
            BeginContext(1578, 16, false);
#line 23 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
                                                    Write(Model.QuestionId);

#line default
#line hidden
            EndContext();
            BeginContext(1595, 139, true);
            WriteLiteral("</label>\r\n    <div class=\"question\">\r\n\r\n    </div>\r\n    <a href=\"\" class=\"removeQuestionClass btn btn-danger\">Vraag verwijderen</a>\r\n</div>");
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