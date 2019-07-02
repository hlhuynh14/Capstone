﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
    public class Goal
    {
        [Key]
        public int ID { get; set; }
        //savings
        public bool Savings { get; set; }
        public double CurrentSavings { get; set; }
        public double SavingsPerMonth { get; set; }
        public string Name { get; set; }
        public int Months { get; set; }
        public DateTime DateChecker { get; set; }
        public double SavingsEstimated { get; set; }
        public double TargetSavings { get; set; }
        //Target
        public bool SavingsTowardGoal { get; set; }
        public double EstimatedHighLoan { get; set; }
        public double EstimatedLowLoan { get; set; }
        public double GoalSavingsPerMonth { get; set; }
        public int MonthGoals { get; set; }
        public string GoalsName { get; set; }
        public  DateTime GoalsDateChecker { get; set; }
        public double EstimatedHighTotal { get; set; }
        public double EstimatedLowTotal { get; set; }





}
}