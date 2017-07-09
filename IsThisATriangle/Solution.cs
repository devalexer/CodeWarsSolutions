using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IsThisATriangle
{

    public class Triangle2
    {
        public static bool IsATriangle(int a, int b, int c)
        {
            var max = new int[] { a, b, c }.Max();
            var sum = a + b + c;
            if (sum - max > max)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

//Implement a method that accepts 3 integer values a, b, c. The method should return true if a triangle can be built with the sides of given length and false in any other case.
//(In this case, all triangles must have surface greater than 0 to be accepted).

    //public class Triangle
    //{
    //    public static bool IsTriangle(int a, int b, int c)
    //    {
    //        while (a * b * c >= 0)
    //        {
    //            if (Math.Pow(a, 2) + Math.Pow(b, 2) >= Math.Pow(c, 2))
    //            {
    //                return true;
    //            }
    //            else
    //            {
    //                return false;
    //            }
    //        }
    //    }
    //}
}
