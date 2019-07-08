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
                        CalculateFederalTaxSingle(tax);
                        CalculateStateTaxSingle(tax);
                        CalculateMedicareTax(tax);
                        CalculateSocialSecurityTax(tax);
                        CalculateNetIncome(tax);
                        break;
                    }
                case "Married":
                    {
                        CalculateTaxableIncome(tax, married);
                        CalculateFederalTaxMarried(tax);
                        CalculateStateTaxMarried(tax);
                        CalculateMedicareTax(tax);
                        CalculateSocialSecurityTax(tax);
                        CalculateNetIncome(tax);
                        break;
                    }
                case "Married Filling Separately":
                    {
                        CalculateTaxableIncome(tax, marriedSeparately);
                        CalculateFederalTaxMarriedFillingSeperately(tax);
                        CalculateStateTaxSingle(tax);
                        CalculateMedicareTax(tax);
                        CalculateSocialSecurityTax(tax);
                        CalculateNetIncome(tax);
                        break;
                    }
                case "Head Of Household":
                    {
                        CalculateTaxableIncome(tax, headOfHouseHold);
                        CalculateFederalTaxHeadOfHousehold(tax);
                        CalculateStateTaxSingle(tax);
                        CalculateMedicareTax(tax);
                        CalculateSocialSecurityTax(tax);
                        CalculateNetIncome(tax);
                        break;
                    }
                default:
                    break;
            }
        }
        public void CalculateTaxableIncome(Tax tax, double deductions)
        {
                tax.TaxableIncome = tax.GrossIncome - deductions;
            tax.Deductibles = deductions;
                _context.SaveChanges();
        }

        public void CalculateFederalTaxSingle( Tax tax)
        {
            double bracket1 = 0;
            double bracket1Percent = .10;
            double bracket2 = 9525;
            double bracket2Percent = .12;
            double bracket3 = 38700;
            double bracket3Percent = .22;
            double bracket4 = 82500;
            double bracket4Percent = .24;
            double bracket5 = 157500;
            double bracket5Percent = .32;
            double bracket6 = 200000;
            double bracket6Percent = .35;
            double bracket7 = 500000;
            double bracket7Percent = .37;


            double federalTax = 0;
            if( tax.TaxableIncome > bracket7)
            {
                federalTax += (tax.TaxableIncome - bracket7) * bracket7Percent;
                federalTax += (bracket7 - bracket6) * bracket6Percent;
                federalTax += (bracket6 - bracket5) * bracket5Percent;
                federalTax += (bracket5 - bracket4) * bracket4Percent;
                federalTax += (bracket4 - bracket3) * bracket3Percent;
                federalTax += (bracket3 - bracket2) * bracket2Percent;
                federalTax += (bracket2 - bracket1) * bracket1Percent;
            }
            else if (tax.TaxableIncome > bracket6)
            {
                federalTax += (tax.TaxableIncome - bracket6) * bracket6Percent;
                federalTax += (bracket6 - bracket5) * bracket5Percent;
                federalTax += (bracket5 - bracket4) * bracket4Percent;
                federalTax += (bracket4 - bracket3) * bracket3Percent;
                federalTax += (bracket3 - bracket2) * bracket2Percent;
                federalTax += (bracket2 - bracket1) * bracket1Percent;
            }
            else if (tax.TaxableIncome > bracket5)
            {
                federalTax += (tax.TaxableIncome - bracket5) * bracket5Percent;
                federalTax += (bracket5 - bracket4) * bracket4Percent;
                federalTax += (bracket4 - bracket3) * bracket3Percent;
                federalTax += (bracket3 - bracket2) * bracket2Percent;
                federalTax += (bracket2 - bracket1) * bracket1Percent;
            }
            else if (tax.TaxableIncome > bracket4)
            {
                federalTax += (tax.TaxableIncome - bracket4) * bracket4Percent;
                federalTax += (bracket4 - bracket3) * bracket3Percent;
                federalTax += (bracket3 - bracket2) * bracket2Percent;
                federalTax += (bracket2 - bracket1) * bracket1Percent;
            }
            else if (tax.TaxableIncome > bracket3)
            {
                federalTax += (tax.TaxableIncome - bracket3) * bracket3Percent;
                federalTax += (bracket3 - bracket2) * bracket2Percent;
                federalTax += (bracket2 - bracket1) * bracket1Percent;
            }
            else if (tax.TaxableIncome > bracket2)
            {
                federalTax += (tax.TaxableIncome - bracket2) * bracket2Percent;
                federalTax += (bracket2 - bracket1) * bracket1Percent;
            }
            else  
            {
                federalTax += (tax.TaxableIncome - bracket1) * bracket1Percent;
            }
  
            tax.FederalTax = federalTax;
            _context.SaveChanges();
        }
        public void CalculateFederalTaxMarried(Tax tax)
        {
            double bracket1 = 1;
            double bracket1Percent = .10;
            double bracket2 = 19051;
            double bracket2Percent = .12;
            double bracket3 = 77401;
            double bracket3Percent = .22;
            double bracket4 = 165001;
            double bracket4Percent = .24;
            double bracket5 = 315001;
            double bracket5Percent = .32;
            double bracket6 = 400001;
            double bracket6Percent = .35;
            double bracket7 = 600001;
            double bracket7Percent = .37;


            double federalTax = 0;
            if (tax.TaxableIncome > bracket7)
            {
                federalTax += (tax.TaxableIncome - bracket7) * bracket7Percent;
                federalTax += (bracket7 - bracket6) * bracket6Percent;
                federalTax += (bracket6 - bracket5) * bracket5Percent;
                federalTax += (bracket5 - bracket4) * bracket4Percent;
                federalTax += (bracket4 - bracket3) * bracket3Percent;
                federalTax += (bracket3 - bracket2) * bracket2Percent;
                federalTax += (bracket2 - bracket1) * bracket1Percent;
            }
            else if (tax.TaxableIncome > bracket6)
            {
                federalTax += (tax.TaxableIncome - bracket6) * bracket6Percent;
                federalTax += (bracket6 - bracket5) * bracket5Percent;
                federalTax += (bracket5 - bracket4) * bracket4Percent;
                federalTax += (bracket4 - bracket3) * bracket3Percent;
                federalTax += (bracket3 - bracket2) * bracket2Percent;
                federalTax += (bracket2 - bracket1) * bracket1Percent;
            }
            else if (tax.TaxableIncome > bracket5)
            {
                federalTax += (tax.TaxableIncome - bracket5) * bracket5Percent;
                federalTax += (bracket5 - bracket4) * bracket4Percent;
                federalTax += (bracket4 - bracket3) * bracket3Percent;
                federalTax += (bracket3 - bracket2) * bracket2Percent;
                federalTax += (bracket2 - bracket1) * bracket1Percent;
            }
            else if (tax.TaxableIncome > bracket4)
            {
                federalTax += (tax.TaxableIncome - bracket4) * bracket4Percent;
                federalTax += (bracket4 - bracket3) * bracket3Percent;
                federalTax += (bracket3 - bracket2) * bracket2Percent;
                federalTax += (bracket2 - bracket1) * bracket1Percent;
            }
            else if (tax.TaxableIncome > bracket3)
            {
                federalTax += (tax.TaxableIncome - bracket3) * bracket3Percent;
                federalTax += (bracket3 - bracket2) * bracket2Percent;
                federalTax += (bracket2 - bracket1) * bracket1Percent;
            }
            else if (tax.TaxableIncome > bracket2)
            {
                federalTax += (tax.TaxableIncome - bracket2) * bracket2Percent;
                federalTax += (bracket2 - bracket1) * bracket1Percent;
            }
            else
            {
                federalTax += (tax.TaxableIncome - bracket1) * bracket1Percent;
            }

            tax.FederalTax = federalTax;
            _context.SaveChanges();
        }
        public void CalculateFederalTaxHeadOfHousehold(Tax tax)
        {
            double bracket1 = 1;
            double bracket1Percent = .10;
            double bracket2 = 13601;
            double bracket2Percent = .12;
            double bracket3 = 51801;
            double bracket3Percent = .22;
            double bracket4 = 82501;
            double bracket4Percent = .24;
            double bracket5 = 157501;
            double bracket5Percent = .32;
            double bracket6 = 200001;
            double bracket6Percent = .35;
            double bracket7 = 500001;
            double bracket7Percent = .37;


            double federalTax = 0;
            if (tax.TaxableIncome > bracket7)
            {
                federalTax += (tax.TaxableIncome - bracket7) * bracket7Percent;
                federalTax += (bracket7 - bracket6) * bracket6Percent;
                federalTax += (bracket6 - bracket5) * bracket5Percent;
                federalTax += (bracket5 - bracket4) * bracket4Percent;
                federalTax += (bracket4 - bracket3) * bracket3Percent;
                federalTax += (bracket3 - bracket2) * bracket2Percent;
                federalTax += (bracket2 - bracket1) * bracket1Percent;
            }
            else if (tax.TaxableIncome > bracket6)
            {
                federalTax += (tax.TaxableIncome - bracket6) * bracket6Percent;
                federalTax += (bracket6 - bracket5) * bracket5Percent;
                federalTax += (bracket5 - bracket4) * bracket4Percent;
                federalTax += (bracket4 - bracket3) * bracket3Percent;
                federalTax += (bracket3 - bracket2) * bracket2Percent;
                federalTax += (bracket2 - bracket1) * bracket1Percent;
            }
            else if (tax.TaxableIncome > bracket5)
            {
                federalTax += (tax.TaxableIncome - bracket5) * bracket5Percent;
                federalTax += (bracket5 - bracket4) * bracket4Percent;
                federalTax += (bracket4 - bracket3) * bracket3Percent;
                federalTax += (bracket3 - bracket2) * bracket2Percent;
                federalTax += (bracket2 - bracket1) * bracket1Percent;
            }
            else if (tax.TaxableIncome > bracket4)
            {
                federalTax += (tax.TaxableIncome - bracket4) * bracket4Percent;
                federalTax += (bracket4 - bracket3) * bracket3Percent;
                federalTax += (bracket3 - bracket2) * bracket2Percent;
                federalTax += (bracket2 - bracket1) * bracket1Percent;
            }
            else if (tax.TaxableIncome > bracket3)
            {
                federalTax += (tax.TaxableIncome - bracket3) * bracket3Percent;
                federalTax += (bracket3 - bracket2) * bracket2Percent;
                federalTax += (bracket2 - bracket1) * bracket1Percent;
            }
            else if (tax.TaxableIncome > bracket2)
            {
                federalTax += (tax.TaxableIncome - bracket2) * bracket2Percent;
                federalTax += (bracket2 - bracket1) * bracket1Percent;
            }
            else
            {
                federalTax += (tax.TaxableIncome - bracket1) * bracket1Percent;
            }

            tax.FederalTax = federalTax;
            _context.SaveChanges();
        }
        public void CalculateFederalTaxMarriedFillingSeperately(Tax tax)
        {
            double bracket1 = 1;
            double bracket1Percent = .10;
            double bracket2 = 9526;
            double bracket2Percent = .12;
            double bracket3 = 38701;
            double bracket3Percent = .22;
            double bracket4 = 82501;
            double bracket4Percent = .24;
            double bracket5 = 157501;
            double bracket5Percent = .32;
            double bracket6 = 200001;
            double bracket6Percent = .35;
            double bracket7 = 300001;
            double bracket7Percent = .37;


            double federalTax = 0;
            if (tax.TaxableIncome > bracket7)
            {
                federalTax += (tax.TaxableIncome - bracket7) * bracket7Percent;
                federalTax += (bracket7 - bracket6) * bracket6Percent;
                federalTax += (bracket6 - bracket5) * bracket5Percent;
                federalTax += (bracket5 - bracket4) * bracket4Percent;
                federalTax += (bracket4 - bracket3) * bracket3Percent;
                federalTax += (bracket3 - bracket2) * bracket2Percent;
                federalTax += (bracket2 - bracket1) * bracket1Percent;
            }
            else if (tax.TaxableIncome > bracket6)
            {
                federalTax += (tax.TaxableIncome - bracket6) * bracket6Percent;
                federalTax += (bracket6 - bracket5) * bracket5Percent;
                federalTax += (bracket5 - bracket4) * bracket4Percent;
                federalTax += (bracket4 - bracket3) * bracket3Percent;
                federalTax += (bracket3 - bracket2) * bracket2Percent;
                federalTax += (bracket2 - bracket1) * bracket1Percent;
            }
            else if (tax.TaxableIncome > bracket5)
            {
                federalTax += (tax.TaxableIncome - bracket5) * bracket5Percent;
                federalTax += (bracket5 - bracket4) * bracket4Percent;
                federalTax += (bracket4 - bracket3) * bracket3Percent;
                federalTax += (bracket3 - bracket2) * bracket2Percent;
                federalTax += (bracket2 - bracket1) * bracket1Percent;
            }
            else if (tax.TaxableIncome > bracket4)
            {
                federalTax += (tax.TaxableIncome - bracket4) * bracket4Percent;
                federalTax += (bracket4 - bracket3) * bracket3Percent;
                federalTax += (bracket3 - bracket2) * bracket2Percent;
                federalTax += (bracket2 - bracket1) * bracket1Percent;
            }
            else if (tax.TaxableIncome > bracket3)
            {
                federalTax += (tax.TaxableIncome - bracket3) * bracket3Percent;
                federalTax += (bracket3 - bracket2) * bracket2Percent;
                federalTax += (bracket2 - bracket1) * bracket1Percent;
            }
            else if (tax.TaxableIncome > bracket2)
            {
                federalTax += (tax.TaxableIncome - bracket2) * bracket2Percent;
                federalTax += (bracket2 - bracket1) * bracket1Percent;
            }
            else
            {
                federalTax += (tax.TaxableIncome - bracket1) * bracket1Percent;
            }

            tax.FederalTax = federalTax;
            _context.SaveChanges();
        }
        public void CalculateStateTaxSingle(Tax tax)
        {
            double bracket1 = 1;
            double bracket1Percent = .04;
            double bracket2 = 11091;
            double bracket2Percent = .0584;
            double bracket3 = 22191;
            double bracket3Percent = .0627;
            double bracket4 = 244271;
            double bracket4Percent = .0765;


            double stateTax = 0;
            if (tax.TaxableIncome > bracket4)
            {
                stateTax += (tax.TaxableIncome - bracket4) * bracket4Percent;
                stateTax += (bracket4 - bracket3) * bracket3Percent;
                stateTax += (bracket3 - bracket2) * bracket2Percent;
                stateTax += (bracket2 - bracket1) * bracket1Percent;
            }
            else if (tax.TaxableIncome > bracket3)
            {
                stateTax += (tax.TaxableIncome - bracket3) * bracket3Percent;
                stateTax += (bracket3 - bracket2) * bracket2Percent;
                stateTax += (bracket2 - bracket1) * bracket1Percent;
            }
            else if (tax.TaxableIncome > bracket2)
            {
                stateTax += (tax.TaxableIncome - bracket2) * bracket2Percent;
                stateTax += (bracket2 - bracket1) * bracket1Percent;
            }
            else
            {
                stateTax += (tax.TaxableIncome - bracket1) * bracket1Percent;
            }

            tax.StateTax = stateTax;
            _context.SaveChanges();
        }
        public void CalculateStateTaxMarried(Tax tax)
        {
            double bracket1 = 1;
            double bracket1Percent = .04;
            double bracket2 = 14791;
            double bracket2Percent = .0584;
            double bracket3 = 29581;
            double bracket3Percent = .0627;
            double bracket4 = 325701;
            double bracket4Percent = .0765;


            double stateTax = 0;
            if (tax.TaxableIncome > bracket4)
            {
                stateTax += (tax.TaxableIncome - bracket4) * bracket4Percent;
                stateTax += (bracket4 - bracket3) * bracket3Percent;
                stateTax += (bracket3 - bracket2) * bracket2Percent;
                stateTax += (bracket2 - bracket1) * bracket1Percent;
            }
            else if (tax.TaxableIncome > bracket3)
            {
                stateTax += (tax.TaxableIncome - bracket3) * bracket3Percent;
                stateTax += (bracket3 - bracket2) * bracket2Percent;
                stateTax += (bracket2 - bracket1) * bracket1Percent;
            }
            else if (tax.TaxableIncome > bracket2)
            {
                stateTax += (tax.TaxableIncome - bracket2) * bracket2Percent;
                stateTax += (bracket2 - bracket1) * bracket1Percent;
            }
            else
            {
                stateTax += (tax.TaxableIncome - bracket1) * bracket1Percent;
            }

            tax.StateTax = stateTax;
            _context.SaveChanges();
        }
        public void CalculateMedicareTax(Tax tax)
        {
            double medicareTax = 0;
            medicareTax += (tax.TaxableIncome * .0145);
            if (tax.TaxableIncome > 200000)
            {
                medicareTax += (tax.TaxableIncome * .009);
            }
            tax.MedicareTax = medicareTax;
            _context.SaveChanges();
        }
        public void CalculateSocialSecurityTax(Tax tax)
        {
            double socialSecurityTax = 0;
            if (tax.TaxableIncome > 132900)
            {
                socialSecurityTax += (tax.TaxableIncome * .062);
            }
            tax.SocialSecurityTax = socialSecurityTax;
            _context.SaveChanges();
        }
        public void CalculateNetIncome(Tax tax)
        {
            double netIncome = 0;
            netIncome = tax.TaxableIncome - tax.FederalTax - tax.StateTax - tax.MedicareTax - tax.SocialSecurityTax;
            tax.EstimatedNetIncome = netIncome;
            tax.EstimatedMontlyIncome = (netIncome / 12);
            _context.SaveChanges();
        }
        //Budget
        public void GetNetIncome(Budget budget)
        {
            var IncomeList = _context.Incomes.ToList();
            double income = 0;
            foreach(var item in IncomeList)
            {
                income += item.Amount;
            }
            budget.TotalMonthlyNetIncome = income;
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
                goalTotal += item.GoalSavingsPerMonth;
            }
            budget.RemainderAfterGoals = budget.RemainderAfterBill - goalTotal;
            _context.SaveChanges();
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
        //Goals
        public void EstimatedGoalSavings(Goal goal)
        {
            goal.EstimatedHighTotal = (goal.GoalSavingsPerMonth * goal.MonthGoals) + goal.GoalsSavings + goal.EstimatedHighLoan;
            goal.EstimatedLowTotal = (goal.GoalSavingsPerMonth * goal.MonthGoals) + goal.GoalsSavings + goal.EstimatedLowLoan;
            _context.SaveChanges();
        }
        public void CalculateLoan(Goal goal)
        {
            double highGoal = goal.GoalSavingsPerMonth * (12 * goal.LoanTermInYears);
            goal.EstimatedHighLoan = highGoal - (highGoal * (goal.InterestRate *.01));
            double lowGoal = goal.GoalSavingsPerMonth * (6 * goal.LoanTermInYears);
            goal.EstimatedLowLoan = lowGoal - (lowGoal * (goal.InterestRate * .01));
            _context.SaveChanges();
        }
    }
}
