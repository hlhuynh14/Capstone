#pragma checksum "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31c92fb96a5c8a09e7306ebfb0b9ab9ddf3a9987"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31c92fb96a5c8a09e7306ebfb0b9ab9ddf3a9987", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5550a5566af2cccd7ab948f317210912bffdd3af", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(51, 3779, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ee26afdb62b417d84edd82c52fd201d", async() => {
                BeginContext(57, 12, true);
                WriteLiteral("\r\n\r\n        ");
                EndContext();
                BeginContext(69, 3748, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "11587f9ee40b4bde800f913455176324", async() => {
                    BeginContext(89, 3721, true);
                    WriteLiteral(@"
            <fieldset>
                <legend>Monthly Budget</legend>
                <div class=""row"">
                    <div class=""col-md-4"">
                        <div>
                            <label for=""netPay"">Monthly Net Pay:</label>
                            <input type=""text"" id=""netPay"" value=""0"" />
                        </div>
                        <div>
                            <label for=""netPay2"">Extra Income:</label>
                            <input type=""text"" id=""netPay2"" value=""0"" />
                        </div>
                        <br />
                        <h4>Expenses</h4>
                        <div >
                            <label for=""housing"">Housing:</label>
                            <input type=""text"" id=""housing"" value=""0"" />
                        </div>
                        <div>
                            <label for=""utilities"">Utilities:</label>
                            <input type=""text"" id=""utilities"" value=""");
                    WriteLiteral(@"0"" />
                        </div>
                        <div>
                            <label for=""otherBills"">Other Bills:</label>
                            <input type=""text"" id=""otherBills"" value=""0"" />
                        </div>
                    </div>
                    <div class=""col-md-4"">

                 
                        <h4>Split Percentages</h4>
                        <div>
                            <label for=""savings"">Savings:</label>
                            <input type=""text"" id=""savings"" value=""20"" />
                        </div>
                        <div>
                            <label for=""food"">Food:</label>
                            <input type=""text"" id=""food"" value=""40"" />
                        </div>
                        <div>
                            <label for=""entertainment"">Entertainment:</label>
                            <input type=""text"" id=""entertainment"" value=""20"" />
                        </div>
  ");
                    WriteLiteral(@"                      <div >
                            <label for=""others"">Others:</label>
                            <input type=""text"" id=""others"" value=""20"" />
                        </div>
                        <div>
                            <label>&nbsp;</label>
                            <input type=""button"" value=""Calculate"" onclick=""CalculateBudget()"" />
                        </div>
                    </div>
                    <div class=""col-md-4"">
                        <div >
                            <label for=""remaining"">Remaining:</label>
                            <input type=""text"" id=""remaining"" value=""0"" />
                        </div>
                        <h4>Each category gets</h4>

                        <div >
                            <label for=""savings1"">Savings:</label>
                            <input type=""text"" id=""savings1"" value=""0"" />
                        </div>
                        <div >
                            <labe");
                    WriteLiteral(@"l for=""food1"">Food:</label>
                            <input type=""text"" id=""food1"" value=""0"" />
                        </div>
                        <div >
                            <label for=""entertainment1"">Entertainment:</label>
                            <input type=""text"" id=""entertainment1"" value=""0"" />
                        </div>
                        <div >
                            <label for=""others1"">Others:</label>
                            <input type=""text"" id=""others1"" value=""0"" />
                        </div>

                    </div>
                </div>
            </fieldset>
        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3817, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3830, 6, true);
            WriteLiteral("\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
