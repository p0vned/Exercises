using System.Linq;

namespace Exercises.Tasks
{
    public static class PalindromeNumber
    {
        // Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.

        public static bool Solution(int x)
        {
            if (x < 0 || (x % 10 == 0 && x != 0))
                return false;

            int reversedNumber = 0;

            while(x > reversedNumber)
            {
                reversedNumber = x % 10 + reversedNumber * 10;
                x /= 10;
            }

            return x == reversedNumber || x == reversedNumber / 10;
        }
    }
}
