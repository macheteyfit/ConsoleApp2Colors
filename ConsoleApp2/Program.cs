using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        enum Colors { Red, Orange, Green, Blue, Black};
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Text");


            if (!Enum.IsDefined(typeof(Colors), "White"))
            {
                Console.WriteLine($"Значение White нет в перечислении Colors.");
            }
            if (!Enum.IsDefined(typeof(Colors), "Green"))
            {
                Console.WriteLine($"Значение Green нет в перечислении Colors.");
            }
            Console.WriteLine(Enum.GetName(typeof(Colors), 1));

            //выводит массив значений констант в указанном перечислении
            foreach (int i in Enum.GetValues(typeof(Colors)))
            {
                Console.WriteLine($"{i}");
            }

            //выводит массив имён констант в указанном перечислении
            foreach (string name in Enum.GetNames(typeof(Colors)))
            {
                Console.WriteLine(name);
            }


            foreach (ConsoleColor c in Enum.GetValues(typeof(ConsoleColor)))
            {
                Console.ForegroundColor = c;
                Console.WriteLine($"Color: {c}");
            }
            foreach (ConsoleColor c in Enum.GetValues(typeof(ConsoleColor)))
            {
                Console.ReadKey();
                Console.BackgroundColor = c;
                Console.Clear();
                Console.WriteLine($"Color: {c}");
            }
        }
    }
}


/*
 string input = "5+6+1-3/3*10";
            string[] numberStrings = input.Split(new char[] { '+', '-', '*', '/' },
            StringSplitOptions.RemoveEmptyEntries);

            int[] numbers = new int[numberStrings.Length];
            for (int i = 0; i < numberStrings.Length; i++)
            {
                numbers[i] = Convert.ToInt32(numberStrings[i]);
 Console.WriteLine(DayOfWeek.Monday);

  Console.WriteLine(Colors.Black.ToString());
            Console.ReadKey();
            }*/