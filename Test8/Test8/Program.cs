using System;

namespace Test8;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число ");
        int limit = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 0;

        Console.ForegroundColor = ConsoleColor.Green;
        for (int i = 0; i <= limit; i++)
        {
            Console.WriteLine("Number i = {0}  ", i);
        }


        Console.ForegroundColor = ConsoleColor.Red;
        while (a <= limit)
        {
            Console.WriteLine("Number a = {0} ", a, a++ );
        }


        Console.ForegroundColor = ConsoleColor.Yellow;
        do
        {
            Console.WriteLine("Number b = {0} ", b, b++);
        }
        while (b <= limit);
    }
}