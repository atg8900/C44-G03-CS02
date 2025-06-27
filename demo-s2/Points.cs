using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_s2
{
   internal class Points
    {
        public Points()
        {
           

        }
        public Points(int x, int y)
        {
            X = x;
            Y = y;

        }
        public int X { get; set; }

        public int Y { get; set; }

        public override string ToString()
        {
            return $"X={X} , Y={Y}";
        }

        public override bool Equals(object? obj)
        {
            Points points = (Points)obj;

            return this.X == points.X && this.Y == points.Y;
        }
    }
}
