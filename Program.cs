using System;

namespace MyApp
{
    public class Calculator
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            Console.WriteLine($"3 + 4 = {calc.Add(3,4)}");
            Console.WriteLine($"7 - 2 = {calc.Subtract(7,1)}");
        }
    }
}
