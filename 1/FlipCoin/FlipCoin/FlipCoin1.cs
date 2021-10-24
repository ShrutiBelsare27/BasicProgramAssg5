using System;
using System.Collections.Generic;
using System.Text;

namespace FlipCoin
{
    public class FlipCoin1
    {
        public Random random = new Random();
        public double Num;
        public double Head = 0;
        public double Tail = 0;
        public double HeadPercentage = 0;
        public double TailPercentage = 0;
        public int Count = 1;

        public void flipCoin()
        {
            Console.WriteLine("Enter the number of flips Num ");
            Num = Convert.ToInt32(Console.ReadLine());

            while (Count <= Num)
            {
                int flipCheck = random.Next(0, 2);
                if (flipCheck == 1)
                {
                    Console.WriteLine("flip " + Count + " is Head");
                    Head++;
                }
                else
                {
                    Console.WriteLine("flip " + Count + " is Tail");
                    Tail++;
                }
                Count++;
            }
            Console.WriteLine("Number of times Head received is : " + Head);
            Console.WriteLine("Number of times Tail received is : " + Tail);
            HeadPercentage = 100 * Head / Num;
            TailPercentage = 100 * Tail / Num;
            Console.WriteLine("Head Percentage is: " + HeadPercentage);
            Console.WriteLine("Tail Percentage is: " + Tail);

        }

    }
}
