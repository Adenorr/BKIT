using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Подопригорова С. ИУ5-34Б";
            Menu menu = new Menu();
            Rectangles rectangle = new Rectangles(7, 30);
            Squares square = new Squares(9);
            Circle circle = new Circle(5);
            while (true)
            {
                switch (menu.menu())
                {
                    case 1:
                        {
                            Console.WriteLine();
                            Console.WriteLine("считаем объект Rectangle");
                            rectangle.Print();
                            Console.WriteLine();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine();
                            Console.WriteLine("считаем объект Square");
                            square.Print();
                            Console.WriteLine();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine();
                            Console.WriteLine("считаем объект Circle");
                            circle.Print();
                            Console.WriteLine();
                            break;
                        }
                    case 4:
                        {
                            return;
                        }
                }
            }
        }
    }
}

