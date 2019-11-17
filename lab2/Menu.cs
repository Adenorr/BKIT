using System;

namespace lab2
{
    class Menu
    {
        int indicator;
        bool success;
        public int menu()
        {
            Console.WriteLine("1 - считаем Rectangle");
            Console.WriteLine("2 - считаем Square");
            Console.WriteLine("3 - считаем Circle");
            Console.WriteLine("4 - выход");
            Console.WriteLine("Введите номер фигуры");
            success = Int32.TryParse(Console.ReadLine(), out indicator);
            if (!success)
            {
                Console.WriteLine();
                indicator = menu();
            }
            return indicator;
        }
    }

}