using Domain;
using Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Application
{
    public class MemberLogic
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        

        public MemberLogic(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        //Taxes
        public void GetFillingStatus(IActionResult member)
        {
            string fillingStatus = member.FillingStatus;
            double single = 12000;
            double married = 24000;
            double marriedSeparately = 12200;
            double headOfHouseHold = 18000;

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
        public void CalculateTaxableIncome(IActionResult member, double deductions)
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
        //Budget
        public void DeductExpenses(IActionResult member)
        {
           member.MonthlyRemainder = member.MonthlyNetPay - member.Housing - member.OtherBills - member.Utilities;
            _context.SaveChanges();
        }
        public void DivideRemainder(IActionResult member)
        {
            member.AmountForEntertainment = (member.Entertainment * .01) * member.MonthlyRemainder;
            member.AmountForFood = (member.Food * .01) * member.MonthlyRemainder;
            member.AmountForOthers = (member.Others * .01) * member.MonthlyRemainder;
            member.AmountForSavings = (member.Savings * .01) * member.MonthlyRemainder;
            member.AmountForLoans = (member.Loans * .01) * member.MonthlyRemainder;
            member.PercentChecker = (member.Entertainment + member.Food + member.Others + member.Savings + member.Loans);
            _context.SaveChanges();
        }
        //Goals
        public void EstimateSavings(Goal goal)
        {
            goal.SavingsEstimated = goal.CurrentSavings + (goal.SavingsPerMonth * goal.Months);
            _context.SaveChanges();
        }
        public void EstimatedGoalSavings(Goal goal)
        {
            goal.EstimatedHighTotal = (goal.GoalSavingsPerMonth * goal.MonthGoals) + goal.GoalsSavings + goal.EstimatedHighLoan;
            goal.EstimatedLowTotal = (goal.GoalSavingsPerMonth * goal.MonthGoals) + goal.GoalsSavings + goal.EstimatedLowLoan;
            _context.SaveChanges();
        }
        public void CalculateLoan(Goal goal)
        {
            double highGoal = goal.SavingsPerMonth * (12 * goal.LoanTermInYears);
            goal.EstimatedHighLoan = highGoal - (highGoal * (goal.InterestRate *.01));
            double lowGoal = goal.SavingsPerMonth * (6 * goal.LoanTermInYears);
            goal.EstimatedLowLoan = lowGoal - (lowGoal * (goal.InterestRate * .01));
            _context.SaveChanges();
        }
    }
}
