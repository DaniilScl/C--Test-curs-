using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Lesson;


    class Program
    {
        static void Main(string[] args)
        {


        ///1
        //int evenNum = int.Parse(Console.ReadLine());
        //int limit = int.Parse(Console.ReadLine());

        //while (evenNum <= limit)
        //{

        //    if (evenNum % 2 != 0)
        //    {
        //        Console.WriteLine(evenNum);
        //    }

        //    evenNum++;
        //}

        //do
        //{
        //    if (evenNum % 2 != 0)
        //    {
        //        Console.WriteLine(evenNum);
        //    }

        //    evenNum++;
        //} while (evenNum <= limit);

        //for (; evenNum <= limit; evenNum++)
        //{
        //    if (evenNum % 2 != 0)
        //    {
        //        Console.WriteLine(evenNum);
        //    }
        //}


        ///2
        //int evenNum = int.Parse(Console.ReadLine());
        //int limit = int.Parse(Console.ReadLine());


        //while (limit <= evenNum)
        //{

        //    if (evenNum % 2 == 0)
        //    {
        //        Console.WriteLine(evenNum);
        //    }

        //    evenNum--;
        //}

        //do
        //{
        //    if (evenNum % 2 == 0)
        //    {
        //        Console.WriteLine(evenNum);
        //    }

        //    evenNum--;
        //} while (limit <= evenNum);

        //for (; limit <= evenNum; evenNum--)
        //{
        //    if (evenNum % 2 == 0)
        //    {
        //        Console.WriteLine(evenNum);
        //    }
        //}



        ///3
        //double a = double.Parse(Console.ReadLine());
        //double b = double.Parse(Console.ReadLine());

        //while (b <= 25.4)
        //{
        //    Console.WriteLine("{0} {1}", a, b);
        //    b++;
        //    a++;
        //}

        //do
        //{
        //    Console.WriteLine("{0} {1}", a, b);
        //    b++;
        //    a++;
        //} while (b <= 25.4);



        //for (; b <= 25.4; b++, a++)
        //{

        //    Console.WriteLine("{0} {1}", a, b);

        //}

        ///4
        //double a = double.Parse(Console.ReadLine());
        //double b = double.Parse(Console.ReadLine());
        //double c = double.Parse(Console.ReadLine());


        //for (; b <= 35.5; b++, a++, c++)
        //{

        //    Console.WriteLine("{0} {1} {2}", a, b, c);

        //}

        //while (b <= 35.5)
        //{
        //    Console.WriteLine("{0} {1} {2}", a, b, c);
        //    b++;
        //    c++;
        //    a++;
        //}

        //do
        //{
        //    Console.WriteLine("{0} {1} {2}", a, b, c);
        //    b++;
        //    c++;
        //    a++;
        //} while (b <= 35.5);


        ///5
        //int evenNum = int.Parse(Console.ReadLine());
        //int limit = int.Parse(Console.ReadLine());

        //while (evenNum < limit)

        //{
        //    evenNum++;
        //    int funt = evenNum * 453;
        //    Console.WriteLine("{0} Фунт = {1} г", evenNum, funt);
        //}
        //Console.ReadLine();

        //do
        //{
        //    evenNum++;
        //    int funt = evenNum * 453;
        //    Console.WriteLine("{0} Фунт = {1} г", evenNum, funt);
        //    
        //} while (evenNum < limit);

        //for (; evenNum < limit; evenNum++)
        //{
        //    int funt = evenNum * 453;
        //    Console.WriteLine("{0} Фунт = {1} г", evenNum, funt);

        //}


        ///6


        //int evenNum = int.Parse(Console.ReadLine());
        //int limit = int.Parse(Console.ReadLine());
        //Console.WriteLine("Введите курс рубля");
        //double a = double.Parse(Console.ReadLine());

        //while (evenNum <= limit)
        //{
        //    if (evenNum % 5 == 0)
        //    {
        //        double b = a * evenNum;
        //        Console.WriteLine("столько {0} долларов в рубли это {1} рублей  ", evenNum, b);
        //    }
        //    evenNum++;
        //}

        //do
        //{
        //    if (evenNum % 5 == 0)
        //    {
        //        double b = a * evenNum;
        //        Console.WriteLine("столько {0} долларов в рубли это {1} рублей  ", evenNum, b);
        //    }
        //    evenNum++;
        //} while (evenNum <= limit);

        //for(; evenNum < limit; evenNum++)
        //{
        //    if (evenNum % 5 == 0)
        //    {
        //        double b = a * evenNum;
        //        Console.WriteLine("столько {0} долларов в рубли это {1} рублей  ", evenNum, b);
        //    }
        //}

        ///7

        //int evenNum = int.Parse(Console.ReadLine());
        //int limit = int.Parse(Console.ReadLine());
        //Console.WriteLine("Введите стоимость товара");
        //double a = double.Parse(Console.ReadLine());

        //while (evenNum <= limit)
        //{
        //    if (evenNum % 10 == 0)
        //    {
        //        double b = a * evenNum;
        //        Console.WriteLine("Колличество {0}, Цена {1} ", evenNum, b);
        //    }
        //    evenNum++;
        //}

        //do
        //{
        //    if (evenNum % 10 == 0)
        //    {
        //        double b = a * evenNum;
        //        Console.WriteLine("Колличество {0}, Цена {1} ", evenNum, b);
        //    }
        //    evenNum++;
        //} while (evenNum <= limit);

        //for (; evenNum <= limit; evenNum++)
        //{
        //    if (evenNum % 10 == 0)
        //    {
        //        double b = a * evenNum;
        //        Console.WriteLine("Колличество {0}, Цена {1} ", evenNum, b);
        //    }
        //}


        ///8

        //Console.WriteLine("Начала лимита см");
        //int evenNum = int.Parse(Console.ReadLine());
        //Console.WriteLine("Конец лимита см");
        //int limit = int.Parse(Console.ReadLine());

        //double a = 0.39;

        //while (evenNum <= limit)
        //{
        //    if (evenNum % 2 == 0)
        //    {
        //        double b = a * evenNum;
        //        Console.WriteLine("сантиметро {0}см, дюймов {1}д ", evenNum, b);
        //    }
        //    evenNum++;
        //}

        //do
        //{
        //    if (evenNum % 2 == 0)
        //    {
        //        double b = a * evenNum;
        //        Console.WriteLine("сантиметро {0}см, дюймов {1}д ", evenNum, b);
        //    }
        //    evenNum++;
        //} while(evenNum <= limit);

        //for (; evenNum< limit; evenNum++)
        //{
        //    if (evenNum % 2 == 0)
        //    {
        //        double b = a * evenNum;
        //        Console.WriteLine("сантиметро {0}см, дюймов {1}д ", evenNum, b);
        //    }
        //}


    }
}
    

