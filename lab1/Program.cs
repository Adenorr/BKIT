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
            if ((a == 0) & (b == 0) & (c == 0))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Корней бесконечно много");
            }
            else
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

                        double x1 = (-b - Math.Sqrt(D)) / (2 * a);
                        double x2 = (-b + Math.Sqrt(D)) / (2 * a);

                        if ((x1 >= 0) || (x2 >= 0))
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
                        double x = -b / (2 * a);
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
        }
        static void ParseInput(string[] args, double[] a, bool success)
        {
            if (args.Length != 3 || !success)
            {
                if (args.Length != 3)
                {
                    string[] args2 = new string[3];
                    args = args2;
                }
                Console.WriteLine("Введите A, B и C");
                for (int k = 0; k < 3; k++)
                    args[k] = Console.ReadLine();
            }
            Byte i = 0;
            foreach (string Ar in args)
            {
                success = Double.TryParse(Ar, out a[i]);
                if (!success)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Произошла ошибка. Повторите ввод");
                    Console.ResetColor();
                    ParseInput(args, a, success);
                    return;
                }
               else
                Console.Write("{0 }  ", Ar);
                i++;
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            bool success = true;

            Console.Title = "Подопригорова С. ИУ5-34Б";
            double[] a = new Double[3];

            ParseInput(args, a, success);
            Console.WriteLine("Дискриминант D = {0}", Disc(a[0], a[1], a[2]));
            Root(a[0], a[1], a[2]);
            Console.ReadKey();
        }
    }
}



