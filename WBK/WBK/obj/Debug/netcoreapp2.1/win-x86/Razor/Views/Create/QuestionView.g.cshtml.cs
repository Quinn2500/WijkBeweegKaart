#pragma checksum "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0b53de3a7ee6f3441a70d4b0b1e8fa005c63ff5"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0b53de3a7ee6f3441a70d4b0b1e8fa005c63ff5", @"/Views/Create/QuestionView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d0bc4e9b17a8b143e226c8e7b1c445550acc752", @"/Views/_ViewImports.cshtml")]
    public class Views_Create_QuestionView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WBK.Models.Create.PageQuestionModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "4", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "5", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginWriteAttribute("id", " id=\"", 299, "\"", 343, 2);
            WriteAttributeValue("", 304, "dropdownMenuQuestion", 304, 20, true);
#line 11 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 324, Model.QuestionId, 324, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(344, 332, true);
            WriteLiteral(@" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
            =
        </a>
        <div class=""dropdown-menu"" aria-labelledby=""dropdownMenuLink"">
            <a style=""color: red;"" href="""" class=""removeQuestionClass"">Vraag verwijderen</a>
        </div>
    </div>
    <input class=""form-control"" required");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 676, "\"", 744, 5);
            WriteAttributeValue("", 681, "PagesList_", 681, 10, true);
#line 18 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 691, Model.PageId, 691, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 706, "__Questions_", 706, 12, true);
#line 18 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 718, Model.QuestionId, 718, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 737, "__Title", 737, 7, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 745, "\"", 815, 5);
            WriteAttributeValue("", 752, "PagesList[", 752, 10, true);
#line 18 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 762, Model.PageId, 762, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 777, "].Questions[", 777, 12, true);
#line 18 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 789, Model.QuestionId, 789, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 808, "].Title", 808, 7, true);
            EndWriteAttribute();
            BeginContext(816, 77, true);
            WriteLiteral(" type=\"text\" value=\"\" placeholder=\"Vraag\" />\r\n    <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 893, "\"", 964, 5);
            WriteAttributeValue("", 898, "PagesList_", 898, 10, true);
#line 19 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 908, Model.PageId, 908, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 923, "__Questions_", 923, 12, true);
#line 19 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 935, Model.QuestionId, 935, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 954, "__ImageUrl", 954, 10, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 965, "\"", 1038, 5);
            WriteAttributeValue("", 972, "PagesList[", 972, 10, true);
#line 19 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 982, Model.PageId, 982, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 997, "].Questions[", 997, 12, true);
#line 19 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 1009, Model.QuestionId, 1009, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 1028, "].ImageUrl", 1028, 10, true);
            EndWriteAttribute();
            BeginContext(1039, 86, true);
            WriteLiteral(" type=\"text\" value=\"\" placeholder=\"Vraag Foto URL\" />\r\n    <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1125, "\"", 1199, 5);
            WriteAttributeValue("", 1130, "PagesList_", 1130, 10, true);
#line 20 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 1140, Model.PageId, 1140, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1155, "__Questions_", 1155, 12, true);
#line 20 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 1167, Model.QuestionId, 1167, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 1186, "__Description", 1186, 13, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 1200, "\"", 1276, 5);
            WriteAttributeValue("", 1207, "PagesList[", 1207, 10, true);
#line 20 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 1217, Model.PageId, 1217, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1232, "].Questions[", 1232, 12, true);
#line 20 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 1244, Model.QuestionId, 1244, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 1263, "].Description", 1263, 13, true);
            EndWriteAttribute();
            BeginContext(1277, 155, true);
            WriteLiteral(" type=\"text\" value=\"\" placeholder=\"Vraag Beschrijving\" />\r\n    <select class=\"form-control\" data-val=\"true\" data-val-required=\"The Type field is required.\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1432, "\"", 1499, 5);
            WriteAttributeValue("", 1437, "PagesList_", 1437, 10, true);
#line 21 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 1447, Model.PageId, 1447, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1462, "__Questions_", 1462, 12, true);
#line 21 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 1474, Model.QuestionId, 1474, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 1493, "__Type", 1493, 6, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 1500, "\"", 1569, 5);
            WriteAttributeValue("", 1507, "PagesList[", 1507, 10, true);
#line 21 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 1517, Model.PageId, 1517, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1532, "].Questions[", 1532, 12, true);
#line 21 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 1544, Model.QuestionId, 1544, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 1563, "].Type", 1563, 6, true);
            EndWriteAttribute();
            BeginContext(1570, 11, true);
            WriteLiteral(">\r\n        ");
            EndContext();
            BeginContext(1581, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b23e10239fb84a97ba2e7a4d4f604858", async() => {
                BeginContext(1599, 8, true);
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
            BeginContext(1616, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1626, 41, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d18c16b63f1f456ca3875f050067afb9", async() => {
                BeginContext(1644, 14, true);
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
            BeginContext(1667, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1677, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6665fb5ce1b94201b146d25923a4635a", async() => {
                BeginContext(1695, 9, true);
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
            BeginContext(1713, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1723, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5702e094c1e4378a2bdade6a5f7d257", async() => {
                BeginContext(1741, 11, true);
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
            BeginContext(1761, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1771, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "668cc90d81944ab1b319f0479fdf6433", async() => {
                BeginContext(1789, 11, true);
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
            BeginContext(1809, 117, true);
            WriteLiteral("\r\n    </select>\r\n    <select class=\"form-control\" data-val=\"true\" data-val-required=\"The Category field is required.\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1926, "\"", 1997, 5);
            WriteAttributeValue("", 1931, "PagesList_", 1931, 10, true);
#line 28 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 1941, Model.PageId, 1941, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1956, "__Questions_", 1956, 12, true);
#line 28 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 1968, Model.QuestionId, 1968, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 1987, "__Category", 1987, 10, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 1998, "\"", 2071, 5);
            WriteAttributeValue("", 2005, "PagesList[", 2005, 10, true);
#line 28 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 2015, Model.PageId, 2015, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2030, "].Questions[", 2030, 12, true);
#line 28 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
WriteAttributeValue("", 2042, Model.QuestionId, 2042, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 2061, "].Category", 2061, 10, true);
            EndWriteAttribute();
            BeginContext(2072, 11, true);
            WriteLiteral(">\r\n        ");
            EndContext();
            BeginContext(2083, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44e51de1d08648cf9d223d5f0bed5ff1", async() => {
                BeginContext(2121, 7, true);
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
            BeginContext(2137, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(2147, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8456c81ac27a45c19c5be27cd779d26d", async() => {
                BeginContext(2165, 7, true);
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
            BeginContext(2181, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(2191, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4dbe3c8bb87a4b27bf8e1c3964a181bd", async() => {
                BeginContext(2209, 10, true);
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
            BeginContext(2228, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(2238, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64512d8b9808482480c0d4730dc45887", async() => {
                BeginContext(2256, 9, true);
                WriteLiteral("Motivatie");
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
            BeginContext(2274, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(2284, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c20e3bedc544ee796e01ab3294ffeb4", async() => {
                BeginContext(2302, 8, true);
                WriteLiteral("Algemeen");
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
            BeginContext(2319, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(2329, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10b028f876a24ffd8af6900679cc580b", async() => {
                BeginContext(2347, 7, true);
                WriteLiteral("Product");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2363, 73, true);
            WriteLiteral("\r\n    </select>\r\n    <label for=\"QuestionCounter\" style=\"display: none;\">");
            EndContext();
            BeginContext(2438, 16, false);
#line 36 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\QuestionView.cshtml"
                                                    Write(Model.QuestionId);

#line default
#line hidden
            EndContext();
            BeginContext(2455, 58, true);
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
