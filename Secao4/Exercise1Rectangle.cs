using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secao4
{
    class Exercise1Rectangle
    {
        public double Width;
        public double Height;

        public double CalcArea()
        {
            return Width * Height;
        }

        public double CalcPerimeter()
        {
            return 2 * (Width + Height);
        }

        public double CalDiagonal()
        {
            return Math.Sqrt(Width * Width + Height * Height);
        }

    }
}
