using System;

namespace lab3

{
    class Circles : Figur, IPrint
    {
        double radius;
        public Circles() { radius = 0; }
        public Circles(double r) { radius = r; }
        public override double Area()
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
        public override string ToString()
        {
            return "Радиус: " + radius.ToString() + "; Площадь: " + (this.Area()).ToString();
        }
        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }

}