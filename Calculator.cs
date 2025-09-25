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
        private readonly decimal _koeff;

        private decimal _salaryResult;

        public Calculator(decimal koeff)
        {
            _koeff = koeff;
        }

        public decimal Calculate(decimal salaryGross)
        {
            decimal koeff = floatingCoefficient(salaryGross);
            _salaryResult = salaryGross * (1 - koeff);
            return _salaryResult;
        }


        public decimal AnnualСalculation(decimal annualSalaruGross)
        {
            decimal annualSalaryResult;

            annualSalaryResult = _salaryResult * 12;

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



    }
}
