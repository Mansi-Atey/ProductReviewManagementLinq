using System;

namespace LinqToDataTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to Data Table demo");
            LinqToDataTable linqToDataTable = new LinqToDataTable();
            linqToDataTable.AddToDataTableDemo();
            Console.ReadKey();

        }
    }
}
