#pragma checksum "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Survey\AllAnswers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1eb87a5ce373ccbc101a5d486a95f8f64f3370bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Survey_AllAnswers), @"mvc.1.0.view", @"/Views/Survey/AllAnswers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Survey/AllAnswers.cshtml", typeof(AspNetCore.Views_Survey_AllAnswers))]
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
#line 7 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Survey\AllAnswers.cshtml"
using DataModels;

#line default
#line hidden
#line 8 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Survey\AllAnswers.cshtml"
using DataModels.Answers;

#line default
#line hidden
#line 9 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Survey\AllAnswers.cshtml"
using DataModels.Questions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1eb87a5ce373ccbc101a5d486a95f8f64f3370bb", @"/Views/Survey/AllAnswers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d0bc4e9b17a8b143e226c8e7b1c445550acc752", @"/Views/_ViewImports.cshtml")]
    public class Views_Survey_AllAnswers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataModels.Survey>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("include", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "https://stackpath.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-fallback-href", "~/lib/bootstrap/dist/css/bootstrap.min.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-fallback-test-class", "sr-only", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-fallback-test-property", "position", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-fallback-test-value", "absolute", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/css/site.min.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("exclude", "Development", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/WijkBeweegKaart Logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("WijkBeweegKaart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 80px; width: 360px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("p-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_15 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("overflow: hidden;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Survey\AllAnswers.cshtml"
  
    ViewData["Title"] = "AllAnswers";
    Layout = null;

#line default
#line hidden
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(171, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(198, 991, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d138ee5621f4e718e37213d72be2ee6", async() => {
                BeginContext(204, 318, true);
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <title>WijkBeweegKaart</title>

    <link rel=""stylesheet"" href=""https://unpkg.com/leaflet@1.6.0/dist/leaflet.css"" />
    <script src=""https://unpkg.com/leaflet@1.6.0/dist/leaflet.js""></script>

    ");
                EndContext();
                BeginContext(522, 193, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66c5a8da17d64ae8927ff08e7456f9fe", async() => {
                    BeginContext(557, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(567, 71, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "72535431ff494266a8572233bf895128", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(638, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(648, 47, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "459b9703b912439482a95623af5931c5", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(695, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Include = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(715, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(721, 457, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e703fe762724f5089170ddcaf1401da", async() => {
                    BeginContext(756, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(766, 305, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3af3e9d16b634721a0e7035641f48ed1", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_4.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.FallbackHref = (string)__tagHelperAttribute_5.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.FallbackTestClass = (string)__tagHelperAttribute_6.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.FallbackTestProperty = (string)__tagHelperAttribute_7.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.FallbackTestValue = (string)__tagHelperAttribute_8.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1071, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(1081, 77, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "886c9a547211456fb62c55f60b1ad101", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_9.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
#line 30 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Survey\AllAnswers.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1158, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Exclude = (string)__tagHelperAttribute_10.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1178, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1189, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1193, 2907, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1c0d58af60144276a6519dbb5bf950b4", async() => {
                BeginContext(1237, 131, true);
                WriteLiteral("\r\n    <nav class=\"navbar navbar-light\" style=\"background-color: #F9A11B;\">\r\n        <a class=\"navbar-brand\" href=\"#\">\r\n            ");
                EndContext();
                BeginContext(1368, 105, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c12c510321884a2a9e12659663d8f645", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1473, 73, true);
                WriteLiteral("\r\n        </a>\r\n    </nav>\r\n\r\n<div class=\"container-fluid p-0\">\r\n    <h1>");
                EndContext();
                BeginContext(1547, 11, false);
#line 43 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Survey\AllAnswers.cshtml"
   Write(Model.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1558, 18, true);
                WriteLiteral("</h1>\r\n    <div>\r\n");
                EndContext();
#line 45 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Survey\AllAnswers.cshtml"
         foreach (Page pageModel in Model.Pages)
        {

#line default
#line hidden
                BeginContext(1637, 16, true);
                WriteLiteral("            <h1>");
                EndContext();
                BeginContext(1654, 15, false);
#line 47 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Survey\AllAnswers.cshtml"
           Write(pageModel.Title);

#line default
#line hidden
                EndContext();
                BeginContext(1669, 7, true);
                WriteLiteral("</h1>\r\n");
                EndContext();
#line 48 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Survey\AllAnswers.cshtml"

                foreach (Question question in pageModel.Questions)
                {

#line default
#line hidden
                BeginContext(1765, 91, true);
                WriteLiteral("                    <table>\r\n                        <tr>\r\n                            <th>");
                EndContext();
                BeginContext(1857, 14, false);
#line 53 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Survey\AllAnswers.cshtml"
                           Write(question.Value);

#line default
#line hidden
                EndContext();
                BeginContext(1871, 38, true);
                WriteLiteral("</th>\r\n                        </tr>\r\n");
                EndContext();
#line 55 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Survey\AllAnswers.cshtml"
                         foreach (Answer answer in question.Answers)
                        {

#line default
#line hidden
                BeginContext(2006, 34, true);
                WriteLiteral("                            <tr>\r\n");
                EndContext();
#line 58 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Survey\AllAnswers.cshtml"
                             switch (question.Type)
                             {
                                 case TypeEnum.GeoVraag:
                                     var geo = answer as GeoAnswer;

#line default
#line hidden
                BeginContext(2252, 84, true);
                WriteLiteral("                                     <td>\r\n                                         ");
                EndContext();
                BeginContext(2337, 11, false);
#line 63 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Survey\AllAnswers.cshtml"
                                    Write(geo.GeoData);

#line default
#line hidden
                EndContext();
                BeginContext(2348, 46, true);
                WriteLiteral("\r\n                                     </td>\r\n");
                EndContext();
#line 65 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Survey\AllAnswers.cshtml"
                                     break;

                                 case TypeEnum.NummerVraag:
                                     var number = answer as NumberAnswer;

#line default
#line hidden
                BeginContext(2577, 84, true);
                WriteLiteral("                                     <td>\r\n                                         ");
                EndContext();
                BeginContext(2662, 18, false);
#line 70 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Survey\AllAnswers.cshtml"
                                    Write(number.NumberValue);

#line default
#line hidden
                EndContext();
                BeginContext(2680, 46, true);
                WriteLiteral("\r\n                                     </td>\r\n");
                EndContext();
#line 72 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Survey\AllAnswers.cshtml"
                                     break;

                                 case TypeEnum.SliderVraag:
                                     var slider = answer as NumberAnswer;

#line default
#line hidden
                BeginContext(2909, 84, true);
                WriteLiteral("                                     <td>\r\n                                         ");
                EndContext();
                BeginContext(2994, 18, false);
#line 77 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Survey\AllAnswers.cshtml"
                                    Write(slider.NumberValue);

#line default
#line hidden
                EndContext();
                BeginContext(3012, 46, true);
                WriteLiteral("\r\n                                     </td>\r\n");
                EndContext();
#line 79 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Survey\AllAnswers.cshtml"
                                     break;

                                 case TypeEnum.OpenVraag:
                                     var open = answer as TextAnswer;

#line default
#line hidden
                BeginContext(3235, 84, true);
                WriteLiteral("                                     <td>\r\n                                         ");
                EndContext();
                BeginContext(3320, 14, false);
#line 84 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Survey\AllAnswers.cshtml"
                                    Write(open.TextValue);

#line default
#line hidden
                EndContext();
                BeginContext(3334, 46, true);
                WriteLiteral("\r\n                                     </td>\r\n");
                EndContext();
#line 86 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Survey\AllAnswers.cshtml"
                                     break;

                                 case TypeEnum.MeerkeuzeVraag:
                                     var multipleChoiceAnswer = answer as MultipleChoiceAnswer;

#line default
#line hidden
                BeginContext(3588, 84, true);
                WriteLiteral("                                     <td>\r\n                                         ");
                EndContext();
                BeginContext(3673, 76, false);
#line 91 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Survey\AllAnswers.cshtml"
                                    Write(string.Join(" ", multipleChoiceAnswer.AnsweredOptions.Select(t => t.Value )));

#line default
#line hidden
                EndContext();
                BeginContext(3749, 47, true);
                WriteLiteral(";\r\n                                     </td>\r\n");
                EndContext();
#line 93 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Survey\AllAnswers.cshtml"
                                     break;
                             }

#line default
#line hidden
                BeginContext(3873, 36, true);
                WriteLiteral("                                <td>");
                EndContext();
                BeginContext(3910, 27, false);
#line 95 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Survey\AllAnswers.cshtml"
                               Write(answer.Respondant.SessionId);

#line default
#line hidden
                EndContext();
                BeginContext(3937, 43, true);
                WriteLiteral(" </td>\r\n                            </tr>\r\n");
                EndContext();
#line 97 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Survey\AllAnswers.cshtml"
                        }

#line default
#line hidden
                BeginContext(4007, 30, true);
                WriteLiteral("                    </table>\r\n");
                EndContext();
#line 99 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Survey\AllAnswers.cshtml"
                }


        }

#line default
#line hidden
                BeginContext(4071, 22, true);
                WriteLiteral("    </div>\r\n</div>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_15);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4100, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataModels.Survey> Html { get; private set; }
    }
}
#pragma warning restore 1591
