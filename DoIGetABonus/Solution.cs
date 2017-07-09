using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoIGetABonus
{
    public static class Kata
    {
        public static string bonus_time(int salary, bool bonus)
        {
            var final = 0;
            if (bonus == true)
            {
                final = salary * 10;
            }
            else
            {
                final = salary;
            }
            return ("$" + final);
        }

//It's bonus time in the big city! The fatcats are rubbing their paws in anticipation... but who is going to make the most money?
//Build a function that takes in two arguments(salary, bonus). Salary will be an integer, and bonus a boolean.
//If bonus is true, the salary should be multiplied by 10. If bonus is false, the fatcat did not make enough money and must receive only his stated salary.
//Return the total figure the individual will receive as a string prefixed with '£' (JS and Java) or '$' (C#, C++, Ruby, Clojure, Elixir, PHP and Python).

    }
}