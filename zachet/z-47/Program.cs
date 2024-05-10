using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_47
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем список для хранения заказов
            List<Zakaz> zakazy = new List<Zakaz>();

            // Цикл для ввода заказов с клавиатуры
            while (true)
            {
                // Предлагаем пользователю ввести фамилию и проверяем, не ввел ли он "Q" для выхода из программы
                Console.WriteLine("Введите фамилию (Q для выхода):");
                string fam = Console.ReadLine();
                if (fam.ToUpper() == "Q")
                    break; // Если введено "Q", выходим из цикла

                // Предлагаем пользователю ввести количество мест в номере
                Console.WriteLine("Введите количество мест в номере:");
                int size = int.Parse(Console.ReadLine());

                // Предлагаем пользователю ввести уровень комфорта
                Console.WriteLine("Введите комфортность:");
                string comfort = Console.ReadLine();

                // Создаем новый заказ и добавляем его в список заказов
                Zakaz zakaz = new Zakaz(fam, size, comfort);
                zakazy.Add(zakaz);
            }

            // Выводим информацию о всех заказах
            foreach (var zakaz in zakazy)
            {
                zakaz.Show();
            }

            Console.ReadLine(); // Ожидание нажатия клавиши перед завершением программы
        }

    }
}
