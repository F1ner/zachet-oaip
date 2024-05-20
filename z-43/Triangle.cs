using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_43
{
    // Обобщенный класс Triangle
    class Triangle<T>
    {
        /// <summary>
        /// поле описывающее сторону a
        /// </summary>
        private T a;
        /// <summary>
        /// поле описывающее сторону b
        /// </summary>
        private T b;
        /// <summary>
        /// поле описывающее сторону c
        /// </summary>
        private T c;



        /// <summary>
        /// Конструктор с 3 параметрами
        /// </summary>
        /// <param name="a">поле a</param>
        /// <param name="b">поле b</param>
        /// <param name="c">поле c</param>
        public Triangle(T a, T b, T c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        /// <summary>
        /// свойства поля A
        /// </summary>
       public T A
        { get { return a; }
            set { a = value; }
        }

        /// <summary>
        /// свойства поля B
        /// </summary>
        public T B
        {
            get { return b; }
            set { b = value; }
        }

        /// <summary>
        /// свойства поля C
        /// </summary>
        public T C
        {
            get { return c; }
            set { c = value; }
        }

        /// <summary>
        /// Метод вывода информации о треугольнике
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"Cтороный треугольника: A = {a}, B = {b}, C = {c}");
        }

        /// <summary>
        ///  Метод, возвращающий площадь треугольника
        /// </summary>
        /// <returns>AREA</returns>
        public double CalculateArea()
        {
            // Преобразование к типу double, чтобы избежать потери точности при вычислениях
            double sideA = Convert.ToDouble(a);
            double sideB = Convert.ToDouble(b);
            double sideC = Convert.ToDouble(c);

            // Полупериметр
            double s = (sideA + sideB + sideC) / 2;

            // Формула Герона для вычисления площади треугольника
            double area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));

            return area;
        }
    }
}