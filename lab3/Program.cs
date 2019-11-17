using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            Circles circle = new Circles(4);
            Rectangles rectangle = new Rectangles(7, 9);
            Squares square = new Squares(5);

            while (true)
            {
                switch (menu.menu())
                {
                    case 1:
                        {
                            List<Figur> list = new List<Figur>();
                            list.Add(circle);
                            list.Add(rectangle);
                            list.Add(square);

                            foreach (var x in list) Console.WriteLine(x);
                            Console.WriteLine();

                            Console.WriteLine("Cортировка");
                            list.Sort();
                            foreach (var x in list) Console.WriteLine(x);
                            break;
                        }
                    case 2:
                        {
                            ArrayList array = new ArrayList();
                            array.Add(circle);
                            array.Add(rectangle);
                            array.Add(square);

                            foreach (var x in array) Console.WriteLine(x);
                            Console.WriteLine();

                            Console.WriteLine("Сортировка");
                            array.Sort();
                            foreach (var x in array) Console.WriteLine(x);
                            Console.WriteLine();
                            break;
                        }                        
                    case 3:
                        {
                            SimpleStack<Figur> stack = new SimpleStack<Figur>();
                            stack.Push(rectangle);
                            stack.Push(square);
                            stack.Push(circle);

                            while (stack.Count > 0)
                            {
                                Figur f = stack.Pop();
                                Console.WriteLine(f);
                            }
                            Console.WriteLine();
                            break;
                        }
                    case 4:
                        {
                            Matrix3d<Figur> cube = new Matrix3d<Figur>(3, 3, 3, null);
                            cube[0, 0, 0] = rectangle;
                            cube[1, 1, 1] = square;
                            cube[2, 2, 2] = circle;
                            Console.WriteLine(cube.ToString());
                            Console.WriteLine();
                            break;
                        }
                       
                    case 5:
                        {
                            return;
                        }
                }
            }
        }
    }
}
