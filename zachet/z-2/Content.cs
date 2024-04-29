using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_2
{
    class Content
    {/// <summary>
    /// поле контент
    /// </summary>
        private string content;

        /// <summary>
        /// конструктор с 1 параметром
        /// </summary>
        /// <param name="content">параметр описывающий поле контент</param>
        public Content(string content)
        {
            this.content = content;
        }

        /// <summary>
        /// метод вывода информации
        /// </summary>
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Содержание: {content}");
            Console.ResetColor();
        }
    }
}
