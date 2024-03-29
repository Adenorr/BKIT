﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using lab5;

namespace lab6
{
    class Program
    {
        delegate int ShearhFunction(string firstText, string secondText); //какой алгоритм использовать
        

        static string ConsoleOpenFile(ref List<string> ListS)
        {
            string FileNameStr = "";
            Console.Write("Открыть файл :");
            FileNameStr = Console.ReadLine();
            if (FileNameStr == "") FileNameStr = "Новый текстовый документ.txt";
            try
            {
                string[] MasStr = File.ReadAllText(FileNameStr, Encoding.ASCII).Split(' ', '\t', '!', '?', ',', '-', '.', ':', '\r', '\n');
                foreach (string s in MasStr)
                {
                    if (!String.IsNullOrEmpty(s))
                    {
                        string lowercase = s.ToLower();
                        if (!ListS.Contains(lowercase)) ListS.Add(lowercase);
                    }
                }
            }
            catch
            {
                Console.WriteLine("Файл {0} не существует или поврежден, повторите ввод!", FileNameStr);
                FileNameStr = "";
            }

            return FileNameStr;
        }

        
        

        static void Main(string[] args)
        {
            ShearhFunction FuncShearh = null;
            
            List<string> ListStr = new List<string>();
            string FileNameS = "";
            do
            {
                FileNameS = ConsoleOpenFile(ref ListStr);
            }
            while (FileNameS == "");
            Console.WriteLine("Файл  :  {0} ОТКРЫТ !", FileNameS);

            Console.Write("Введите строку для поиска : ");
            string StrShearh = Console.ReadLine();

            Console.WriteLine("Введите номер алгоритма");
            Console.WriteLine("1 - Простой поиск");
            Console.WriteLine("2 - Расстояние Дамерау-Левенштейна");
            Console.WriteLine("3 - Алгоритм Вагнера — Фишера");
            Console.WriteLine("4 - выход");
            int indicator = -1;
            do
            {               
                bool success = Int32.TryParse(Console.ReadLine(), out indicator);
                if ((!success)||(indicator > 4)|| (indicator < 1))
                {
                    Console.WriteLine("Не верно введен номер. Повторите ввод!");
                    indicator = -1;
                }
                if (indicator == 4) return;
            }
            while ((indicator < 1) || (indicator > 3));

            string substring = StrShearh.ToLower();

            switch (indicator)
            {
                case 1:
                    ShearhFunction FShearh = delegate (string firstText, string secondText)
                    {
                        int Distance = 0;
                        if (firstText.Contains(secondText)) Distance = Math.Abs(firstText.Length - secondText.Length);
                        else Distance = 100;
                        return Distance;
                    };
                    DistanceFunc(substring, ListStr, (firstText, secondText) =>
                    {
                        int Distance = 0;
                        if (firstText == secondText) Distance = 0;
                        else
                        if (firstText.Contains(secondText)) Distance = Math.Abs(firstText.Length - secondText.Length);
                        else Distance = 100;
                        return Distance;
                    }, FShearh);
                    
                    break;
                case 2:
                    FuncShearh = new ShearhFunction(lab5.LevenshteinDistance.DamerauLevenshtein);                    
                    DistanceFunc(substring, ListStr, lab5.LevenshteinDistance.DamerauLevenshtein, FuncShearh);                    
                    
                    break;
                case 3:
                    FuncShearh = lab5.LevenshteinDistance.DamerauLevenshtein;
                    Func<string, string, int> FuncShearhFunc = lab5.LevenshteinDistance.WagnerFisher;
                    DistanceFunc(substring, ListStr, FuncShearhFunc, FuncShearh);                                      
                    break;
                default:
                    break;
            }
            
        }

        static void DistanceFunc(string substring, List<string> ListStr, Func<string, string, int> FuncShearhFunc, ShearhFunction FuncShearh)
        {
            int k = 0;
            foreach (string s in ListStr)
            {
                int Distance = FuncShearh(s, substring);
                Console.WriteLine("заранее объявленный Delegat : " + k + "  Строка - " + s + " - Дистанция - " + Distance);
                Distance = FuncShearhFunc(s, substring);
                Console.WriteLine("Delegat объявленный  Func<> : " + k + "  Строка - " + s + " - Дистанция - " + Distance);
                Console.WriteLine();
                k++;
            }

            Console.ReadLine();
        }
    }
        
}
