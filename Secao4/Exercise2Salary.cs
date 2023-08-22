using System;

namespace Secao4
{
    class Exercise2Salary
    {
        public string Name;
        public double GrossSalary;
        public double Tax;

        public double NetSalary()
        {
            return GrossSalary - Tax;
        }

        public void RaiseSalary(double percent)
        {
            GrossSalary *= (percent/100)+1;
        }

        public override string ToString()
        {
            return Name + ", $ ";
        }
    }
}
