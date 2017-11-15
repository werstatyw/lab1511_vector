using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1511_vector
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vector in (x,y) format: ");
            string s = Console.ReadLine();
            Vector v1 = Vector.Parse(s);
            Console.WriteLine(v1.print());
            Console.ReadKey();
        }
    }
}
