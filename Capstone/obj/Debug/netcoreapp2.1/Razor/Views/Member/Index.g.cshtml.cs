#pragma checksum "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1be526999bb8a8c54a0394b34091133e2ae002c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_Index), @"mvc.1.0.view", @"/Views/Member/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Member/Index.cshtml", typeof(AspNetCore.Views_Member_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1be526999bb8a8c54a0394b34091133e2ae002c", @"/Views/Member/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5550a5566af2cccd7ab948f317210912bffdd3af", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Domain.Member>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SeeBudget", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(112, 62, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<div>\r\n    <h4>Member</h4>\r\n    <hr />\r\n\r\n");
            EndContext();
            BeginContext(242, 7, true);
            WriteLiteral("<div>\r\n");
            EndContext();
#line 16 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index.cshtml"
     foreach (var item in Model.BudgetList)
    {

#line default
#line hidden
            BeginContext(301, 72, true);
            WriteLiteral("        <dl class=\"dl-horizontal\">\r\n\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(374, 43, false);
#line 21 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index.cshtml"
           Write(Html.DisplayNameFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(417, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(473, 39, false);
#line 24 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(512, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(568, 60, false);
#line 27 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index.cshtml"
           Write(Html.DisplayNameFor(modelItem => item.TotalMonthlyNetIncome));

#line default
#line hidden
            EndContext();
            BeginContext(628, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(684, 56, false);
#line 30 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalMonthlyNetIncome));

#line default
#line hidden
            EndContext();
            BeginContext(740, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(796, 57, false);
#line 33 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index.cshtml"
           Write(Html.DisplayNameFor(modelItem => item.RemainderAfterBill));

#line default
#line hidden
            EndContext();
            BeginContext(853, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(909, 53, false);
#line 36 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RemainderAfterBill));

#line default
#line hidden
            EndContext();
            BeginContext(962, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1018, 58, false);
#line 39 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index.cshtml"
           Write(Html.DisplayNameFor(modelItem => item.RemainderAfterGoals));

#line default
#line hidden
            EndContext();
            BeginContext(1076, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1132, 54, false);
#line 42 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RemainderAfterGoals));

#line default
#line hidden
            EndContext();
            BeginContext(1186, 55, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n                ");
            EndContext();
            BeginContext(1242, 61, false);
#line 45 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index.cshtml"
           Write(Html.DisplayNameFor(modelItem => item.RemainderAfterExpenses));

#line default
#line hidden
            EndContext();
            BeginContext(1303, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1359, 57, false);
#line 48 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RemainderAfterExpenses));

#line default
#line hidden
            EndContext();
            BeginContext(1416, 36, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n");
            EndContext();
#line 51 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1459, 12, true);
            WriteLiteral("</div>\r\n    ");
            EndContext();
            BeginContext(1471, 72, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61cbaad5993f403184fcc5e515301ae8", async() => {
                BeginContext(1523, 16, true);
                WriteLiteral("Calculate Budget");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index.cshtml"
                                WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1543, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Domain.Member> Html { get; private set; }
    }
}
#pragma warning restore 1591
