using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    public class Tax
    {
        public int Id { get; set; }
        public string FillingStatus { get; set; }
        public double GrossIncome { get; set; }
        public double TaxableIncome { get; set; }
        public string StateAbbrevation { get; set; }
        public double EstimatedNetIncome { get; set; }
        public double MedicareTax { get; set; }
        public double SocialSecurityTax { get; set; }

        [ForeignKey("Member")]
        public int? MemberId { get; set; }
        public Member member{ get; set; }

    }
}
