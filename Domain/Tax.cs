using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Tax
    {
        public int Id { get; set; }
        public string FillingStatus { get; set; }
        public double GrossIncome { get; set; }
        public double TaxableIncome { get; set; }
        public double EstimatedNetIncome { get; set; }
    }
}
