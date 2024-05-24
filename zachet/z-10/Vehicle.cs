using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_10
{
    abstract class Vehicle
    {
        /// <summary>
        /// поле описывающее координаты
        /// </summary>
        protected double[] coordinates;
        /// <summary>
        /// поле описывающее цену
        /// </summary>
        protected double price;
        /// <summary>
        /// поле описывающее скорость
        /// </summary>
        protected double speed;
        /// <summary>
        /// поле описывающее год
        /// </summary>
        protected int year;

        /// <summary>
        /// конструктор с 4 параметрами 
        /// </summary>
        /// <param name="coordinates">поле описывабщее координаты</param>
        /// <param name="price">поле описываающее цену</param>
        /// <param name="speed">поле описывающее скорость</param>
        /// <param name="year">поле описывающее год</param>
        public Vehicle(double[] coordinates, double price, double speed, int year)
        {
            this.coordinates = coordinates;
            this.price = price;
            this.speed = speed;
            this.year = year;
        }

        /// <summary>
        /// Метод для вывода информации о транспортном средстве
        /// </summary>
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Координаты: ({coordinates[0]}, {coordinates[1]})");
            Console.WriteLine($"Цена: {price}$");
            Console.WriteLine($"Скорость: {speed} км/ч");
            Console.WriteLine($"Год: {year}");
        }
    }

}
