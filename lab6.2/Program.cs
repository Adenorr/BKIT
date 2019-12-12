using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace lab6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            InspectionClass Insp = new InspectionClass();
            Type t = Insp.GetType();

            Console.WriteLine("Тип : " + t.FullName);
            Console.WriteLine("Унаследован от : " + t.BaseType.FullName);
            Console.WriteLine("Пространство имен : " + t.Namespace);

            Console.WriteLine("\nКонструкторы : ");
            foreach (var x in t.GetConstructors())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nМетоды : ");
            foreach (var x in t.GetMethods())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nСвойства : ");
            foreach (var x in t.GetProperties())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nПоля данных (public) : ");
            foreach (var x in t.GetFields())
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nПоля данных (no public) : ");
            foreach (var x in t.GetFields(BindingFlags.NonPublic | BindingFlags.Instance))
            {
                Console.WriteLine(x);
            }

            Console.WriteLine("\nКонструкторы, помеченные атрибутом : ");
            foreach (var x in t.GetConstructors())
            {
                var isAttribute = x.GetCustomAttributes(typeof(ConvAttribute),false);
                if (isAttribute.Length > 0)
                {
                    Console.Write(x.Name + " имеет {0} атрибутов ", isAttribute.Length);
                    foreach (var att in isAttribute)
                        if (att is ConvAttribute) Console.Write(", в то числе ConvAttribute. Description = " + (att as ConvAttribute).Description);
                        
                    Console.WriteLine();
                }
                
            }

            

            Console.WriteLine("\nВызов конструктора через рефлексию : ");

            InspectionClass fi = (InspectionClass)t.InvokeMember(null, BindingFlags.CreateInstance, null, null, new object[] { });

            object Result = t.InvokeMember("MetrToYard", BindingFlags.InvokeMethod, null, fi, new object[] { 3 });

            Console.WriteLine("MetrToYard(3) = 3 * 1.094 ={0}", Result);

            Console.ReadLine();



        }
    }
}
