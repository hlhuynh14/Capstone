#pragma checksum "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc5800bec21d15d2e29441d83744a5331d552e55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Member_Index2), @"mvc.1.0.view", @"/Views/Member/Index2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Member/Index2.cshtml", typeof(AspNetCore.Views_Member_Index2))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc5800bec21d15d2e29441d83744a5331d552e55", @"/Views/Member/Index2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5550a5566af2cccd7ab948f317210912bffdd3af", @"/Views/_ViewImports.cshtml")]
    public class Views_Member_Index2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Domain.Member>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/MemberLayout.cshtml";

#line default
#line hidden
            BeginContext(117, 21, true);
            WriteLiteral("\r\n\r\n\r\n<div>\r\n    <h2>");
            EndContext();
            BeginContext(139, 15, false);
#line 11 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
   Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(154, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(156, 14, false);
#line 11 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                    Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(170, 175, true);
            WriteLiteral(" \' s Home Page</h2>\r\n    <hr />\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-4\">\r\n\r\n\r\n                <h3>Budget (In Dollars)</h3>\r\n");
            EndContext();
#line 19 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                 foreach (var item in Model.BudgetList)
                {

#line default
#line hidden
            BeginContext(421, 108, true);
            WriteLiteral("                    <dl class=\"dl-horizontal\">\r\n\r\n                        <dt>\r\n                            ");
            EndContext();
            BeginContext(530, 43, false);
#line 24 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                       Write(Html.DisplayNameFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(573, 91, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(665, 39, false);
#line 27 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(704, 203, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            Total Monthly Income:\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(908, 56, false);
#line 33 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TotalMonthlyNetIncome));

#line default
#line hidden
            EndContext();
            BeginContext(964, 194, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            After Bills:\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(1159, 53, false);
#line 39 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                       Write(Html.DisplayFor(modelItem => item.RemainderAfterBill));

#line default
#line hidden
            EndContext();
            BeginContext(1212, 195, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            After Saving:\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(1408, 54, false);
#line 45 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                       Write(Html.DisplayFor(modelItem => item.RemainderAfterGoals));

#line default
#line hidden
            EndContext();
            BeginContext(1462, 192, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            Remainder:\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(1655, 57, false);
#line 51 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                       Write(Html.DisplayFor(modelItem => item.RemainderAfterExpenses));

#line default
#line hidden
            EndContext();
            BeginContext(1712, 60, true);
            WriteLiteral("\r\n                        </dd>\r\n                    </dl>\r\n");
            EndContext();
#line 54 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                }

#line default
#line hidden
            BeginContext(1791, 345, true);
            WriteLiteral(@"            </div>

            <div class=""col-md-4"">

                <div id=""chart2""></div>
            </div>



        </div>
        
    </div>
</div>





<div>

    <hr />
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-4"">


                <h3>Taxes (In Dollars)</h3>
");
            EndContext();
#line 82 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                 foreach (var item in Model.TaxList)
                {

#line default
#line hidden
            BeginContext(2209, 210, true);
            WriteLiteral("                    <dl class=\"dl-horizontal\">\r\n                        <dt>\r\n                            Gross Income:\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(2420, 46, false);
#line 89 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                       Write(Html.DisplayFor(modelItem => item.GrossIncome));

#line default
#line hidden
            EndContext();
            BeginContext(2466, 193, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            Deductions:\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(2660, 46, false);
#line 95 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Deductibles));

#line default
#line hidden
            EndContext();
            BeginContext(2706, 197, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            Taxable Income:\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(2904, 48, false);
#line 101 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                       Write(Html.DisplayFor(modelItem => item.TaxableIncome));

#line default
#line hidden
            EndContext();
            BeginContext(2952, 194, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            Federal Tax:\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(3147, 45, false);
#line 107 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FederalTax));

#line default
#line hidden
            EndContext();
            BeginContext(3192, 192, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            State Tax:\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(3385, 43, false);
#line 113 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                       Write(Html.DisplayFor(modelItem => item.StateTax));

#line default
#line hidden
            EndContext();
            BeginContext(3428, 195, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            Medicare Tax:\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(3624, 46, false);
#line 119 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                       Write(Html.DisplayFor(modelItem => item.MedicareTax));

#line default
#line hidden
            EndContext();
            BeginContext(3670, 202, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            Social Security Tax:\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(3873, 52, false);
#line 125 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                       Write(Html.DisplayFor(modelItem => item.SocialSecurityTax));

#line default
#line hidden
            EndContext();
            BeginContext(3925, 203, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            Estimated Net Income:\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(4129, 53, false);
#line 131 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                       Write(Html.DisplayFor(modelItem => item.EstimatedNetIncome));

#line default
#line hidden
            EndContext();
            BeginContext(4182, 197, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt>\r\n                            Monthly Income:\r\n                        </dt>\r\n                        <dd>\r\n                            ");
            EndContext();
            BeginContext(4380, 56, false);
#line 137 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                       Write(Html.DisplayFor(modelItem => item.EstimatedMontlyIncome));

#line default
#line hidden
            EndContext();
            BeginContext(4436, 60, true);
            WriteLiteral("\r\n                        </dd>\r\n                    </dl>\r\n");
            EndContext();
#line 140 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                }

#line default
#line hidden
            BeginContext(4515, 171, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n\r\n                <div id=\"chart5\"></div>\r\n            </div>\r\n\r\n        </div>\r\n        \r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(4703, 303, true);
                WriteLiteral(@"
    <script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
    <script>
        google.charts.load('current', { 'packages': ['corechart'] });
        google.charts.setOnLoadCallback(drawChart);

        
        function drawChart() {

            let bills = ");
                EndContext();
                BeginContext(5007, 41, false);
#line 162 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                   Write(Model.BudgetList[0].TotalMonthlyNetIncome);

#line default
#line hidden
                EndContext();
                BeginContext(5048, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(5052, 38, false);
#line 162 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                                                                Write(Model.BudgetList[0].RemainderAfterBill);

#line default
#line hidden
                EndContext();
                BeginContext(5090, 27, true);
                WriteLiteral(";\r\n            let goals = ");
                EndContext();
                BeginContext(5118, 38, false);
#line 163 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                   Write(Model.BudgetList[0].RemainderAfterBill);

#line default
#line hidden
                EndContext();
                BeginContext(5156, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(5160, 39, false);
#line 163 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                                                             Write(Model.BudgetList[0].RemainderAfterGoals);

#line default
#line hidden
                EndContext();
                BeginContext(5199, 30, true);
                WriteLiteral(";\r\n            let expenses = ");
                EndContext();
                BeginContext(5230, 38, false);
#line 164 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                      Write(Model.BudgetList[0].RemainderAfterBill);

#line default
#line hidden
                EndContext();
                BeginContext(5268, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(5272, 42, false);
#line 164 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                                                                Write(Model.BudgetList[0].RemainderAfterExpenses);

#line default
#line hidden
                EndContext();
                BeginContext(5314, 31, true);
                WriteLiteral(";\r\n            let remainder = ");
                EndContext();
                BeginContext(5346, 42, false);
#line 165 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                       Write(Model.BudgetList[0].RemainderAfterExpenses);

#line default
#line hidden
                EndContext();
                BeginContext(5388, 32, true);
                WriteLiteral(";\r\n            let deductions = ");
                EndContext();
                BeginContext(5421, 28, false);
#line 166 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                        Write(Model.TaxList[0].Deductibles);

#line default
#line hidden
                EndContext();
                BeginContext(5449, 32, true);
                WriteLiteral(";\r\n            let federalTax = ");
                EndContext();
                BeginContext(5482, 27, false);
#line 167 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                        Write(Model.TaxList[0].FederalTax);

#line default
#line hidden
                EndContext();
                BeginContext(5509, 30, true);
                WriteLiteral(";\r\n            let stateTax = ");
                EndContext();
                BeginContext(5540, 25, false);
#line 168 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                      Write(Model.TaxList[0].StateTax);

#line default
#line hidden
                EndContext();
                BeginContext(5565, 33, true);
                WriteLiteral(";\r\n            let medicareTax = ");
                EndContext();
                BeginContext(5599, 28, false);
#line 169 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                         Write(Model.TaxList[0].MedicareTax);

#line default
#line hidden
                EndContext();
                BeginContext(5627, 39, true);
                WriteLiteral(";\r\n            let socialSecurityTax = ");
                EndContext();
                BeginContext(5667, 34, false);
#line 170 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                               Write(Model.TaxList[0].SocialSecurityTax);

#line default
#line hidden
                EndContext();
                BeginContext(5701, 32, true);
                WriteLiteral(";\r\n             let netIncome = ");
                EndContext();
                BeginContext(5734, 35, false);
#line 171 "C:\Users\hlhuynh14\Desktop\devCodeCamp Projects\Capstone\Capstone\Views\Member\Index2.cshtml"
                        Write(Model.TaxList[0].EstimatedNetIncome);

#line default
#line hidden
                EndContext();
                BeginContext(5769, 1314, true);
                WriteLiteral(@";


            
           var data2 = google.visualization.arrayToDataTable([
          ['Expenses', 'Amount'],
          ['Bills', bills],
          ['Goals',      goals],
          ['Expenses',  expenses],
          ['Remainder', remainder],
        ]);

    
           var data = google.visualization.arrayToDataTable([
          ['Taxes', 'Amount'],
          ['Deductions', deductions],
          ['Federal Tax',      federalTax],
          ['State Tax',  stateTax],
          ['Medicare Tax', medicareTax],
          ['Social Security Tax', socialSecurityTax],
          ['Net Income',  netIncome],
        ]);

            var option = {
                title: 'Budget Pie Chart',
                width: 400,
                height: 250
            };

        var option2 = {
                title: 'Taxes Pie Chart',
                width: 400,
                height: 300
            };



      
        option.is3D = true;
            chart = new google.visualization.Pi");
                WriteLiteral(@"eChart(document.getElementById('chart2'));
            chart.draw(data2, option);

        
            option.is3D = true;
            chart = new google.visualization.PieChart(document.getElementById('chart5'));
            chart.draw(data, option2);


        }
    </script>
");
                EndContext();
            }
            );
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
