using System;
namespace AreaOfShape
{
    abstract class ShapesClass
    {
        abstract public double Area();

        public double Area1 => Area();

        abstract public double Perimeter();
        public double Perimeter1 => Perimeter();
        public override string ToString()
        {
            return $"Area: {this.Area()}, Perimeter: {this.Perimeter()} ";
        }

    }
    class Rectangle : ShapesClass
    {
        public int x
        {
            get;
            set;
        }
        public int y
        {
            get;
            set;
        }
        public override double Area()
        {
            return x * y;
        }
        public override double Perimeter()
        {
            return 2 * (x + y);
        }
    }
    class Circle : ShapesClass
    {
        public int r
        {
            get;
            set;
        }
        public override double Area()
        {
            return Math.PI * r * r;
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * r;
        }
    }
    class Square : ShapesClass
    {
        public int r
        {
            get;
            set;
        }
        public override double Area()
        {
            return r * r;
        }
        public override double Perimeter()
        {
            return 4 * r;
        }
    }
    class Triangle : ShapesClass
    {
        public int a
        {
            get;
            set;
        }
        public int b
        {
            get;
            set;
        }
        public int c
        {
            get;
            set;
        }
        public override double Area()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public override double Perimeter()
        {
            return a + b + c;
        }
    }
}