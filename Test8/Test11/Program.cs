using System;

namespace Test8;

class Program
{
    static void Main(string[] args)
    {
        ///1
        //bool Password;
        //string pasWor = "qwerty";
        //string endPasWod = Console.ReadLine();
        //Password = pasWor == endPasWod ? true : false;
        //Console.WriteLine(Password);
        ///2

        int inputData = int.Parse(Console.ReadLine());
        int outData = inputData < 0 ? 0 : inputData;
        Console.WriteLine(outData);
        
    }
}
