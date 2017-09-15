using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //услловие
            Circle a = new Circle(10);
            Circle b = new Circle(20);
            Circle c = new Circle(30);

            if (a.CompareTo(b) > 0)
            {
                System.Console.WriteLine("a > b");
            }
            if (a.CompareTo(b) < 0)
            {
                System.Console.WriteLine("a < b");
            }
            if (a.CompareTo(b) == 0)
            {
                System.Console.WriteLine("a == b");
            }

            if (c.CompareTo(b) > 0)
            {
                System.Console.WriteLine("c > b");
            }
            if (c.CompareTo(b) < 0)
            {
                System.Console.WriteLine("c < b");
            }
            if (c.CompareTo(b) == 0)
            {
                System.Console.WriteLine("c == b");
            }
        }
    }
}
