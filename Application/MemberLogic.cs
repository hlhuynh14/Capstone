using Domain;
using Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using System;

namespace Application
{
    public class MemberLogic
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public MemberLogic(ApplicationDbContext context)
        {
            _context = context;
        }
        public void GetFillingStatus(Member member)
        {
            string fillingStatus = member.FillingStatus;
            double single = 12200;
            double married = 24400;
            double marriedSeparately = 12200;
            double headOfHouseHold = 18350;

            switch (fillingStatus)
            {
                case "Single":
                    {
                        CalculateTaxableIncome(member, single);
                        break;
                    }
                case "Married":
                    {
                        CalculateTaxableIncome(member, married);
                        break;
                    }
                case "Married Filling Separately":
                    {
                        CalculateTaxableIncome(member, marriedSeparately);
                        break;
                    }
                case "Head Of Household":
                    {
                        CalculateTaxableIncome(member, headOfHouseHold);
                        break;
                    }
                default:
                    break;
            }
        }
        public void CalculateTaxableIncome(Member member, double deductions)
        {
            
            if (member.FillingStatus != "Married")
            {
                member.TaxableIncome = member.Income - deductions;
                _context.SaveChanges();
            }
            else
            {
                member.TaxableIncome = member.Income + member.OtherIncome - deductions;
                _context.SaveChanges();
            }
        }
        public void DeductExpenses(Member member)
        {
           member.MonthlyRemainder = member.MonthlyNetPay - member.Housing - member.OtherBills - member.Utilities;
            _context.SaveChanges();
        }
        public void DivideRemainder(Member member)
        {
        
        }
    }
}
