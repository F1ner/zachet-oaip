using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_47
{
    class Zakaz
    {
        string fam;
        int size;
        string comfort;
        /// <summary>
        /// Фамилия клиента.
        /// </summary>
        public string Fam { 
            get { return fam; }
            set { fam = value; } 
        }

        /// <summary>
        /// Количество мест в номере.
        /// </summary>
        public int Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>
        /// Уровень комфорта заказа.
        /// </summary>
        public string Comfort
        {
            get { return comfort; }
            set { comfort = value; }
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Zakaz() { }

        /// <summary>
        /// Конструктор с 3 параметрами.
        /// </summary>
        /// <param name="fam">Фамилия клиента.</param>
        /// <param name="size">Количество мест в номере.</param>
        /// <param name="comfort">Уровень комфорта.</param>
        public Zakaz(string fam, int size, string comfort)
        {
            Fam = fam;
            Size = size;
            Comfort = comfort;
        }

        /// <summary>
        /// Конструктор с двумя параметрами.
        /// </summary>
        /// <param name="fam">Фамилия клиента.</param>
        /// <param name="size">Количество мест в номере.</param>
        public Zakaz(string fam, int size) : this(fam, size, "стандартный") { }

        /// <summary>
        /// Конструктор с одним параметром.
        /// </summary>
        /// <param name="fam">Фамилия клиента.</param>
        public Zakaz(string fam) : this(fam, 1) { }

        /// <summary>
        /// Конструктор с одним параметром.
        /// </summary>
        /// <param name="size">Количество мест в номере.</param>
        public Zakaz(int size) : this("неизвестно", size) { }

        /// <summary>
        /// Метод для отображения информации о заказе.
        /// </summary>
        public void Show()
        {
            Console.WriteLine($"Заказ: Фамилия - {Fam}, Количество мест - {Size}, Комфортность - {Comfort}");
        }
    }


}
