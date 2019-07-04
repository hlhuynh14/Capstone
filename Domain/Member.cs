using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    public class Member
    {
        //account
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Budget> BudgetList { get; set; }
        public List<Goal> GoalList { get; set; }
        public List<Tax> TaxList { get; set; }
        //User
        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        //Budget
        [ForeignKey("Budget")]
        public int BudgetId { get; set; }
        public Budget Budget { get; set; }
        // taxes
        [ForeignKey("Tax")]
        public int TaxId { get; set; }
        public Tax Tax { get; set; }



    }
}
