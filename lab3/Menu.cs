using System;

namespace lab3

{
    class Menu
    {
        int indicator;
        bool success;
        public int menu()
        {
            Console.WriteLine("1 - коллекция класса List<Figure>");
            Console.WriteLine("2 - коллекция класса ArrayList");           
            Console.WriteLine("3 - Стек");
            Console.WriteLine("4 - Матрица");
            Console.WriteLine("5 - выход");
            Console.WriteLine("Введите номер действия");
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