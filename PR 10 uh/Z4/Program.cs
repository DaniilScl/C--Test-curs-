using System;
using System.Security.Cryptography;

namespace Lesson;
class Programm
{
    static void Main(string[] args)
    {


        ///1


        //Console.Write("Начальное число прогрессии: ");
        //double PR_a = double.Parse(Console.ReadLine());

        //Console.Write("Лимит геометрической прогрессии: ");
        //double limit = double.Parse(Console.ReadLine());

        //Console.Write("Разность прогрессии: ");
        //double PR_b = double.Parse(Console.ReadLine());
        //double pr1;

        //for (int i = 0; i < limit;)
        //{
        //    pr1 = PR_a *= PR_b;
        //    i++;
        //    Console.WriteLine(0.1 * pr1 + 10);
        //}

        ///3

        //Console.Write("Начальное число прогрессии: ");
        //double PR_a = double.Parse(Console.ReadLine());

        //Console.Write("Лимит геометрической прогрессии: ");
        //double limit = double.Parse(Console.ReadLine());

        //Console.Write("Разность прогрессии: ");
        //double PR_b = double.Parse(Console.ReadLine());
        //double pr1;

        //for (int i = 0; i < limit;)
        //{
        //    pr1 = PR_a *= PR_b;
        //    i++;
        //    Console.WriteLine(0.2 * Math.Pow(pr1,4) + 1);
        //}
        ///2

        //Console.Write("Начальное число прогрессии: ");
        //double PR_a = double.Parse(Console.ReadLine());

        //Console.Write("Лимит геометрической прогрессии: ");
        //double limit = double.Parse(Console.ReadLine());

        //Console.Write("Разность прогрессии: ");
        //double PR_b = double.Parse(Console.ReadLine());
        //double pr1;

        //for (int i = 0; i <= limit; i++)
        //{
        //    pr1 = PR_a *= PR_b;
        //    double pr2 = Math.Pow(pr1, limit - 1); 

        //    Console.WriteLine(9-(2*pr2));
        //}
        ///4

        //Console.Write("Начальное число прогрессии: ");
        //double PR_a = double.Parse(Console.ReadLine());

        //Console.Write("Лимит геометрической прогрессии: ");
        //double limit = double.Parse(Console.ReadLine());

        //Console.Write("Разность прогрессии: ");
        //double PR_b = double.Parse(Console.ReadLine());
        //double pr1;

        //for (int i = 0; i < limit; i++)
        //{
        //    pr1 = PR_a *= PR_b;

        //    Console.WriteLine(Math.Sin(pr1)+ Math.PI);
        //}
        ///5

        //Console.Write("Начальное число прогрессии: ");
        //double PR_a = double.Parse(Console.ReadLine());

        //Console.Write("Лимит геометрической прогрессии: ");
        //double limit = double.Parse(Console.ReadLine());

        //Console.Write("Разность прогрессии: ");
        //double PR_b = double.Parse(Console.ReadLine());
        //double pr1;

        //for (int i = 0; i < limit; i++)
        //{
        //    pr1 = PR_a *= PR_b;

        //    Console.WriteLine(0.1666666667*(0.5+Math.Pow(pr1, 3)));
        //}
        ///6

        //Console.Write("Начальное число прогрессии: ");
        //double PR_a = double.Parse(Console.ReadLine());

        //Console.Write("Лимит геометрической прогрессии: ");
        //double limit = double.Parse(Console.ReadLine());

        //Console.Write("Разность прогрессии: ");
        //double PR_b = double.Parse(Console.ReadLine());
        //double pr1;

        //for (int i = 0; i < limit; i++)
        //{
        //    pr1 = PR_a *= PR_b;

        //    Console.WriteLine(0.5*((1/pr1) + pr1));
        //}
        ///7


        //Console.Write("Начальное число прогрессии: ");
        //double PR_a = double.Parse(Console.ReadLine());

        //Console.Write("Лимит геометрической прогрессии: ");
        //double limit = double.Parse(Console.ReadLine());

        //Console.Write("Разность прогрессии: ");
        //double PR_b = double.Parse(Console.ReadLine());
        //double pr1;

        //for (int i = 0; i < limit; i++)
        //{
        //    pr1 = PR_a *= PR_b;

        //    Console.WriteLine(Math.Pow(-1,limit)*pr1 - 8);
        //}
        ///8


        //double PR_a = -1;
        //double PR_a2 = 1;
        //Console.Write("Лимит геометрической прогрессии: ");
        //double limit = double.Parse(Console.ReadLine());

        //Console.Write("Разность прогрессии: ");
        //double PR_b = double.Parse(Console.ReadLine());
        //double pr1;

        //for (int i = 0; i < limit; i++)
        //{
        //    pr1 = PR_a *= PR_b;

        //    Console.WriteLine((3 * pr1 - PR_a) - (2*pr1/PR_b));
        //}
        ///9

        //double PR_a = -10;
        //double PR_a2 = 2;
        //Console.Write("Лимит геометрической прогрессии: ");
        //double limit = double.Parse(Console.ReadLine());

        //Console.Write("Разность прогрессии: ");
        //double PR_b = double.Parse(Console.ReadLine());
        //double pr1;

        //for (int i = 0; i < limit; i++)
        //{
        //    pr1 = PR_a *= PR_b;

        //    Console.WriteLine((Math.Abs(pr1/(PR_b*2)) - (6 * pr1));
        //}
        ///10

        //double PR_a = 2;
        //double PR_a2 = 4;
        //Console.Write("Лимит геометрической прогрессии: ");
        //double limit = double.Parse(Console.ReadLine());

        //Console.Write("Разность прогрессии: ");
        //double PR_b = double.Parse(Console.ReadLine());
        //double pr1;

        //for (int i = 0; i < limit; i++)
        //{
        //    pr1 = PR_a *= PR_b;

        //    Console.WriteLine(6*pr1-PR_a2);
        //}

        ///11

        //Console.Write("Начальное число прогрессии: ");
        //double PR_a = double.Parse(Console.ReadLine());

        //Console.Write("Лимит геометрической прогрессии: ");
        //double limit = double.Parse(Console.ReadLine());

        //Console.Write("Разность прогрессии: ");
        //double PR_b = double.Parse(Console.ReadLine());
        //double pr1;

        //for (int i = 0; i < limit; i++)
        //{
        //    pr1 = PR_a *= PR_b;

        //    Console.WriteLine(pr1/Math.Pow(limit,2)+ limit + 1);
        //}
        ///12

        //double PR_a = 0.5;
        //double PR_a2 = 0.2;

        //Console.Write("Лимит геометрической прогрессии: ");
        //double limit = double.Parse(Console.ReadLine());

        //Console.Write("Разность прогрессии: ");
        //double PR_b = double.Parse(Console.ReadLine());
        //double pr1;

        //for (int i = 0; i <= limit; i++)
        //{
        //    pr1 = PR_a *= PR_b;

        //    Console.WriteLine(Math.Pow(pr1,2)+(pr1/PR_b) / limit  );
        //}
        ///13

        //double PR_a = 1;
        //Console.Write("Лимит геометрической прогрессии: ");
        //double limit = double.Parse(Console.ReadLine());

        //Console.Write("Разность прогрессии: ");
        //double PR_b = double.Parse(Console.ReadLine());
        //double pr1;

        //for (int i = 0; i < limit; i++)
        //{
        //    pr1 = PR_a *= PR_b;

        //    Console.WriteLine(0.25*(3*pr1 + 1/(3*pr1)));
        //}
        

    }
}
