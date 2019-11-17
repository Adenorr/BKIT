using System;

namespace lab2
{
    class Squares : Rectangles, IPrint
    {
        public Squares(double s) : base(s, s) { }

        public override string ToString()
        {
            return "Длина стороны: " + this.Hight.ToString() + " Площадь: " + (this.Area()).ToString();
        }
        public new void Print()
        {
            Console.WriteLine(ToString());
        }

    }

}