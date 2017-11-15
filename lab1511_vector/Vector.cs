using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1511_vector
{
    class Vector
    {
        double x;
        public double X { get { return x; } set { x = value; } }
        double y;
        public double Y { get { return y; } set { y = value; } }

        public Vector(double x, double y)
        {
            this.x = x; this.y = y;
        }

        public static Vector Parse(string str)
        {
            int v = str.IndexOf(",");
            int x = int.Parse(str.Substring(0, v));
            int y = int.Parse(str.Substring(v + 1));
            return new Vector(x, y);
        }
        public string print()
        {
            return "x= (" + x + ", " + y + ")";
        }
    }
}
