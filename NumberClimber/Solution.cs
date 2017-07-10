using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumberClimber
{
    //NOT DONE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    public class Kata
    {
        public static int[] Climb(int n)
        {
            var arr = new int[] { };
            for (int i = n; i > 2; i--)
            {
                arr += (n / 2);
            }
            if (1 < n <= 2)
            {
                arr += (n - 1);
            }
            int[] answer = [].Reverse;
            return answer;
        }

            //alt approach
        public static int[] Climbing(int n)
        {
            List<int> rv = new List<int>();
            if (n % 2 == 0)
            {
                rv.Add(n * 2);
            }
            else
            {
                while (n == 1)
                {
                    rv.Add(1);
                }

                rv.Add(n * 2);
            }
            int[] answer = rv.ToArray();
            return answer;
        }


        //alt approach
        public static int[] Climber(int n)
        {
            int num = 0;
            List<int> rv = new List<int>();
            while (num < n)
            {
                for (int i = 1; i < n; i++)
                {
                    if (n % 2 == 0)
                    {
                        rv.Add(num += 1);
                    }
                    
                }
            }

        }

    //For every positive integer N, there exists a unique sequence starting with 1 and ending with N and such that every number in the sequence is either the double of the preceeding number or the double plus 1.
    //For example, given N = 13, the sequence is [1, 3, 6, 13], because. . . :

    // 3 =  2*1 +1
    // 6 =  2*3
    // 13 = 2*6 +1

    //Write a function that returns this sequence given a number N.Try generating the elements of the resulting list in ascending order, i.e., without resorting to a list reversal or prependig the elements to a list.

}