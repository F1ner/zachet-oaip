using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_44
{
    class Program
    {
       
        
            // Статический метод для вычисления суммы всех целых чисел от m до n включительно
            static int IntSum(int m, int n)
            {
                int sum = 0;
                for (int i = m; i <= n; i++)
                {
                    sum += i;
                }
                return sum;
            }

            // Объявление делегата, соответствующего методу IntSum
            delegate int SumCalculator(int m, int n);

            static void Main(string[] args)
            {
                // Создание экземпляра делегата и присвоение ему ссылки на метод IntSum
                SumCalculator sumCalculator = IntSum;

                // Применение делегата 3 раза с разными параметрами
                int result1 = sumCalculator(1, 10);
                int result2 = sumCalculator(20, 30);
                int result3 = sumCalculator(-5, 5);

                Console.WriteLine($"Сумма всех целых чисел от 1 до 10: {result1}");
                Console.WriteLine($"Сумма всех целых чисел от 20 до 30: {result2}");
                Console.WriteLine($"Сумма всех целых чисел от -5 до 5: {result3}");

                Console.ReadLine();
            }
        }
    }

