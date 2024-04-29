using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Point A = new Point(0, 0, "A");
            Point B = new Point(4, 0, "B");
            Point C = new Point(4, 3, "C");

            Figure triangle = new Figure(A, B, C);
            triangle.PerimeterCalculator();

            Console.ReadKey();
        }
    }
}
