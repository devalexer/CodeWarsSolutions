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
            var rv = false;
            var vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };

            //change to binary
            var binary = word.Select(c => vowels.Contains(c) ? 1 : 0).ToArray();

            //split binary in alternating arrays
            var odd = binary.Where((c, i) => i % 2 != 0).ToArray();
            var even = binary.Where((c, i) => i % 2 == 0).ToArray();
            if ((odd.All(c => c == 1) && even.All(c => c == 0)) || (odd.All(c => c == 0) && even.All(c => c == 1)))
            {
                rv = true;
            }
            return rv;
        }


        //string a = string.Join<char>("", word.Where((ch, index) => (index % 2) != 0));
        //string b = string.Join<char>("", word.Where((ch, index) => (index % 2) == 0));

        //    if (a.Any() == ("a" || "e" || "i" || "o" || "u") && b.Any() == ("a" || "e" || "i" || "o" || "u"))
        //    {
        //        return false;
        //    }
        //    if (b.Any() == ("a" || "e" || "i" || "o" || "u"))
        //    {
        //        return false;
        //    }
        //    else return true;


        //StringBuilder sb = new StringBuilder();
        //    for (int i = 0; i <= word.Length - 1; i++)
        //    {
        //        sb.AppendFormat(i % 2 != 0 ? "{0} " : "{0},", [i]);
        //    }
        //    return sb.ToString();
        //}
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
