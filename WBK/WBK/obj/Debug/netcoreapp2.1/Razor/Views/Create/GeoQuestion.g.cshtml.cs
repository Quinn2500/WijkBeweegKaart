#pragma checksum "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db50b7cabfb0508bab4dc60ff3823671420a5014"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db50b7cabfb0508bab4dc60ff3823671420a5014", @"/Views/Create/GeoQuestion.cshtml")]
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
            BeginContext(176, 146, true);
            WriteLiteral(" class=\"map\" style=\"height: 400px; width: 400px;\"></div>\r\n    <p>Klik op de kaart om de waardes in te voeren!</p>\r\n    <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 322, "\"", 401, 5);
            WriteAttributeValue("", 327, "PagesList_", 327, 10, true);
#line 12 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 337, Model.PageId, 337, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 352, "__Questions_", 352, 12, true);
#line 12 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 364, Model.QuestionId, 364, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 383, "__StartLocationLat", 383, 18, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 402, "\"", 483, 5);
            WriteAttributeValue("", 409, "PagesList[", 409, 10, true);
#line 12 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 419, Model.PageId, 419, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 434, "].Questions[", 434, 12, true);
#line 12 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 446, Model.QuestionId, 446, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 465, "].StartLocationLat", 465, 18, true);
            EndWriteAttribute();
            BeginContext(484, 65, true);
            WriteLiteral(" type=\"text\" value=\"Latitude\" />\r\n    <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 549, "\"", 629, 5);
            WriteAttributeValue("", 554, "PagesList_", 554, 10, true);
#line 13 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 564, Model.PageId, 564, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 579, "__Questions_", 579, 12, true);
#line 13 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 591, Model.QuestionId, 591, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 610, "__StartLocationLong", 610, 19, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 630, "\"", 712, 5);
            WriteAttributeValue("", 637, "PagesList[", 637, 10, true);
#line 13 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 647, Model.PageId, 647, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 662, "].Questions[", 662, 12, true);
#line 13 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 674, Model.QuestionId, 674, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 693, "].StartLocationLong", 693, 19, true);
            EndWriteAttribute();
            BeginContext(713, 66, true);
            WriteLiteral(" type=\"text\" value=\"Longitude\" />\r\n    <input class=\"form-control\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 779, "\"", 856, 5);
            WriteAttributeValue("", 784, "PagesList_", 784, 10, true);
#line 14 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 794, Model.PageId, 794, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 809, "__Questions_", 809, 12, true);
#line 14 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 821, Model.QuestionId, 821, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 840, "__StartZoomLevel", 840, 16, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 857, "\"", 936, 5);
            WriteAttributeValue("", 864, "PagesList[", 864, 10, true);
#line 14 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 874, Model.PageId, 874, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 889, "].Questions[", 889, 12, true);
#line 14 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 901, Model.QuestionId, 901, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 920, "].StartZoomLevel", 920, 16, true);
            EndWriteAttribute();
            BeginContext(937, 157, true);
            WriteLiteral(" type=\"number\" />\r\n    \r\n    <label>Marker Type:</label>\r\n    <select class=\"form-control\" data-val=\"true\" data-val-required=\"The GeoType field is required.\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1094, "\"", 1164, 5);
            WriteAttributeValue("", 1099, "PagesList_", 1099, 10, true);
#line 17 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 1109, Model.PageId, 1109, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1124, "__Questions_", 1124, 12, true);
#line 17 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 1136, Model.QuestionId, 1136, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 1155, "__GeoType", 1155, 9, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 1165, "\"", 1237, 5);
            WriteAttributeValue("", 1172, "PagesList[", 1172, 10, true);
