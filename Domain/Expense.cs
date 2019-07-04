using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
   public class Expense
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Percent { get; set; }
        public double Amount { get; set; }


    }
}
