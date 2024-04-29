using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_2
{
    class Book
    {
        /// <summary>
        /// поле описывающее произведение
        /// </summary>
        private string title;
        /// <summary>
        /// поле описывающее автора
        /// </summary>
        private string author;
        /// <summary>
        /// поле описывающее контент
        /// </summary>
        private string content;

        /// <summary>
        /// конструктор с 3 параметрами
        /// </summary>
        /// <param name="title">параметр описывающий поле произведение</param>
        /// <param name="author">параметр описывающий поле автор</param>
        /// <param name="content">параметр описывающий поле контент</param>
        public Book(string title, string author, string content)
        {
            this.title = title;
            this.author = author;
            this.content = content;
        }

        /// <summary>
        /// метод вывода информации
        /// </summary>
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Название книги: {title}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Имя автора: {author}");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Содержание: {content}");
            Console.ResetColor();
        }
    }
}
