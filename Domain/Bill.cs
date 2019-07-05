using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    public class Bill
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }
        [ForeignKey("Budget")]
        public int? BudgetId { get; set; }
        public Budget Budget { get; set; }
    }
}
