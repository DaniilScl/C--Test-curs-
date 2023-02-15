using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Transactions;

namespace Lesson;
class Program
{
    static void Main(string[] args)
    {
        ///1
        //Console.WriteLine("Конец введите диапазон ");
        //double B = double.Parse(Console.ReadLine());

        //Console.WriteLine("Начала введите диапазон ");
        //double A = double.Parse(Console.ReadLine());

        //while (B > A || B == A)
        //{

        //    double Cumm = Math.Pow(B, 3);
        //    Console.Write("Число {0} в кубе {1}\n", B, Cumm);
        //    B--;
        //}

        //do
        //{
        //    double Cumm = Math.Pow(B, 3);
        //    Console.Write("Число {0} в кубе {1}\n", B, Cumm);
        //    B--;
        //} while (B > A || B == A);

        //for(; B < A; B--) 
        //{
        //    double Cumm = Math.Pow(B, 3);
        //    Console.Write("Число {0} в кубе {1}\n", B, Cumm);
        //}


        ///2

        //Console.WriteLine("Конец введите диапазон ");
        //double B = double.Parse(Console.ReadLine());

        //Console.WriteLine("Начала введите диапазон ");
        //double A = double.Parse(Console.ReadLine());

        //Console.WriteLine("На что оканчивается число ");
        //double X = double.Parse(Console.ReadLine());

        //while (B > A || B == A)
        //{
        //    if (A % 10 == X)
        //    {
        //        Console.WriteLine(B);
        //    }
        //    A++;
        //}

        //do
        //{
        //    if (A % 10 == X)
        //    {
        //        Console.WriteLine(B);
        //    }
        //    A++;
        //} while (B > A || B == A);

        //for (; B> A; A++)
        //{
        //    if (A % 10 == X)
        //    {
        //        Console.WriteLine(B);
        //    }
        //}


        ///3

        //Console.WriteLine("Конец введите диапазон ");
        //double B = double.Parse(Console.ReadLine());

        //Console.WriteLine("Начала введите диапазон ");
        //double A = double.Parse(Console.ReadLine());

        //Console.WriteLine("На что оканчивается число ");
        //double X = double.Parse(Console.ReadLine());

        //Console.WriteLine("Ещё на какое число может ");
        //double Y = double.Parse(Console.ReadLine());

        //while (B > A || B == A)
        //{
        //    if (A % 10 == X || A % 10 == Y)
        //    {
        //        Console.WriteLine(A);
        //    }
        //    A++;
        //}

        //do
        //{
        //    if (A % 10 == X || A % 10 == Y)
        //    {
        //        Console.WriteLine(A);
        //    }
        //    A++;
        //} while (B > A || B == A);

        //for (; B > A; A++)
        //{
        //    if (A % 10 == X || A % 10 == Y)
        //    {
        //        Console.WriteLine(A);
        //    }
        //}

        ///4

        //Console.WriteLine("Конец введите диапазон ");
        //double B = double.Parse(Console.ReadLine());

        //Console.WriteLine("Начала введите диапазон ");
        //double A = double.Parse(Console.ReadLine());

        //while (B > A || B == A)
        //{
        //    if (A % 2 == 0)
        //    {

        //        Console.Write("Число {0}\n", A);
        //    }
        //    A++;
        //}
        //do
        //{
        //    if (A % 2 == 0)
        //    {

        //        Console.Write("Число {0}\n", A);
        //    }
        //    A++;
        //} while (B > A || B == A);

        //for (; B > A; A++)
        //{
        //    if (A % 2 == 0)
        //    {

        //        Console.Write("Число {0}\n", A);
        //    }
        //}




        ///5

        //Console.WriteLine("Начала введите диапазон ");
        //double A = double.Parse(Console.ReadLine());
        //Console.WriteLine("Конец введите диапазон ");
        //double B = double.Parse(Console.ReadLine());
        //while (A <= B)
        //{
        //    if (A > 0)
        //    {

        //        Console.Write("Число {0}\n", A);
        //    }
        //    A++;
        //}

        //do
        //{
        //    if (A > 0)
        //    {
        //        Console.Write("Число {0}\n", A);
        //    }
        //    A++;

        //} while (A <= B);


        //for (; A <= B; A++)
        //{
        //    if (A > 0)
        //    {

        //        Console.Write("Число {0}\n", A);
        //    }
        //}

        ///6

        //Console.WriteLine("Конец введите диапазон ");
        //double B = double.Parse(Console.ReadLine());

        //Console.WriteLine("Начала введите диапазон ");
        //double A = double.Parse(Console.ReadLine());

        //while (A <= B)
        //{
        //    if (A % 3 == 0)
        //    {
        //        Console.Write("Число {0}\n", A);
        //    }
        //    A++;
        //}

        //do
        //{
        //    if (A % 3 == 0)
        //    {
        //        Console.Write("Число {0}\n", A);
        //    }
        //    A++;

        //} while (A <= B);

        //for (; A <= B; A++)
        //{
        //    if (A % 3 == 0)
        //    {
        //        Console.Write("Число {0}\n", A);
        //    }
        //    A++;
        //}

        ///7

        //Console.WriteLine("Конец введите диапазон ");
        //double B = double.Parse(Console.ReadLine());

        //Console.WriteLine("Начала введите диапазон ");
        //double A = double.Parse(Console.ReadLine());

        //while (A <= B)
        //{
        //    if (A % 2 == 0)
        //    {
        //        Console.Write("Число {0}\n", A);
        //    }
        //    A++;
        //}

        //do
        //{
        //    if (A % 2 == 0)
        //    {
        //        Console.Write("Число {0}\n", A);
        //    }
        //    A++;
        //} while (A <= B);


        //for (; A <= B; A++)
        //{
        //    if (A % 2 == 0)
        //    {
        //        Console.Write("Число {0}\n", A);
        //    }
        //}


        ///8

        //Console.WriteLine("Конец введите диапазон ");
        //double B = double.Parse(Console.ReadLine());

        //Console.WriteLine("Начала введите диапазон ");
        //double A = double.Parse(Console.ReadLine());

        //while (A <= B)
        //{
        //    if (A % 2 == 0)
        //    {
        //        if (A < 0)
        //        {
        //            Console.Write("Число {0}\n", A);
        //        }

        //    }
        //    A++;
        //}

        //do
        //{
        //    if (A % 2 == 0)
        //    {
        //        if (A < 0)
        //        {
        //            Console.Write("Число {0}\n", A);
        //        }

        //    }
        //    A++;

        //} while(A <= B);

        //for (; A < 0; A++)
        //{
        //    if (A % 2==0)
        //    {
        //        Console.Write("Число {0}\n", A);
        //    }
        //}




        ///9
        //    Console.WriteLine("Введите  A");
        //    float a = Convert.ToSingle(Console.ReadLine());
        //    Console.WriteLine("Введите B");
        //    float b = Convert.ToSingle(Console.ReadLine());
        //    Console.WriteLine("Цикл for");
        //    for (float i = a; i <= b; i++)
        //    {
        //        float z1 = i % 10;
        //        float r1 = (i - z1) / 10;
        //        float r2 = r1 % 10;
        //        if (z1 > r2 || z1 < r2)
        //        {
        //            Console.Write("; " + i);
        //        }
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine("Цикл while");
        //    float i2 = a;
        //    while (i2 <= b)
        //    {
        //        float z1 = i2 % 10;
        //        float r1 = (i2 - z1) / 10;
        //        float r2 = r1 % 10;
        //        if (z1 > r2 || z1 < r2)
        //        {
        //            Console.Write(i2 + "; ");
        //        }
        //        i2++;
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine("Цикл do while");
        //    float i3 = a;
        //    do
        //    {
        //        float z1 = i3 % 10;
        //        float r1 = (i3 - z1) / 10;
        //        float r2 = r1 % 10;

        //        if (z1 > r2 || z1 < r2)
        //        {
        //            Console.Write(i3 + "; ");

        //        }
        //        i3++;
        //    } while (i3 <= b);
        //    Console.ReadKey();

        ///10

        //Console.Write("n=");
        //byte n = byte.Parse(Console.ReadLine());

        //Console.Write("while: ");
        //int i = 1;
        //while (i <= n)
        //{
        //    Console.Write(" " + i);
        //    i += 2;
        //}

        //Console.Write("do while: ");
        //i = 1;
        //do
        //{
        //    Console.Write(" " + i);
        //    i += 2;
        //}
        //while (i <= n);

        //Console.Write("For: ");
        //for (i = 1; i <= n; i += 2)
        //{
        //    Console.Write(" " + i);
        //}


        ///10

        //int i = 101;
        //while (i < 1000)
        //{
        //    if (i % 10 == i / 100)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    i++;
        //}

        //i = 101;
        //do
        //{
        //    if (i % 10 == i / 100)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    i++;
        //}
        //while (i < 1000);

        //for (; i < 1000; i++)
        //{
        //    if (i % 10 == i / 100)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

    }
}

