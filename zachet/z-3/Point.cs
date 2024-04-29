using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_3
{
    class Point
    {
        /// <summary>
        /// Координата X точки.
        /// </summary>
        public int X { get; }

        /// <summary>
        /// Координата Y точки.
        /// </summary>
        public int Y { get; }

        /// <summary>
        /// Название точки.
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Создает новый экземпляр класса Point.
        /// </summary>
        /// <param name="x">Координата X.</param>
        /// <param name="y">Координата Y.</param>
        /// <param name="name">Название точки.</param>
        public Point(int x, int y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }
    }
}
