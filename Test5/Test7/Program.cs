using System;

namespace Test7
{
    class Programs
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.ResetColor();
                Console.WriteLine("\t\t\t\t\t\t\tКАЛЬКУЛЯТОР");
                Console.WriteLine("Выберите операцию:\n");
                
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1. Умножение\n" + "2. Деление\n" + "3. Сложение\n" + "4. Вычитание");

                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("5. Выход\n");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                try
                {
                    string a = Console.ReadLine();
                    double b = double.Parse(a);
                    if (b < 5)
                    {
                        switch (a)
                        {
                            case "1":

                                Console.WriteLine("Введите 1 число");
                                double number_a = double.Parse(Console.ReadLine());
                                Console.WriteLine("Введите 2 число");
                                double number_b = double.Parse(Console.ReadLine());
                                double Answer1 = number_a * number_b;
                                Console.WriteLine("Ответ: {0} ", Answer1);
                                Console.ReadLine();
                                break;

                            case "2":
                                Console.WriteLine("Введите 1 число");
                                double number_a1 = double.Parse(Console.ReadLine());
                                Console.WriteLine("Введите 2 число");
                                double number_b1 = double.Parse(Console.ReadLine());
                                if (number_b1 == 0)
                                {
                                    Console.ResetColor();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("На 0 делить нельзя!!\n");
                                    Console.ResetColor();
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.ReadLine();
                                }
                                else
                                {
                                    double Answer1_1 = number_a1 / number_b1;
                                    Console.WriteLine("Ответ: {0} ", Answer1_1);
                                    Console.ReadLine();
                                }
                                break;

                            case "3":
                                Console.WriteLine("Введите 1 число");
                                double number_a2 = double.Parse(Console.ReadLine());
                                Console.WriteLine("Введите 2 число");
                                double number_b2 = double.Parse(Console.ReadLine());
                                double Answer1_2 = number_a2 + number_b2;
                                Console.WriteLine("Ответ: {0} ", Answer1_2);
                                Console.ReadLine();
                                break;

                            case "4":
                                Console.WriteLine("Введите 1 число");
                                double number_a3 = double.Parse(Console.ReadLine());
                                Console.WriteLine("Введите 2 число");
                                double number_b3 = double.Parse(Console.ReadLine());
                                double Answer1_3 = number_a3 - number_b3;
                                Console.WriteLine("Ответ: {0} ", Answer1_3);
                                Console.ReadLine();
                                break;

                            default:
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Нет такого пункта!!\n");
                                Console.ResetColor();
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.ReadLine();
                                break;
                        }
                    }
                    else if (b == 5)
                    {
                        Console.WriteLine("Досвидани!");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Нет такого пункта!!\n");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.ReadLine();
                    }
                }
                catch (Exception)
                {
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вводите числа!");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.ReadLine();
                    
                }
            }
        }
    }
}
