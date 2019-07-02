using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
    class Goal
    {
        [Key]
        public int ID { get; set; }
        //savings
        public bool Savings { get; set; }
        public double SavingsPerMonth { get; set; }
        public string Name { get; set; }
        public int Months { get; set; }
        public DateTime DateChecker { get; set; }
        public double SavingsEstimated { get; set; }
        //Target
        public bool SavingsTowardGoal { get; set; }
        public double EstimatedHigh { get; set; }
        public double EstimatedLow { get; set; }
        public double GoalSavingsPerMonth { get; set; }
        public int MonthGoals { get; set; }




    }
}
