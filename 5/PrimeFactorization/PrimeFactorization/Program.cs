using System;

namespace PrimeFactorization
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, num, isPrime;
            Console.Write("Input the number : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = 1;
                    for (j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = 0;
                            break;
                        }
                    }
                    if (isPrime == 1)
                    {
                        Console.WriteLine(i);
                    }
                }

            }
        }
    }
}
