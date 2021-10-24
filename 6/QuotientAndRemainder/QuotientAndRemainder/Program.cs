using System;

namespace QuotientAndRemainder
{
    class Program
    {
		static void Main(string[] args)
		{
			int x, y, quoient, remainder;
			Console.Write("Enter first number:");
			x = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter second number:");
			y = Convert.ToInt32(Console.ReadLine());

			quoient = x / y;
			remainder = x % y;

			Console.WriteLine("Quotient is:" + quoient);
			Console.WriteLine("Remainder is:" + remainder);
		}
    }
}
