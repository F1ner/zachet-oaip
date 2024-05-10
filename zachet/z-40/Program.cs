using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_40
{
    class Program
    {
        // Статический метод для вычисления среднего арифметического всех целых чисел от m до n включительно
        static double DoubleAverage(int m, int n)
        {
            int sum = 0;
            int count = 0;
            for (int i = m; i <= n; i++)
            {
                sum += i;
                count++;
            }
            return (double)sum / count;
        }

        // Объявление делегата, соответствующего методу DoubleAverage
        delegate double AverageCalculator(int m, int n);

        static void Main(string[] args)
        {
            // Создание экземпляра делегата и присвоение ему ссылки на метод DoubleAverage
            AverageCalculator averageCalculator = DoubleAverage;

            // Применение делегата 3 раза с разными параметрами
            double result1 = averageCalculator(1, 10);
            double result2 = averageCalculator(20, 30);
            double result3 = averageCalculator(-5, 5);

            Console.WriteLine($"Среднее арифметическое всех целых чисел от 1 до 10: {result1}");
            Console.WriteLine($"Среднее арифметическое всех целых чисел от 20 до 30: {result2}");
            Console.WriteLine($"Среднее арифметическое всех целых чисел от -5 до 5: {result3}");

            Console.ReadLine();
        }
    }
}
