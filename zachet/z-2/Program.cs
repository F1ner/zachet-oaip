using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_2
{
    class Program
    {
        static void Main(string[] args)
        {

            //2 ZADANIE
            Console.WriteLine("Введите название книги:");
            string title = Console.ReadLine();

            Console.WriteLine("Введите имя автора:");
            string author = Console.ReadLine();

            Console.WriteLine("Введите содержание:");
            string content = Console.ReadLine();

            Book book = new Book(title, author, content);

            Console.WriteLine("\nДанные о книге:");
            book.Show();

            Console.ReadKey();
        }
    }
}
