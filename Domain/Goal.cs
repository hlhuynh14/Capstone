using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    public class Goal
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double GoalsSavings { get; set; }
        public double EstimatedHighLoan { get; set; }
        public double EstimatedLowLoan { get; set; }
        public double GoalSavingsPerMonth { get; set; }
        public int MonthGoals { get; set; }
        public double EstimatedHighTotal { get; set; }
        public double EstimatedLowTotal { get; set; }
        public int LoanTermInYears { get; set; }
        public double InterestRate { get; set; }
        //Budget
        [ForeignKey("Budget")]
        public int? BudgetId { get; set; }
        public Budget Budget { get; set; }

    }
}
