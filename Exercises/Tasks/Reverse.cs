using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;

namespace Exercises.Tasks
{
    public static class Reverse
    {
        //Given a 32-bit signed integer, reverse digits of an integer.
        public static int Solution(int x)
        {
            var numberAsString = x.ToString();
            string reversedString;

            if (x >= 0)
                reversedString = string.Join("", numberAsString.Reverse());
            else
            {
                var reversedStringList = numberAsString.Remove(0, 1).Reverse().ToList();
                reversedStringList.Insert(0, '-');

                reversedString = string.Join("", reversedStringList);
            }

            int result;
            bool isParseValid = int.TryParse(reversedString, out result);

            //if (isParseValid)
            return result;

            //throw new Exception("Parsing failed");
        }
    }
}
