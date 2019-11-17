using System;

namespace lab3
{
    abstract class Figur : IComparable
    {
        public string Type
        {
            get
            {
                return this._Type;
            }
            protected set
            {
                this._Type = value;
            }
        }
        string _Type;

        public abstract double Area();

        public override string ToString()
        {
            return "Тип: " + this.Type + " Площадь: " + this.Area().ToString() + " ";
        }

        public int CompareTo(object obj)
        {

            Figur p = (Figur)obj;

            if (this.Area() < p.Area()) return -1;
            else if (this.Area() == p.Area()) return 0;
            else return 1;
        }
    }
}
