using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_2
{
    class Author
    {
        /// <summary>
        /// поле поисывающее имя автора
        /// </summary>
        private string authorName;

        /// <summary>
        /// конструктор с 1 параметром
        /// </summary>
        /// <param name="authorName">параметр описывающий поле имя автора</param>
        public Author(string authorName)
        {
            this.authorName = authorName;
        }

        /// <summary>
        /// метод вывода информации
        /// </summary>
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Имя автора: {authorName}");
            Console.ResetColor();
        }
    }
}
