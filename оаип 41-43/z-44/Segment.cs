using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_44
{
    // Обобщенный класс Segment
    class Segment<T>
    {
        /// <summary>
        /// поле описывающее точку x1
        /// </summary>
        private T x1;
        /// <summary>
        /// поле описывающее точку y1
        /// </summary>
        private T y1;
        /// <summary>
        /// поле описывающее точку x2
        /// </summary>
        private T x2;
        /// <summary>
        /// поле описывающее точку y2
        /// </summary>
        private T y2;

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Segment() { }

        /// <summary>
        ///  Конструктор с 4 параметрами
        /// </summary>
        /// <param name="x1">x1</param>
        /// <param name="y1">y1</param>
        /// <param name="x2">x2</param>
        /// <param name="y2">y2</param>
        public Segment(T x1, T y1, T x2, T y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        /// <summary>
        /// свойства поля x1
        /// </summary>
        public T X1
        {
            get { return x1; }
            set { x1 = value; }
        }

        /// <summary>
        /// свойства поля y1
        /// </summary>
        public T Y1
        {
            get { return y1; }
            set { y1 = value; }
        }

        /// <summary>
        /// свойства поля x2
        /// </summary>
        public T X2
        {
            get { return x2; }
            set { x2 = value; }
        }

        /// <summary>
        /// свойства поля y2
        /// </summary>
        public T Y2
        {
            get { return y2; }
            set { y2 = value; }
        }

        /// <summary>
        ///  Метод вывода информации об отрезке
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"Segment coordinates: ({x1}, {y1}) - ({x2}, {y2})");
        }

        /// <summary>
        ///  Метод, возвращающий длину отрезка
        /// </summary>
        /// <returns>length(длина)</returns>
        public double CalculateLength()
        {
            // Преобразование к типу double, чтобы избежать потери точности при вычислениях
            double deltaX = Convert.ToDouble(x2) - Convert.ToDouble(x1);
            double deltaY = Convert.ToDouble(y2) - Convert.ToDouble(y1);

            // Формула для вычисления длины отрезка
            double length = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

            return length;
        }
    }
}
