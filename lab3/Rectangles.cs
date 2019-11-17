using System;

namespace lab3

{
    class Rectangles : Figur, IPrint
    {
        private double widht;
        private double hight;
        public Rectangles()
        {
            widht = 0;
            hight = 0;
            Type = "Прямоугольник";
        }
        public Rectangles(double w, double h)
        {
            widht = w;
            hight = h;
            Type = "Прямоугольник";
        }
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
            if (Type == "Прямоугольник")
            {
                return base.ToString() + "; Ширина: " + widht.ToString() + "; Длина: " + hight.ToString(); 
       
            }
            else
            {
                return base.ToString();
            }

        }
        public void Print()
        {
            Console.WriteLine(ToString());
        }
    }

}