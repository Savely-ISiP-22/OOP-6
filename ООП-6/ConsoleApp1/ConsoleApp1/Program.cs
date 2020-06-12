using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");

            Class1 argument = new Class1();
            argument.Print();
            Class1 argument1 = new Class1(228);
            argument1.Print();
            Class1 argument2 = new Class1(1488, 1337);
            argument2.Print();

            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");

            Class2 text1 = new Class2();
            Class2 text2 = new Class2();
            Class2 text3 = new Class2();
            text1.Write();
            text1.Print();
            text2.Write("Сессия");
            text2.Print();
            text3.Write("Сессия сдана");
            text3.Print();

            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");

            Class3 triangle = new Class3(15, 7, 1);
            Console.WriteLine("-------------------------------");
            Class3 triangle2 = new Class3(12, 5, 13);

            Console.WriteLine("");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("");

            Console.ReadLine();
        }
    }
}
