using System;
namespace Lesson;
class Program
{
    static void Main(string[] args)
    {
        
        Test2();
    }

    private static void Test()
    {


        Console.Write("Что бы выйти напишите exit, а для продолжения action: ");
        string exit = Console.ReadLine();
        switch (exit)
        {
            case "exit":
                Console.WriteLine("Завершения работы!");
                break;

            case "action":
                for (int i = 0; ; i++)
                {

                    try
                    {
                        Console.Clear();
                        Console.Write(" | " + "Введите А: ");
                        double a = double.Parse(Console.ReadLine());
                        Console.Write(" | " + "Введите B: ");
                        double b = double.Parse(Console.ReadLine());

                        Console.Write(" | " + "Введите действие (Пример \"^\" ): ");
                        char Simbol = char.Parse(Console.ReadLine());

                        double[] myArray;
                        myArray = new double[5];

                        if (Simbol == '+')
                        {
                            myArray[0] = a + b;
                            Console.WriteLine("| Сложение = {0}", myArray[0]);
                        }
                        else if (Simbol == '-')
                        {
                            myArray[4] = a - b;
                            Console.WriteLine("| Разность = {0}", myArray[4]);
                        }
                        else if (Simbol == '*')
                        {
                            myArray[1] = a * b;
                            Console.WriteLine("| Умножение = {0}", myArray[1]);
                        }
                        else if (Simbol == '/')
                        {
                            myArray[2] = a / b;
                            Console.WriteLine("| Деление = {0}", myArray[2]);
                        }
                        else if (Simbol == '^')
                        {
                            myArray[3] = Math.Pow(a, b);
                            Console.WriteLine("| Деление = {0}", myArray[3]);
                        }
                        else
                        {
                            Console.WriteLine("ОШИБКА!");
                        }

                        Console.ReadLine();
                    }
                    catch
                    {
                        Console.WriteLine("ОШИБКА!");
                    }

                }
            default:
                Console.WriteLine("Нет такого действия!");
                break;




        }

    } 

    private static void Test2()
    {

        double n = double.Parse(Console.ReadLine());

        double[] myArarei = new double[10] {n,1,2,3,4,5,6,7,8,9}; 
        double[] myBrarei = new double[10] {n,9,8,7,6,5,4,3,2,1};

        for (int i = 0; i < myArarei.Length;i++)
        {
            Console.Write(myBrarei[i]);
            Console.Write(myArarei[i]);
        }
       
        
    }

    private static void Test3()
    {
        int x = int.Parse(Console.ReadLine());
        string str = x.ToString() + 5;
        Console.WriteLine(str);
    }

    private static void dz()
    {

        Console.Write("Введите количество массивов: ");
        int eliment = int.Parse(Console.ReadLine());
        int[] myArray = new int[eliment];

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write($"Введите элемент массива {i}: ");
            myArray[i] = int.Parse(Console.ReadLine());
        }

       

        Console.WriteLine("Вывод!");
       
 
        for (int i = myArray.Length - 1; 0 <= i; i--)
        {
            Console.WriteLine("{0} ", myArray[i]);
        }


        Console.ReadLine();
    }

    private static void dz1() 
    {

        Console.Write("Введите количество массивов: ");
        int eliment = int.Parse(Console.ReadLine());
        int[] myArray = new int[eliment];


        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write($"Введите элемент массива {i}: ");
            myArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Вывод!");
        for (int i = 0; i <= myArray.Length ; i++)
        {
            Console.WriteLine("{0} ", myArray[i]);
        }

        

        

    }

    private static void dz2()
    {
      

        Console.Write("Введите количество массивов: ");
        int eliment = int.Parse(Console.ReadLine());
        int[] myArray = new int[eliment];
        int cum = 0;


        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write($"Введите элемент массива {i}: ");
            myArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Вывод!");
        for (int i = 0; i < myArray.Length; i++)
        {

            if (myArray[i] % 2 == 0)
            {
                cum += myArray[i];
            }
        }
        Console.WriteLine(cum);
    }

    private static void dz3()
    {
        Console.Write("Введите количество массивов: ");
        int eliment = int.Parse(Console.ReadLine());
        int[] myArray = new int[eliment];
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write($"Введите элемент массива {i}: ");
            myArray[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Вывод минимального и максимально элемента");
        Console.WriteLine("Минимальный = "+ myArray.Min());
        Console.WriteLine("Максимальный = "+ myArray.Max());
    }
}
