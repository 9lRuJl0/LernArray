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
     
        private readonly decimal _salaryGross;

        private decimal _totalResult;
        public Calculator(decimal salaryGross)
        {
            _salaryGross = salaryGross;
        }

        public decimal Calculate()
        {
            
            var koeff = FloatingCoefficient(_totalResult + _salaryGross);
            _totalResult += _salaryGross * (1 - koeff);
            return _totalResult;

        }

        private decimal FloatingCoefficient(decimal currentSalaryGross)
        {
            if (currentSalaryGross < 2400000m)
                return 0.13m;

            else if (currentSalaryGross >= 2400000m && currentSalaryGross < 5000000m)
                return 0.15m;

            else if (currentSalaryGross >= 5000000m && currentSalaryGross < 20000000m)
                return 0.18m;

            else if (currentSalaryGross >= 20000000m && currentSalaryGross < 50000000m)
                return 0.2m;

            else
                return 0.22m;

        }



    }
}
