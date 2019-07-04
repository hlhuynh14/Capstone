using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    public class IActionResult 
    {
        //account
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StateAbbreviation { get; set; }
        public string FillingStatus { get; set; }
        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        // budget
        public double MonthlyNetPay { get; set; }
        public double OtherIncome { get; set; }
        public double Housing { get; set; }
        public double Utilities { get; set; }
        public double OtherBills { get; set; }
        public double Loans { get; set; }
        public double  Food { get; set; }
        public double Entertainment { get; set; }
        public double Others { get; set; }
        public double Savings { get; set; }
        public double AmountForFood { get; set; }
        public double AmountForSavings { get; set; }
        public double AmountForEntertainment { get; set; }
        public double AmountForOthers { get; set; }
        public double AmountForLoans { get; set; }
        public double MonthlyRemainder { get; set; }
        public double PercentChecker { get; set; }
        // taxes
        public double Income { get; set; }
        public double EstimatedNetIncome { get; set; }
        public double TaxableIncome { get; set; }

    }
}
