using System;

namespace lab3

{
    class Squares : Rectangles, IPrint
    {
        public Squares() : base()
        {
            this.Type = "Квадрат";
        }

        public Squares(double s) : base(s, s)
        {
            this.Type = "Квадрат";
        }

        public override string ToString()
        {
            return base.ToString() + "; Длина стороны: " + this.Hight.ToString();
        }
    }

}