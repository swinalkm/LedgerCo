using geektrust_family_demo;
using System;

namespace LedgerCo.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@" PLEASE ENTER TEST FILE PATH --> example as: C:\Users\abc\Desktop\demo\geektrust_family_demo\test.txt");
            var inputFilePath = Console.ReadLine();
            var data = InputReader.ReadData(inputFilePath);
            Calculator.CalculateBalance(data);
            Console.ReadKey();
        }
    }
}
