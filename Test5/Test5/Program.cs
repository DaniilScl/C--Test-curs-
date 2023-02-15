using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number 1 ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Number 2 ");
            int b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadLine();

            Console.WriteLine("Степень заражения в процентах");
            int c = int.Parse(Console.ReadLine());
            bool d = c > 45 ;
            if (!d) 
            {
                Console.WriteLine("Мутации нет");
            }
            else { Console.WriteLine("Идёт мутация"); }
            Console.ReadLine();
        }
    }
}
