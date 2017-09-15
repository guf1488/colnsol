using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Console
{
    public class Circle : IComparable<Circle>
    {
        public Circle(double radius)
        {
            r = radius;
        }

        private double r;

        public double Calculate()
        {
            return Math.PI * r * r;
        }

        public int CompareTo(Circle other)
        {
            if (this.Calculate() > other.Calculate())
            {
                return 1;
            }
            if (this.Calculate() < other.Calculate())
            {
                return -1;
            }
            return 0;
        }
    }
}
