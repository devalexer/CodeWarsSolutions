using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeWarsSolution
{

    public static class Kata
    {
        // return masked string

        public static string Maskify(string cc)
        {
            var rv = string.Empty;
            if (cc.Length > 4)
            {
                for (int i = 0; i < cc.Length - 4; i++)
                {
                    rv += "#";
                }
                rv += cc.Substring(cc.Length - 4);
            }
            else
            {
                rv = cc;
            }
            return rv;
        }
    }

    //Usually when you buy something, you're asked whether your credit card number, phone number or answer to your most secret question is 
    //    still correct. However, since someone could look over your shoulder, you don't want that shown on your screen.Instead, we mask it.

    //Your task is to write a function maskify, which changes all but the last four characters into '#'.


    //public static string Maskify(string cc)
    //{
    //    for (int i = 0; i < cc.Length - 4; i++)
    //    {
    //        i += "x";
    //    }

    //    var splitString = cc.Split();
    //    foreach (var num in splitString)
    //    {
    //        num.Replace("", 'x');
    //    }

    //    return newNumber;
    //}
}