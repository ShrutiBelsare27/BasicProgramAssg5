using System;

namespace SwapTwoNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 26, b = 25;
            Console.WriteLine("Before swap a= " + a + " b= " + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.Write("After swap a= " + a + " b= " + b);
        }
    }
}
