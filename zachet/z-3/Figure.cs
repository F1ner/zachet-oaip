using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_3
{
   
        class Figure
        {
            private readonly Point[] points;

            /// <summary>
            /// Создает новый экземпляр класса Figure.
            /// </summary>
            /// <param name="points">Точки, образующие многоугольник.</param>
            public Figure(params Point[] points)
            {
                if (points.Length < 3 || points.Length > 5)
                {
                    throw new ArgumentException("Фигура должна состоять из 3-5 точек.");
                }

                this.points = points;
            }

            /// <summary>
            /// Метод Рассчитывает периметр многоугольника.
            /// </summary>
            public void PerimeterCalculator()
            {
                double perimeter = 0;
                for (int i = 0; i < points.Length; i++)
                {
                    perimeter += LengthSide(points[i], points[(i + 1) % points.Length]);
                }
                Console.WriteLine($"Периметр фигуры: {perimeter}");
            }

            /// <summary>
            /// Рассчитывает длину стороны многоугольника между точками A и B.
            /// </summary>
            /// <param name="A">Первая точка.</param>
            /// <param name="B">Вторая точка.</param>
            /// <returns>Длина стороны многоугольника.</returns>
            private double LengthSide(Point A, Point B)
            {
                return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            }
        }
    }

