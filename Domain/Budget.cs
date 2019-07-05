﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    public class Budget
    {   [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        //Member
        [ForeignKey("Member")]
        public int? MemberId { get; set; }
        public Member member { get; set; }
        //Income
        public List<Income> IncomeList { get; set; }
        public double TotalMonthlyNetIncome { get; set; }
        //Bill
        public List<Bill> BillList { get; set; }
        public double RemainderAfterBill { get; set; }
        //Goal
        public List<Goal> GoalList { get; set; }
        public double RemainderAfterGoals { get; set; }
        //Expense 
        public List<Expense> ExpenseList { get; set; }
        public double Percent { get; set; }
        public double RemainderAfterExpenses { get; set; }
    }
}
