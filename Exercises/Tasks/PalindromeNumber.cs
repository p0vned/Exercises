using System.Linq;

namespace Exercises.Tasks
{
    public static class PalindromeNumber
    {
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
