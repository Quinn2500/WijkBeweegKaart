#pragma checksum "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\NumberQuestion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf35d15d1115f2f7061347b6dce92e7521b91663"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Create_NumberQuestion), @"mvc.1.0.view", @"/Views/Create/NumberQuestion.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Create/NumberQuestion.cshtml", typeof(AspNetCore.Views_Create_NumberQuestion))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf35d15d1115f2f7061347b6dce92e7521b91663", @"/Views/Create/NumberQuestion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d0bc4e9b17a8b143e226c8e7b1c445550acc752", @"/Views/_ViewImports.cshtml")]
    public class Views_Create_NumberQuestion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WBK.Models.Create.PageQuestionModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\NumberQuestion.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(73, 164, true);
            WriteLiteral("\r\n\r\n<div class=\"question\">\r\n    <label>Minimale waarde:</label>\r\n    <input class=\"form-control\" data-val=\"true\" data-val-required=\"The MinValue field is required.\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 237, "\"", 308, 5);
            WriteAttributeValue("", 242, "PagesList_", 242, 10, true);
#line 10 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\NumberQuestion.cshtml"
WriteAttributeValue("", 252, Model.PageId, 252, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 267, "__Questions_", 267, 12, true);
#line 10 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\NumberQuestion.cshtml"
WriteAttributeValue("", 279, Model.QuestionId, 279, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 298, "__MinValue", 298, 10, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 309, "\"", 382, 5);
            WriteAttributeValue("", 316, "PagesList[", 316, 10, true);
#line 10 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\NumberQuestion.cshtml"
WriteAttributeValue("", 326, Model.PageId, 326, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 341, "].Questions[", 341, 12, true);
#line 10 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\NumberQuestion.cshtml"
WriteAttributeValue("", 353, Model.QuestionId, 353, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 372, "].MinValue", 372, 10, true);
            EndWriteAttribute();
            BeginContext(383, 153, true);
            WriteLiteral(" type=\"number\">\r\n    <label>Maximale waarde:</label>\r\n    <input class=\"form-control\" data-val=\"true\" data-val-required=\"The MaxValue field is required.\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 536, "\"", 607, 5);
            WriteAttributeValue("", 541, "PagesList_", 541, 10, true);
#line 12 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\NumberQuestion.cshtml"
WriteAttributeValue("", 551, Model.PageId, 551, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 566, "__Questions_", 566, 12, true);
#line 12 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\NumberQuestion.cshtml"
WriteAttributeValue("", 578, Model.QuestionId, 578, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 597, "__MaxValue", 597, 10, true);
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=\"", 608, "\"", 681, 5);
            WriteAttributeValue("", 615, "PagesList[", 615, 10, true);
#line 12 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\NumberQuestion.cshtml"
WriteAttributeValue("", 625, Model.PageId, 625, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 640, "].Questions[", 640, 12, true);
#line 12 "D:\GitKraken\Repos\WijkBeweegKaart\WBK\WBK\Views\Create\NumberQuestion.cshtml"
WriteAttributeValue("", 652, Model.QuestionId, 652, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 671, "].MaxValue", 671, 10, true);
            EndWriteAttribute();
            BeginContext(682, 23, true);
            WriteLiteral(" type=\"number\">\r\n</div>");
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
