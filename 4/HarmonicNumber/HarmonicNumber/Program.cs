using System;

namespace HarmonicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int count, userValue;
            Console.WriteLine("Enter Value Of N:");
            userValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(userValue);
            for (count = 1; count <= userValue; count++)
            {
                Console.Write("1/{0} + ", count);
            }
        }
    }
}
