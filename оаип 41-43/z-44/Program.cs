using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_44
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляры класса Segment с разными типами данных
            Segment<int> intSegment = new Segment<int>(0, 0, 3, 4);
            Segment<long> longSegment = new Segment<long>(-1, -1, 5, 7);
            Segment<double> doubleSegment = new Segment<double>(1.5, 2.5, 4.5, 6.5);

            // Выводим информацию об отрезках
            intSegment.DisplayInfo();
            Console.WriteLine("Length of segment: " + intSegment.CalculateLength());

            longSegment.DisplayInfo();
            Console.WriteLine("Length of segment: " + longSegment.CalculateLength());

            doubleSegment.DisplayInfo();
            Console.WriteLine("Length of segment: " + doubleSegment.CalculateLength());

            Console.ReadLine();
        }
    }
}
