using System;

namespace lab2
{
    class Rectangles : Figur, IPrint
    {
        private double widht;
        private double hight;
        public Rectangles() { widht = 0; hight = 0; }
        public Rectangles(double w, double h) { widht = w; hight = h; }
        public double Hight
        {
            get
            {
                return hight;
            }
            set
            {
                hight = value;
            }
        }
        public double Widht
        {
            get
            {
                return widht;
            }
            set
            {
                widht = value;
            }
        }
        public override double Area()
        {
            return widht * hight;
        }
        public override string ToString()
        {
            return "Ширина: " + widht.ToString() + " Длина: " + hight.ToString() + " Площадь: " + (this.Area()).ToString();
        }
        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}

