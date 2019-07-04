using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
    public class FederalTax
    {
        [Key]
        public int Id { get; set; }
        public string FillingStatus { get; set; }
        public double Bracket { get; set; }
        public double MarginalRate { get; set; }
        public double Amount { get; set; }


    }
}
