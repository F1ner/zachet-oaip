using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_42
{
    // Обобщенный класс Point
    class Point<T>
    {
        private T x;
        private T y;
        /// <summary>
        /// конструктор без параметров
        /// </summary>
        public Point() { }

        /// <summary>
        /// Конструктор с двумя параметрами
        /// </summary>
        /// <param name="x">поле x</param>
        /// <param name="y">поле y</param>
        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Свойства доступа к внутренним полям класса x и y
        /// </summary>
        public T X
        {
            get { return x; }
            set { x = value; }
        }

        public T Y
        {
            get { return y; }
            set { y = value; }
        }

        /// <summary>
        /// Метод для вывода значений внутренних полей класса
        /// </summary>
        public void Display()
        {
            Console.WriteLine($"Координаты точки: ({x}, {y})");
        }
    }
}
