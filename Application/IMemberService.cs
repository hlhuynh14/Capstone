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
        void DivideRemainder(Budget budget);
        bool CheckPercent();
        void EstimateSavings(Goal goal);
        void EstimatedGoalSavings(Goal goal);
        void CalculateLoan(Goal goal);


    }
}
