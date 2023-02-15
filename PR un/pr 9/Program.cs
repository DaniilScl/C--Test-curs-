using System;


namespace Lesson;
class Program
{
    static void Main()
    {

        ///16
        //for (int i = 0; i < 8; i++)
        //{
        //    for (int j = 0; j <= i / 2; j++)
        //        Console.Write(8 - (i + 1) / 2);

        //    Console.WriteLine();
        //}

        //int i = 0;
        //while(i < 8)
        //{
        //    i++;
        //    for (int j = 0; j <= i / 2; j++)
        //        Console.Write(8 - (i + 1) / 2);

        //    Console.WriteLine();
        //}

        //int i = 0;
        //do
        //{
        //    i++;
        //    for (int j = 0; j <= i / 2; j++)
        //        Console.Write(8 - (i + 1) / 2);

        //    Console.WriteLine();
        //} while (i < 8);


        ///15

        //for (int i = 1, j = 0; i < 6; i++)
        //{
        //    for (int k = 0; k < i; k++)
        //        Console.Write(i);
        //    Console.WriteLine();
        //    for (int k = 0; k < i; k++)
        //        Console.Write(j);
        //    Console.WriteLine();
        //}

        //int i = 1, j = 0;
        //while(i < 6) 
        //{
        //    i++;
        //    for (int k = 0; k <= i; k++)
        //        Console.Write(i);
        //    Console.WriteLine();
        //    for (int k = 0; k <= i; k++)
        //        Console.Write(j);
        //    Console.WriteLine();
        //}

        //int i = 1, j = 0;
        //do
        //{
        //    i++;
        //    for (int k = 0; k <= i; k++)
        //        Console.Write(i);
        //    Console.WriteLine();
        //    for (int k = 0; k <= i; k++)
        //        Console.Write(j);
        //    Console.WriteLine();
        //} while (i < 6);

        ///17

        //for (int i = 0, j = 0; i < 8; i++, j++)
        //{
        //    for (int k = 0; k < i; k++)
        //        Console.Write(j);
        //    Console.WriteLine();
        //    for (int k = 0; k < i; k++)
        //        Console.Write(i + 5);
        //    Console.WriteLine();
        //}


        //int i = 0, j = 0;
        //while (i < 8)
        //{
        //    i++;
        //    j++;
        //    for (int k = 0; k < i; k++)
        //        Console.Write(j);
        //    Console.WriteLine();
        //    for (int k = 0; k < i; k++)
        //        Console.Write(i + 5);
        //    Console.WriteLine();
        //}


        //int i = 0, j = 0;
        //do
        //{
        //    i++;
        //    j++;
        //    for (int k = 0; k < i; k++)
        //        Console.Write(j);
        //    Console.WriteLine();
        //    for (int k = 0; k < i; k++)
        //        Console.Write(i + 5);
        //    Console.WriteLine();
        //} while (i < 8);

        ///5

        //    int i = 1;
        //    Console.WriteLine("Оператор for");
        //    for (i = 1; i < 6; i++)
        //    {
        //        write_numbers(i);
        //    }
        //    Console.WriteLine("Оператор while");
        //    i = 1;
        //    while (i < 6)
        //    {
        //        write_numbers(i);
        //        i++;
        //    }
        //    Console.WriteLine("Оператор do");
        //    i = 1;
        //    do
        //    {
        //        write_numbers(i);
        //        i++;
        //    } while (i < 6);
        //    Console.ReadLine();
        //}

        //static void write_numbers(int i)
        //{
        //    switch (i)
        //    {
        //        case 1:
        //            Console.WriteLine(i);
        //            break;
        //        case 2:
        //            Console.WriteLine("{0}{1}", i - 1, i);
        //            break;
        //        case 3:
        //            Console.WriteLine("{0}{1}{2}", i - 2, i - 1, i);
        //            break;
        //        case 4:
        //            Console.WriteLine("{0}{1}{2}{3}", i - 3, i - 2, i - 1, i);
        //            break;
        //        case 5:
        //            Console.WriteLine("{0}{1}{2}{3}{4}", i - 4, i - 3, i - 2, i - 1, i);
        //            break;
        //        default:
        //            break;
        //    }

        ///6
        int n = 5;
        for (int i = 0; i < 5; i++)
        {
            for (int j = i; j < n; j++)
                Console.Write(1);
            Console.WriteLine();
        }
        Console.ReadLine();

        //int n = 6;
        //int i = 0;
        //while(i <= n) 
        //{
        //    i++;
        //    for (int j = i; j < n; j++)
        //        Console.Write(1);
        //    Console.WriteLine();
        //}

        //int n = 6;
        //int i = 0;
        //do
        //{
        //    i++;
        //    for (int j = i; j < n; j++)
        //        Console.Write(1);
        //    Console.WriteLine();
        //} while (i <= n);

        ///14

        //int n = 4;
        //while (n >= 0)
        //{
        //    for (int i = n; i >= 0; i--)
        //        Console.Write(i.ToString() + " ");
        //    n--;
        //    Console.WriteLine("");
        //}
        //Console.ReadKey();

        //int n = 4;
        //do
        //{
        //    for (int i = n; i >= 0; i--)
        //        Console.Write(i.ToString() + " ");
        //    n--;
        //    Console.WriteLine("");
        //} while (n >= 0);

        //for (int n = 4; n >= 0; n--)
        //{
        //    for (int i = n; i >= 0; i--)
        //        Console.Write(i.ToString() + " ");
        //    Console.WriteLine("");
        //}

        ///11

        //for (int i = 1; i <= 5; ++i)
        //{

        //    for (int j = 1; j <= i; ++j)
        //    {

        //        Console.Write(j);
        //    }
        //    Console.WriteLine();
        //}

        //int i = 1;
        //while (i <= 5)
        //{
        //    ++i
        //    for (int j = 1; j <= i; ++j)
        //    {

        //        Console.Write(j);
        //    }
        //    Console.WriteLine();
        //}

        //int i = 1;
        //do
        //{
        //    ++i
        //    for (int j = 1; j <= i; ++j)
        //    {

        //        Console.Write(j);
        //    }
        //    Console.WriteLine();
        //} while (i <= 5);

        ///2


        //for (int i = 1; i <= 10; ++i)
        //{
        //    for (int j = 1; j <= 10; ++j)
        //    {
        //        Console.Write(j + " ");
        //    }
        //    Console.WriteLine();
        //}

        //int i = 1;
        //while (i <= 10)
        //{
        //    ++i
        //    for (int j = 1; j <= 10; ++j)
        //    {
        //        Console.Write(j);
        //    }
        //    Console.WriteLine();
        //}

        //int i = 1;
        //do
        //{
        //    ++i
        //    for (int j = 1; j <= 10; ++j)
        //    {
        //        Console.Write(j);
        //    }
        //    Console.WriteLine();

        //} while (i <= 10);


        ///7
        //for (int i = 1; i <= 5; i++)
        //{
        //    Console.WriteLine();
        //    for (int j = 1; j <= i; j++)
        //        Console.Write(i + " ");
        //}


        //int i = 1;
        //while (i <= 5)
        //{
        //    i++;
        //    Console.WriteLine();
        //    for (int j = 1; j <= i; j++)
        //        Console.Write(i + " ");
        //}

        //int i = 1;
        //do
        //{
        //    i++;
        //    Console.WriteLine();
        //    for (int j = 1; j <= i; j++)
        //        Console.Write(i + " ");
        //} while (i <= 5);



    }
}

