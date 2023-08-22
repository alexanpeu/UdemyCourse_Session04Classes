
using System;

namespace Secao4
{
    class StaticCalculator
    {

        //lesson about static classes Mode 2

        public double PiMode2 = 3.14;


        public double CircunferenceMode2(double r)
        {
            return 2.0 * PiMode2 * r;
        }

        public double VolumeMode2(double r)
        {
            return 4.0 / 3.0 * PiMode2 * Math.Pow(r, 3.0);
        }

        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// 

        //lesson about static classes Mode 3

        public static double PiMode3 = 3.14;


        public static double CircunferenceMode3(double r)
        {
            return 2.0 * PiMode3 * r;
        }

        public static double VolumeMode3(double r)
        {
            return 4.0 / 3.0 * PiMode3 * Math.Pow(r, 3.0);
        }

    }
}
