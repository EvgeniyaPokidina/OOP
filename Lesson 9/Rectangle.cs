using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_9
{
    internal class Rectangle
    {
        private double a;
        public double A
        {
            get { return a; }
            set { if (value > 0) a = value; }
        }
        private double b;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public double B
        {
            get { return b; }
            set { if (value > 0) b = value; }
        }
        public double Perimetr()
        {
            return (a + b) * 2;
        }
        public double Area()
        {
            return a * b;
        }
        public void Print()
        {
            Console.WriteLine("Периметр:" + Perimetr() + " Площадь:" + Area());
        }
    }
}
