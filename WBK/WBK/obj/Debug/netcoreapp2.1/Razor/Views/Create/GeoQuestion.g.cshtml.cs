#pragma checksum "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39c53632efda0f705bcbf240242273ca07251163"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39c53632efda0f705bcbf240242273ca07251163", @"/Views/Create/GeoQuestion.cshtml")]
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
            BeginContext(114, 106, true);
            WriteLiteral("    <div class=\"geo question\">\r\n        <p>Klik op de kaart om het startpunt te bepalen.</p>\r\n        <div");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 220, "\"", 245, 2);
            WriteAttributeValue("", 225, "mapid", 225, 5, true);
#line 11 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 230, Model.PageId, 230, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(246, 154, true);
            WriteLiteral(" class=\"map\" style=\"height: 400px; width: 400px;\"></div>\r\n        <p>Klik op de kaart om de waardes in te voeren!</p>\r\n        <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 400, "\"", 479, 5);
            WriteAttributeValue("", 405, "PagesList_", 405, 10, true);
#line 13 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 415, Model.PageId, 415, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 430, "__Questions_", 430, 12, true);
#line 13 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 442, Model.QuestionId, 442, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 461, "__StartLocationLat", 461, 18, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 480, "\"", 561, 5);
            WriteAttributeValue("", 487, "PagesList[", 487, 10, true);
#line 13 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 497, Model.PageId, 497, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 512, "].Questions[", 512, 12, true);
#line 13 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 524, Model.QuestionId, 524, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 543, "].StartLocationLat", 543, 18, true);
            EndWriteAttribute();
            BeginContext(562, 68, true);
            WriteLiteral(" type=\"text\" value=\"Latitude\"/>\r\n        <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 630, "\"", 710, 5);
            WriteAttributeValue("", 635, "PagesList_", 635, 10, true);
#line 14 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 645, Model.PageId, 645, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 660, "__Questions_", 660, 12, true);
#line 14 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 672, Model.QuestionId, 672, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 691, "__StartLocationLong", 691, 19, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 711, "\"", 793, 5);
            WriteAttributeValue("", 718, "PagesList[", 718, 10, true);
#line 14 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 728, Model.PageId, 728, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 743, "].Questions[", 743, 12, true);
#line 14 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 755, Model.QuestionId, 755, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 774, "].StartLocationLong", 774, 19, true);
            EndWriteAttribute();
            BeginContext(794, 69, true);
            WriteLiteral(" type=\"text\" value=\"Longitude\"/>\r\n        <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 863, "\"", 940, 5);
            WriteAttributeValue("", 868, "PagesList_", 868, 10, true);
#line 15 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 878, Model.PageId, 878, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 893, "__Questions_", 893, 12, true);
#line 15 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 905, Model.QuestionId, 905, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 924, "__StartZoomLevel", 924, 16, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 941, "\"", 1020, 5);
            WriteAttributeValue("", 948, "PagesList[", 948, 10, true);
#line 15 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 958, Model.PageId, 958, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 973, "].Questions[", 973, 12, true);
#line 15 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 985, Model.QuestionId, 985, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 1004, "].StartZoomLevel", 1004, 16, true);
            EndWriteAttribute();
            BeginContext(1021, 160, true);
            WriteLiteral(" type=\"number\"/>\r\n\r\n        <label>Marker Type:</label>\r\n        <select class=\"form-control\" data-val=\"true\" data-val-required=\"The GeoType field is required.\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1181, "\"", 1251, 5);
            WriteAttributeValue("", 1186, "PagesList_", 1186, 10, true);
#line 18 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 1196, Model.PageId, 1196, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1211, "__Questions_", 1211, 12, true);
#line 18 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 1223, Model.QuestionId, 1223, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 1242, "__GeoType", 1242, 9, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 1252, "\"", 1324, 5);
            WriteAttributeValue("", 1259, "PagesList[", 1259, 10, true);
