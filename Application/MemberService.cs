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
    public class MemberService : IMemberService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        

        public MemberService(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        //Taxes
        public void GetFillingStatus(Tax tax)
        {
            
            string fillingStatus = tax.FillingStatus;
            double single = 12000;
            double married = 24000;
            double marriedSeparately = 12000;
            double headOfHouseHold = 18000;

            switch (fillingStatus)
            {
                case "Single":
                    {
                        CalculateTaxableIncome(tax, single);
                        break;
                    }
                case "Married":
                    {
                        CalculateTaxableIncome(tax, married);
                        break;
                    }
                case "Married Filling Separately":
                    {
                        CalculateTaxableIncome(tax, marriedSeparately);
                        break;
                    }
                case "Head Of Household":
                    {
                        CalculateTaxableIncome(tax, headOfHouseHold);
                        break;
                    }
                default:
                    break;
            }
        }
        public void CalculateTaxableIncome(Tax tax, double deductions)
        {
                tax.TaxableIncome = tax.GrossIncome - deductions;
                _context.SaveChanges();
        }
        //Budget
        public void GetNetIncome(Budget budget)
        {
            var IncomeList = _context.Incomes.ToList();
            foreach(var item in IncomeList)
            {
                budget.TotalMonthlyNetIncome += item.Amount;
            }
        }
        public void DeductBills(Budget budget)
        {
            var billList = _context.Bills.ToList();
            double billTotal = 0;
            foreach ( var item in billList)
            {
                billTotal += item.Amount;
            }
            
            budget.RemainderAfterBill = budget.TotalMonthlyNetIncome - billTotal;
            _context.SaveChanges();
        }
        public void DeductGoals(Budget budget)
        {
            var goalList = _context.Goals.ToList();
            double goalTotal = 0;
            foreach(var item in goalList)
            {
                if (item.Savings == true)
                {
                    goalTotal += item.SavingsPerMonth;
                }
                else
                {
                    goalTotal += item.GoalSavingsPerMonth;
                }
                budget.RemainderAfterGoals = budget.RemainderAfterBill - goalTotal;
                _context.SaveChanges();
            }
        }
        public void DivideRemainder(Budget budget)
        {
            budget.Percent = 1;
            var ExpenseList = _context.Expenses.ToList();
            foreach (var item in ExpenseList)
            {
                item.Amount = (item.Percent * .01) * budget.RemainderAfterBill;
               budget.Percent =  budget.Percent - (item.Percent * .01);
            }
            budget.RemainderAfterExpenses = budget.Percent * budget.RemainderAfterBill;
            _context.SaveChanges();
        }
        public bool CheckPercent()
        {
            var ExpenseList = _context.Expenses.ToList();
            double CurrentPercent = 0;
            foreach (var item in ExpenseList)
            {
                CurrentPercent += (item.Percent * .01);
            }

            if (CurrentPercent > 1)
            {
                return true;
            }
            else
            {
                return false;
            }
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
