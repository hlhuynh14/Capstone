using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public interface IMemberService
    {

        void GetFillingStatus(Tax tax);
        void CalculateTaxableIncome(Tax tax, double deductions);
        void GetNetIncome(Budget budget);
        void  DeductBills(Budget budget);
        void DeductGoals(Budget budget);
        void DivideRemainder(Budget budget);
        void CalculateFederalTaxSingle(Tax tax);
        void CalculateFederalTaxMarried(Tax tax);
        void CalculateFederalTaxHeadOfHousehold(Tax tax);
        void CalculateFederalTaxMarriedFillingSeperately(Tax tax);
        void CalculateStateTaxSingle(Tax tax);
        void CalculateStateTaxMarried(Tax tax);
        void EstimatedGoalSavings(Goal goal);
        void CalculateLoan(Goal goal);
        void CalculateMedicareTax(Tax tax);
        void CalculateSocialSecurityTax(Tax tax);
        void CalculateNetIncome(Tax tax);


    }
}
