using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_2
{
    class Title
    {
        /// <summary>
        /// поле описывающее произведение
        /// </summary>
        private string title;

        /// <summary>
        /// конструктор с 1 параметром 
        /// </summary>
        /// <param name="title">параметр описывающий поле произведение</param>
        public Title(string title)
        {
            this.title = title;
        }

        /// <summary>
        /// метод вывода информации
        /// </summary>
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Название книги: {title}");
            Console.ResetColor();
        }
    }
}
