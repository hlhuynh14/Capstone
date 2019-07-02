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

        //Taxes
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
        //Budget
        public void DeductExpenses(Member member)
        {
           member.MonthlyRemainder = member.MonthlyNetPay - member.Housing - member.OtherBills - member.Utilities;
            _context.SaveChanges();
        }
        public void DivideRemainder(Member member)
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
