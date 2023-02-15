using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine("Введите число ");
            a = double.Parse(Console.ReadLine());
            if(a % 2 == 0)
            {
                Console.WriteLine("Число чётное ");
            }
            else
            {
                Console.WriteLine("Число не чётное ");
            }
            Console.ReadLine();
        }
    }
}
