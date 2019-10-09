using System;


namespace lab1
{
    class Program
    {
        static double Disc(double a, double b, double c)
        {
            return (b * b - 4 * a * c);
        }
        static void Root(double a, double b, double c)
        {
            if (a == 0)
            {

                double x = -c / b;
                if (x >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Корни:");

                    Console.WriteLine("{0}, {1}", Math.Sqrt(x), -Math.Sqrt(x));
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Действительных корней нет");
                }
            }
            else
            {
                double D = Disc(a, b, c);
                if (D > 0)
                {

                    double x1 = (-b - Math.Sqrt(D)) / 2 * a;
                    double x2 = (-b + Math.Sqrt(D)) / 2 * a;

                    if ((x1 >= 0)||(x2 >= 0))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Корни:");
                        if (x1 >= 0) Console.WriteLine("{0}, {1}", Math.Sqrt(x1), -Math.Sqrt(x1));
                        if (x2 >= 0) Console.WriteLine("{0}, {1}", Math.Sqrt(x2), -Math.Sqrt(x2));
                    }

                }
                else
                    if (D == 0)
                {
                    double x = -b / 2 * a;
                    if (x >= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Корни:");

                        Console.WriteLine("{0}, {1}", Math.Sqrt(x), -Math.Sqrt(x));
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Действительных корней нет");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Действительных корней нет");
                }
            }
        }
        static void ParseInput(double[] a)
        {
            bool[] tr = new bool[3];
            string str;
            Console.WriteLine("Ax^4+Bx^2+C=0");
            Console.WriteLine("Enter");
            Console.Write("A: ");
            str = Console.ReadLine();
            tr[0] = double.TryParse(str, out a[0]);
            Console.Write("B: ");
            str = Console.ReadLine();
            tr[1] = double.TryParse(str, out a[1]);
            Console.Write("C: ");
            str = Console.ReadLine();
            tr[2] = double.TryParse(str, out a[2]);
            if (tr[0] == false || tr[1] == false || tr[2] == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Повторите ввод");
                Console.ForegroundColor = ConsoleColor.Gray;
                ParseInput(a);
            }
        }

        static void Main(string[] args)
        {
            Console.Title = "Подопригорова С. ИУ5-34Б";
            double[] a = new Double[3];
            ParseInput(a);
            Console.WriteLine("Дискриминант D = {0}", Disc(a[0], a[1], a[2]));
        
            Root(a[0], a[1], a[2]);
            Console.ReadKey();
        }
    }

}

