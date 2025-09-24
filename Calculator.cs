using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LernArray
{
    public class Calculator
    {
        private readonly decimal koeff;

        private decimal salaryResult;

        public decimal Calculate(decimal salaryGross)
        {
            decimal koeff = floatingCoefficient(salaryGross);
            salaryResult = salaryGross * (1 - koeff);
            return salaryResult;
        }


        public decimal AnnualСalculation(decimal annualSalaruGross)
        {
            decimal annualSalaryResult;

            annualSalaryResult = salaryResult * 12;

            return annualSalaryResult;
        }

        public decimal floatingCoefficient(decimal annualSalaryGross)
        {
            if (annualSalaryGross < 2400000m)
                return 0.13m;

            else if (annualSalaryGross >= 2400000m && annualSalaryGross < 5000000m)
                return 0.15m;

            else if (annualSalaryGross >= 5000000m && annualSalaryGross < 20000000m)
                return 0.18m;

            else if (annualSalaryGross >= 20000000m && annualSalaryGross < 50000000m)
                return 0.2m;

            else
                return 0.22m;

        }

        public Calculator(decimal koeff)
        {
            this.koeff = koeff;
        }

    }
}
