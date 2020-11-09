using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Exercises.Tasks
{
    public class PlusOne
    {
        public static int[] Solution(int[] digits)
        {
            int index = digits.Length - 1;

            digits[index] += 1;

            if (digits[index] != 10)
                return digits;
            
            while (digits[index] == 10)
            {
                try
                {
                    digits[index] = 0;
                    digits[index - 1] += 1;
                    index--;
                }
                catch (IndexOutOfRangeException e)
                {
                    var newDigits = new int[digits.Length + 1];
                    newDigits[0] = 1;

                    for (int i = 1; i < newDigits.Length; i++)
                    {
                        newDigits[i] = 0;
                    }

                    return newDigits;
                }
            }

            return digits;
        }
    }
}
