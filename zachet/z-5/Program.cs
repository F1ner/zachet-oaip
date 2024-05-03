using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Инициализация курсов валют
            double usdRate = 2.5;
            double eurRate = 3.0;
            double rubRate = 0.03;

            Converter converter = new Converter(usdRate, eurRate, rubRate);

            // Примеры конвертации
            double amountInBYN = 100.0;
            Console.WriteLine(amountInBYN + " BYN = " + converter.BYNtoUSD(amountInBYN) + " USD");
            Console.WriteLine(amountInBYN + " BYN = " + converter.BYNtoEUR(amountInBYN) + " EUR");
            Console.WriteLine(amountInBYN + " BYN = " + converter.BYNtoRUB(amountInBYN) + " RUB");

            double amountInUSD = 50.0;
            Console.WriteLine(amountInUSD + " USD = " + converter.USDtoBYN(amountInUSD) + " BYN");

            double amountInEUR = 60.0;
            Console.WriteLine(amountInEUR + " EUR = " + converter.EURtoBYN(amountInEUR) + " BYN");

            double amountInRUB = 150.0;
            Console.WriteLine(amountInRUB + " RUB = " + converter.RUBtoBYN(amountInRUB) + " BYN");

            Console.ReadLine();
        }
    }
}
