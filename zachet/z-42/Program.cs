using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_42
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляры класса Point с разными типами данных
            Point<int> intPoint = new Point<int>(10, 20);
            Point<uint> uintPoint = new Point<uint>(30, 40);
            Point<double> doublePoint = new Point<double>(3.5, 4.5);

            // Выводим значения внутренних полей
            intPoint.Display();
            uintPoint.Display();
            doublePoint.Display();

            Console.ReadLine();
        }
    }
}
