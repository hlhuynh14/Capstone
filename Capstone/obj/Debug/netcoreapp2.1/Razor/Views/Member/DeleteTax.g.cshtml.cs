#pragma checksum "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\DeleteTax.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea4f4012748bb7cb257e33c7296096eaced38e29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_DeleteTax), @"mvc.1.0.view", @"/Views/Member/DeleteTax.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Member/DeleteTax.cshtml", typeof(AspNetCore.Views_Member_DeleteTax))]
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
#line 1 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\_ViewImports.cshtml"
using Capstone;

#line default
#line hidden
#line 2 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\_ViewImports.cshtml"
using Capstone.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea4f4012748bb7cb257e33c7296096eaced38e29", @"/Views/Member/DeleteTax.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5550a5566af2cccd7ab948f317210912bffdd3af", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_DeleteTax : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Domain.Tax>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteTax", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\DeleteTax.cshtml"
  
    ViewData["Title"] = "DeleteTax";
   Layout = "~/Views/Shared/MemberLayout.cshtml";

#line default
#line hidden
            BeginContext(117, 208, true);
            WriteLiteral("\r\n<h2>Delete Tax</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            Filling Status:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(326, 45, false);
#line 18 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\DeleteTax.cshtml"
       Write(Html.DisplayFor(model => model.FillingStatus));

#line default
#line hidden
            EndContext();
            BeginContext(371, 92, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            State:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(464, 48, false);
#line 24 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\DeleteTax.cshtml"
       Write(Html.DisplayFor(model => model.StateAbbrevation));

#line default
#line hidden
            EndContext();
            BeginContext(512, 99, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Gross Income:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(612, 43, false);
#line 30 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\DeleteTax.cshtml"
       Write(Html.DisplayFor(model => model.GrossIncome));

#line default
#line hidden
            EndContext();
            BeginContext(655, 97, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Deductions:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(753, 43, false);
#line 36 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\DeleteTax.cshtml"
       Write(Html.DisplayFor(model => model.Deductibles));

#line default
#line hidden
            EndContext();
            BeginContext(796, 101, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Taxable Income:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(898, 45, false);
#line 42 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\DeleteTax.cshtml"
       Write(Html.DisplayFor(model => model.TaxableIncome));

#line default
#line hidden
            EndContext();
            BeginContext(943, 98, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Federal Tax:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1042, 42, false);
#line 48 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\DeleteTax.cshtml"
       Write(Html.DisplayFor(model => model.FederalTax));

#line default
#line hidden
            EndContext();
            BeginContext(1084, 96, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            State Tax:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1181, 40, false);
#line 54 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\DeleteTax.cshtml"
       Write(Html.DisplayFor(model => model.StateTax));

#line default
#line hidden
            EndContext();
            BeginContext(1221, 99, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Medicare Tax:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1321, 43, false);
#line 60 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\DeleteTax.cshtml"
       Write(Html.DisplayFor(model => model.MedicareTax));

#line default
#line hidden
            EndContext();
            BeginContext(1364, 106, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Social Security Tax:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1471, 49, false);
#line 66 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\DeleteTax.cshtml"
       Write(Html.DisplayFor(model => model.SocialSecurityTax));

#line default
#line hidden
            EndContext();
            BeginContext(1520, 107, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Estimated Net Income:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1628, 50, false);
#line 72 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\DeleteTax.cshtml"
       Write(Html.DisplayFor(model => model.EstimatedNetIncome));

#line default
#line hidden
            EndContext();
            BeginContext(1678, 115, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            Estimated Monthly Net Income:\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1794, 53, false);
#line 78 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\DeleteTax.cshtml"
       Write(Html.DisplayFor(model => model.EstimatedMontlyIncome));

#line default
#line hidden
            EndContext();
            BeginContext(1847, 32, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    ");
            EndContext();
            BeginContext(1879, 161, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1272520a8e97491eb16799ca867f2115", async() => {
                BeginContext(1908, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1918, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "899dc33f0afd45a9930ab2b341bdb962", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 82 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\DeleteTax.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1954, 79, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> \r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2040, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Domain.Tax> Html { get; private set; }
    }
}
#pragma warning restore 1591