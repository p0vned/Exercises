using System.Linq;

namespace Exercises.Tasks
{
    public static class PalindromeNumber
    {
        // Determine whether an integer is a palindrome. An integer is a palindrome when it reads the same backward as forward.

        public static bool Solution(int x)
        {
            if (x < 0)
                return false;
            
            var numberAsString = x.ToString();
            var numberReversed = string.Join(string.Empty, numberAsString.Reverse());

            if (numberAsString.Equals(numberReversed))
                return true;

            return false;
        }
    }
}
