using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    public class Budget
    {   [Key]
        public int Id { get; set; }
        public double TotalMonthlyNetIncome { get; set; }
        public double RemainderAfterBill { get; set; }
        public double percent { get; set; }
        public double RemainderAfterExpenses { get; set; }
        //Bill
        [ForeignKey("Bill")]
        public int BillId { get; set; }
        public Bill Bill { get; set; }
        //Goal
        [ForeignKey("Goal")]
        public int GoalId { get; set; }
        public Goal Goal { get; set; }
        //Expense 
        [ForeignKey("Expense")]
        public string ExpenseId { get; set; }
        public Expense Expense { get; set; }
    }
}
