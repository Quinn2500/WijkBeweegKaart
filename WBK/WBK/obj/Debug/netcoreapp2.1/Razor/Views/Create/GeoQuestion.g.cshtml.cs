#pragma checksum "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04dbd8c28f4d222647d57016bd87cae508d4fae0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Create_GeoQuestion), @"mvc.1.0.view", @"/Views/Create/GeoQuestion.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Create/GeoQuestion.cshtml", typeof(AspNetCore.Views_Create_GeoQuestion))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04dbd8c28f4d222647d57016bd87cae508d4fae0", @"/Views/Create/GeoQuestion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d0bc4e9b17a8b143e226c8e7b1c445550acc752", @"/Views/_ViewImports.cshtml")]
    public class Views_Create_GeoQuestion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WBK.Models.Create.PageQuestionModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString("selected"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
 if (Model.FirstGeoQuestionInPage)
{

#line default
#line hidden
            BeginContext(114, 36, true);
            WriteLiteral("<div class=\"geo question\">\r\n    <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 150, "\"", 175, 2);
            WriteAttributeValue("", 155, "mapid", 155, 5, true);
#line 10 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 160, Model.PageId, 160, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(176, 148, true);
            WriteLiteral(" class=\"map\" style=\"height: 400px; width: 400px;\"></div>\r\n    <p>Klik op de kaart om de waardes in te voeren!</p>\r\n    <input class = \"form-control\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 324, "\"", 403, 5);
            WriteAttributeValue("", 329, "PagesList_", 329, 10, true);
#line 12 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 339, Model.PageId, 339, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 354, "__Questions_", 354, 12, true);
#line 12 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 366, Model.QuestionId, 366, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 385, "__StartLocationLat", 385, 18, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 404, "\"", 485, 5);
            WriteAttributeValue("", 411, "PagesList[", 411, 10, true);
#line 12 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 421, Model.PageId, 421, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 436, "].Questions[", 436, 12, true);
#line 12 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 448, Model.QuestionId, 448, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 467, "].StartLocationLat", 467, 18, true);
            EndWriteAttribute();
            BeginContext(486, 67, true);
            WriteLiteral(" type=\"text\" value=\"Latitude\" />\r\n    <input class = \"form-control\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 553, "\"", 633, 5);
            WriteAttributeValue("", 558, "PagesList_", 558, 10, true);
#line 13 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 568, Model.PageId, 568, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 583, "__Questions_", 583, 12, true);
#line 13 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 595, Model.QuestionId, 595, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 614, "__StartLocationLong", 614, 19, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 634, "\"", 716, 5);
            WriteAttributeValue("", 641, "PagesList[", 641, 10, true);
#line 13 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 651, Model.PageId, 651, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 666, "].Questions[", 666, 12, true);
#line 13 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 678, Model.QuestionId, 678, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 697, "].StartLocationLong", 697, 19, true);
            EndWriteAttribute();
            BeginContext(717, 167, true);
            WriteLiteral(" type=\"text\" value=\"Longitude\" />\r\n    <label>Marker Type:</label>\r\n    <select class=\"form-control\" data-val=\"true\" data-val-required=\"The GeoType field is required.\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 884, "\"", 954, 5);
            WriteAttributeValue("", 889, "PagesList_", 889, 10, true);
#line 15 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 899, Model.PageId, 899, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 914, "__Questions_", 914, 12, true);
#line 15 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 926, Model.QuestionId, 926, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 945, "__GeoType", 945, 9, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 955, "\"", 1027, 5);
            WriteAttributeValue("", 962, "PagesList[", 962, 10, true);
#line 15 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 972, Model.PageId, 972, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 987, "].Questions[", 987, 12, true);
#line 15 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 999, Model.QuestionId, 999, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 1018, "].GeoType", 1018, 9, true);
            EndWriteAttribute();
            BeginContext(1028, 11, true);
            WriteLiteral(">\r\n        ");
            EndContext();
            BeginContext(1039, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0f7165e76d5481ca2bbded5e26c3445", async() => {
                BeginContext(1077, 6, true);
                WriteLiteral("Marker");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            BeginContext(1092, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1102, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3301c367d63e407d8872e61b4328c732", async() => {
                BeginContext(1120, 4, true);
                WriteLiteral("Lijn");
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
            BeginContext(1133, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1143, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eff6d9366d93438ea6484a5352f6fc86", async() => {
                BeginContext(1161, 4, true);
                WriteLiteral("Vlak");
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
            BeginContext(1174, 25, true);
            WriteLiteral("\r\n    </select>\r\n</div>\r\n");
            EndContext();
            BeginContext(1201, 29, true);
            WriteLiteral("    <script>\r\n        var map");
            EndContext();
            BeginContext(1232, 12, false);
#line 23 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
           Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(1245, 15, true);
            WriteLiteral(" = L.map(\'mapid");
            EndContext();
            BeginContext(1262, 12, false);
#line 23 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                                         Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(1275, 330, true);
            WriteLiteral(@"').setView([51.47358, 5.453167], 13);
        var OpenStreetMap_Mapnik = L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png',
            {
                maxZoom: 19,
                attribution: '&copy; <a href=""https://www.openstreetmap.org/copyright"">OpenStreetMap</a> contributors'
            }).addTo(map");
            EndContext();
            BeginContext(1607, 12, false);
#line 28 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                    Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(1620, 24, true);
            WriteLiteral(");\r\n\r\n        var marker");
            EndContext();
            BeginContext(1646, 12, false);
#line 30 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
              Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(1659, 45, true);
            WriteLiteral(" = L.marker();\r\n\r\n        function onMapClick");
            EndContext();
            BeginContext(1706, 12, false);
#line 32 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                       Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(1719, 25, true);
            WriteLiteral("(e) {\r\n            marker");
            EndContext();
            BeginContext(1746, 12, false);
#line 33 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
              Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(1759, 143, true);
            WriteLiteral("\r\n                .setLatLng(e.latlng)\r\n                .bindPopup(\"You clicked the map at \" + e.latlng.toString())\r\n                .addTo(map");
            EndContext();
            BeginContext(1904, 12, false);
#line 36 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                      Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(1917, 52, true);
            WriteLiteral(" );\r\n            document.getElementById(\"PagesList_");
            EndContext();
            BeginContext(1971, 12, false);
#line 37 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                                           Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(1984, 12, true);
            WriteLiteral("__Questions_");
            EndContext();
            BeginContext(1998, 16, false);
#line 37 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                                                                      Write(Model.QuestionId);

#line default
#line hidden
            EndContext();
            BeginContext(2015, 91, true);
            WriteLiteral("__StartLocationLat\").value = e.latlng.lat;\r\n            document.getElementById(\"PagesList_");
            EndContext();
            BeginContext(2108, 12, false);
#line 38 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                                           Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(2121, 12, true);
            WriteLiteral("__Questions_");
            EndContext();
            BeginContext(2135, 16, false);
#line 38 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                                                                      Write(Model.QuestionId);

#line default
#line hidden
            EndContext();
            BeginContext(2152, 67, true);
            WriteLiteral("__StartLocationLong\").value = e.latlng.lng;\r\n        }\r\n        map");
            EndContext();
            BeginContext(2221, 12, false);
#line 40 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
       Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(2234, 23, true);
            WriteLiteral(".on(\'click\', onMapClick");
            EndContext();
            BeginContext(2259, 12, false);
#line 40 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                                             Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(2272, 19, true);
            WriteLiteral(");\r\n    </script>\r\n");
            EndContext();
#line 42 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(2303, 172, true);
            WriteLiteral("    <div class=\"geo question\">\r\n        <label>Marker Type:</label>\r\n        <select class=\"form-control\" data-val=\"true\" data-val-required=\"The GeoType field is required.\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2475, "\"", 2545, 5);
            WriteAttributeValue("", 2480, "PagesList_", 2480, 10, true);
#line 47 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 2490, Model.PageId, 2490, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2505, "__Questions_", 2505, 12, true);
#line 47 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 2517, Model.QuestionId, 2517, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 2536, "__GeoType", 2536, 9, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 2546, "\"", 2618, 5);
            WriteAttributeValue("", 2553, "PagesList[", 2553, 10, true);
#line 47 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 2563, Model.PageId, 2563, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2578, "].Questions[", 2578, 12, true);
#line 47 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 2590, Model.QuestionId, 2590, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 2609, "].GeoType", 2609, 9, true);
            EndWriteAttribute();
            BeginContext(2619, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(2634, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "765b7cbf424d4242a4859d32cf89a8f2", async() => {
                BeginContext(2672, 6, true);
                WriteLiteral("Marker");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            BeginContext(2687, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(2701, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc7d63d0cfd448f9aac0ea0d3a659775", async() => {
                BeginContext(2719, 4, true);
                WriteLiteral("Lijn");
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
            BeginContext(2732, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(2746, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbae46c9540e49cb839f25f82795ea17", async() => {
                BeginContext(2764, 4, true);
                WriteLiteral("Vlak");
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
            BeginContext(2777, 33, true);
            WriteLiteral("\r\n        </select>\r\n    </div>\r\n");
            EndContext();
#line 53 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
}

#line default
#line hidden
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
