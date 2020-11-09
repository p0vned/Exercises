using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tasks
{
    public class LengthOfLastWord
    {
        /*
        Given a string s consists of upper/lower-case alphabets and empty space characters ' '
        return the length of last word (last word means the last appearing word if we loop from left to right) 
        in the string. If the last word does not exist, return 0.
         */

        public static int Solution(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;

            var stringTrimmed = s.Trim();
            
            var words = stringTrimmed.Split(" ");

            return words[words.Length - 1].Length;
        }
    }
}