#line 18 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 1269, Model.PageId, 1269, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1284, "].Questions[", 1284, 12, true);
#line 18 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 1296, Model.QuestionId, 1296, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 1315, "].GeoType", 1315, 9, true);
            EndWriteAttribute();
            BeginContext(1325, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(1340, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "96bf7499b359443ab9259fe61aa05df1", async() => {
                BeginContext(1378, 6, true);
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
            BeginContext(1393, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1407, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33a8209c93aa47b286b3f870cb19cf56", async() => {
                BeginContext(1425, 4, true);
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
            BeginContext(1438, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(1452, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "377863e6a3d04c5e85a5b843dbc4490a", async() => {
                BeginContext(1470, 4, true);
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
            BeginContext(1483, 33, true);
            WriteLiteral("\r\n        </select>\r\n    </div>\r\n");
            EndContext();
            BeginContext(1518, 29, true);
            WriteLiteral("    <script>\r\n        var map");
            EndContext();
            BeginContext(1549, 12, false);
#line 26 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
           Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(1562, 15, true);
            WriteLiteral(" = L.map(\'mapid");
            EndContext();
            BeginContext(1579, 12, false);
#line 26 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                                         Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(1592, 330, true);
            WriteLiteral(@"').setView([51.47358, 5.453167], 13);
        var OpenStreetMap_Mapnik = L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png',
            {
                maxZoom: 19,
                attribution: '&copy; <a href=""https://www.openstreetmap.org/copyright"">OpenStreetMap</a> contributors'
            }).addTo(map");
            EndContext();
            BeginContext(1924, 12, false);
#line 31 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                    Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(1937, 24, true);
            WriteLiteral(");\r\n\r\n        var marker");
            EndContext();
            BeginContext(1963, 12, false);
#line 33 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
              Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(1976, 45, true);
            WriteLiteral(" = L.marker();\r\n\r\n        function onMapClick");
            EndContext();
            BeginContext(2023, 12, false);
#line 35 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                       Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(2036, 25, true);
            WriteLiteral("(e) {\r\n            marker");
            EndContext();
            BeginContext(2063, 12, false);
#line 36 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
              Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(2076, 143, true);
            WriteLiteral("\r\n                .setLatLng(e.latlng)\r\n                .bindPopup(\"You clicked the map at \" + e.latlng.toString())\r\n                .addTo(map");
            EndContext();
            BeginContext(2221, 12, false);
#line 39 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                      Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(2234, 52, true);
            WriteLiteral(" );\r\n            document.getElementById(\"PagesList_");
            EndContext();
            BeginContext(2288, 12, false);
#line 40 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                                           Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(2301, 12, true);
            WriteLiteral("__Questions_");
            EndContext();
            BeginContext(2315, 16, false);
#line 40 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                                                                      Write(Model.QuestionId);

#line default
#line hidden
            EndContext();
            BeginContext(2332, 91, true);
            WriteLiteral("__StartLocationLat\").value = e.latlng.lat;\r\n            document.getElementById(\"PagesList_");
            EndContext();
            BeginContext(2425, 12, false);
#line 41 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                                           Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(2438, 12, true);
            WriteLiteral("__Questions_");
            EndContext();
            BeginContext(2452, 16, false);
#line 41 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                                                                      Write(Model.QuestionId);

#line default
#line hidden
            EndContext();
            BeginContext(2469, 92, true);
            WriteLiteral("__StartLocationLong\").value = e.latlng.lng;\r\n            document.getElementById(\"PagesList_");
            EndContext();
            BeginContext(2563, 12, false);
#line 42 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                                           Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(2576, 12, true);
            WriteLiteral("__Questions_");
            EndContext();
            BeginContext(2590, 16, false);
#line 42 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                                                                      Write(Model.QuestionId);

#line default
#line hidden
            EndContext();
            BeginContext(2607, 30, true);
            WriteLiteral("__StartZoomLevel\").value = map");
            EndContext();
            BeginContext(2639, 12, false);
#line 42 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                                                                                                                       Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(2652, 35, true);
            WriteLiteral(".getZoom();\r\n        }\r\n        map");
            EndContext();
            BeginContext(2689, 12, false);
#line 44 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
       Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(2702, 23, true);
            WriteLiteral(".on(\'click\', onMapClick");
            EndContext();
            BeginContext(2727, 12, false);
#line 44 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                                             Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(2740, 19, true);
            WriteLiteral(");\r\n    </script>\r\n");
            EndContext();
#line 46 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(2771, 172, true);
            WriteLiteral("    <div class=\"geo question\">\r\n        <label>Marker Type:</label>\r\n        <select class=\"form-control\" data-val=\"true\" data-val-required=\"The GeoType field is required.\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2943, "\"", 3013, 5);
            WriteAttributeValue("", 2948, "PagesList_", 2948, 10, true);
#line 51 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 2958, Model.PageId, 2958, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2973, "__Questions_", 2973, 12, true);
#line 51 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 2985, Model.QuestionId, 2985, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 3004, "__GeoType", 3004, 9, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 3014, "\"", 3086, 5);
            WriteAttributeValue("", 3021, "PagesList[", 3021, 10, true);
#line 51 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 3031, Model.PageId, 3031, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 3046, "].Questions[", 3046, 12, true);
#line 51 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 3058, Model.QuestionId, 3058, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 3077, "].GeoType", 3077, 9, true);
            EndWriteAttribute();
            BeginContext(3087, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(3102, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8784754fc2d94126b012bbeae73911fb", async() => {
                BeginContext(3140, 6, true);
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
            BeginContext(3155, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(3169, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cb6b912be744d2185b29cea76110782", async() => {
                BeginContext(3187, 4, true);
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
            BeginContext(3200, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(3214, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05e2f2c763e14d3c830433e0695ef671", async() => {
                BeginContext(3232, 4, true);
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
            BeginContext(3245, 33, true);
            WriteLiteral("\r\n        </select>\r\n    </div>\r\n");
            EndContext();
#line 57 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
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