#line 17 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 1182, Model.PageId, 1182, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 1197, "].Questions[", 1197, 12, true);
#line 17 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 1209, Model.QuestionId, 1209, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 1228, "].GeoType", 1228, 9, true);
            EndWriteAttribute();
            BeginContext(1238, 11, true);
            WriteLiteral(">\r\n        ");
            EndContext();
            BeginContext(1249, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7789a4fb86fe471ca5dee15f219833c6", async() => {
                BeginContext(1287, 6, true);
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
            BeginContext(1302, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1312, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2eb0e062345a42ab8e02d6c58e9775b9", async() => {
                BeginContext(1330, 4, true);
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
            BeginContext(1343, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1353, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04b475974a9f4b62904a32041ea9965b", async() => {
                BeginContext(1371, 4, true);
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
            BeginContext(1384, 25, true);
            WriteLiteral("\r\n    </select>\r\n</div>\r\n");
            EndContext();
            BeginContext(1411, 29, true);
            WriteLiteral("    <script>\r\n        var map");
            EndContext();
            BeginContext(1442, 12, false);
#line 25 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
           Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(1455, 15, true);
            WriteLiteral(" = L.map(\'mapid");
            EndContext();
            BeginContext(1472, 12, false);
#line 25 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                                         Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(1485, 330, true);
            WriteLiteral(@"').setView([51.47358, 5.453167], 13);
        var OpenStreetMap_Mapnik = L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png',
            {
                maxZoom: 19,
                attribution: '&copy; <a href=""https://www.openstreetmap.org/copyright"">OpenStreetMap</a> contributors'
            }).addTo(map");
            EndContext();
            BeginContext(1817, 12, false);
#line 30 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                    Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(1830, 24, true);
            WriteLiteral(");\r\n\r\n        var marker");
            EndContext();
            BeginContext(1856, 12, false);
#line 32 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
              Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(1869, 45, true);
            WriteLiteral(" = L.marker();\r\n\r\n        function onMapClick");
            EndContext();
            BeginContext(1916, 12, false);
#line 34 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                       Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(1929, 25, true);
            WriteLiteral("(e) {\r\n            marker");
            EndContext();
            BeginContext(1956, 12, false);
#line 35 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
              Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(1969, 143, true);
            WriteLiteral("\r\n                .setLatLng(e.latlng)\r\n                .bindPopup(\"You clicked the map at \" + e.latlng.toString())\r\n                .addTo(map");
            EndContext();
            BeginContext(2114, 12, false);
#line 38 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                      Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(2127, 52, true);
            WriteLiteral(" );\r\n            document.getElementById(\"PagesList_");
            EndContext();
            BeginContext(2181, 12, false);
#line 39 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                                           Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(2194, 12, true);
            WriteLiteral("__Questions_");
            EndContext();
            BeginContext(2208, 16, false);
#line 39 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                                                                      Write(Model.QuestionId);

#line default
#line hidden
            EndContext();
            BeginContext(2225, 91, true);
            WriteLiteral("__StartLocationLat\").value = e.latlng.lat;\r\n            document.getElementById(\"PagesList_");
            EndContext();
            BeginContext(2318, 12, false);
#line 40 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                                           Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(2331, 12, true);
            WriteLiteral("__Questions_");
            EndContext();
            BeginContext(2345, 16, false);
#line 40 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                                                                      Write(Model.QuestionId);

#line default
#line hidden
            EndContext();
            BeginContext(2362, 92, true);
            WriteLiteral("__StartLocationLong\").value = e.latlng.lng;\r\n            document.getElementById(\"PagesList_");
            EndContext();
            BeginContext(2456, 12, false);
#line 41 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                                           Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(2469, 12, true);
            WriteLiteral("__Questions_");
            EndContext();
            BeginContext(2483, 16, false);
#line 41 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                                                                      Write(Model.QuestionId);

#line default
#line hidden
            EndContext();
            BeginContext(2500, 30, true);
            WriteLiteral("__StartZoomLevel\").value = map");
            EndContext();
            BeginContext(2532, 12, false);
#line 41 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                                                                                                                       Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(2545, 35, true);
            WriteLiteral(".getZoom();\r\n        }\r\n        map");
            EndContext();
            BeginContext(2582, 12, false);
#line 43 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
       Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(2595, 23, true);
            WriteLiteral(".on(\'click\', onMapClick");
            EndContext();
            BeginContext(2620, 12, false);
#line 43 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
                                             Write(Model.PageId);

#line default
#line hidden
            EndContext();
            BeginContext(2633, 19, true);
            WriteLiteral(");\r\n    </script>\r\n");
            EndContext();
#line 45 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(2664, 172, true);
            WriteLiteral("    <div class=\"geo question\">\r\n        <label>Marker Type:</label>\r\n        <select class=\"form-control\" data-val=\"true\" data-val-required=\"The GeoType field is required.\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2836, "\"", 2906, 5);
            WriteAttributeValue("", 2841, "PagesList_", 2841, 10, true);
#line 50 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 2851, Model.PageId, 2851, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2866, "__Questions_", 2866, 12, true);
#line 50 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 2878, Model.QuestionId, 2878, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 2897, "__GeoType", 2897, 9, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 2907, "\"", 2979, 5);
            WriteAttributeValue("", 2914, "PagesList[", 2914, 10, true);
#line 50 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 2924, Model.PageId, 2924, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2939, "].Questions[", 2939, 12, true);
#line 50 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
WriteAttributeValue("", 2951, Model.QuestionId, 2951, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 2970, "].GeoType", 2970, 9, true);
            EndWriteAttribute();
            BeginContext(2980, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(2995, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2f8f31d626b4895978ce35d574d3023", async() => {
                BeginContext(3033, 6, true);
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
            BeginContext(3048, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(3062, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ded88ea89c044e2bf228e1229bd0e73", async() => {
                BeginContext(3080, 4, true);
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
            BeginContext(3093, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(3107, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "515141d7c67348379591564252ad7c9a", async() => {
                BeginContext(3125, 4, true);
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
            BeginContext(3138, 33, true);
            WriteLiteral("\r\n        </select>\r\n    </div>\r\n");
            EndContext();
#line 56 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\GeoQuestion.cshtml"
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
