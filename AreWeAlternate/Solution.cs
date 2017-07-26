using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace AreWeAlternate
{
    public class Kata
    {
        public static bool IsAlt(string word)
        {
            string[] s = string.Join<char>("", word.Where((ch, index) => (index % 2) != 0));
            if (s == ("a" || "e" || "i" || "o" || "u"))
            {
                return true;
            }
            if (s != ("a" || "e" || "i" || "o" || "u"))
            {
                return false;
            }


            StringBuilder sb = new StringBuilder();
                for (int i = 0; i <= word.Length - 1; i++)
                {
                    sb.AppendFormat(i % 2 != 0 ? "{0} " : "{0},", [i]);
                }
                return sb.ToString();
            }
        }
    }


//Create a function isAlt() that accepts a string as an argument and validates whether the vowels(a, e, i, o, u) and consonants are in alternate order.

//isAlt("amazon")
//// true
//isAlt("apple")
//// false
//isAlt("banana")
//// true

//Arguments consist of only lowercase letters.
}