using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareTriplets
{
    class Solution
    {
        static int alice = 0;
        static int bob = 0;

        public static void Comparison(int a, int b)
        {
            if (a > b)
            {
                alice++;
            }
            else if (b > a)
            {
                bob++;
            }
        }

        static void Main(String[] args)
        {
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);

            Comparison(a0, b0);
            Comparison(a1, b1);
            Comparison(a2, b2);

            Console.WriteLine($"{alice} {bob}");
        }
    }
}

