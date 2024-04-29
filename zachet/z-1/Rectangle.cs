using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_1
{
    class Rectangle
    {
        /// <summary>
        /// поле сторона 1
        /// </summary>
        private double side1;
        /// <summary>
        /// поле сторона 2
        /// </summary>
        private double side2;

        /// <summary>
        /// конструктор с 3 параметрами
        /// </summary>
        /// <param name="side1">параметр описывающий поле 1</param>
        /// <param name="side2">параметр описывающий поле 2</param>
        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        /// <summary>
        /// метод вычисления площади
        /// </summary>
        /// <returns></returns>
        public double AreaCalculator()
        {
            return side1 * side2;
        }

        /// <summary>
        /// метод вычисления периметра
        /// </summary>
        /// <returns></returns>
        public double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }

        /// <summary>
        /// свойство описывающее площадь
        /// </summary>
        public double Area
        {
            get { return AreaCalculator(); }
        }
        /// <summary>
        /// свойство описывающее периметр
        /// </summary>
        public double Perimeter
        {
            get { return PerimeterCalculator(); }
        }
    }

}
