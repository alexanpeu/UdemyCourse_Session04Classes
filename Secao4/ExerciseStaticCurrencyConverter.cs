using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao4
{
    class ExerciseStaticCurrencyConverter
    {
        public static double IOF = 0.06;


        public static double ConverterCurrency(double price, double amount)
        {
            double totalReal = price * amount;
            double totalIOF = totalReal * IOF;
            return totalReal + totalIOF;
        }


    }
}
