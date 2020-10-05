namespace Exercises.Tasks
{
    public static class SearchInsert
    {
        // Given a sorted array of distinct integers and a target value, return the index if the target is found. 
        // If not, return the index where it would be if it were inserted in order.

        public static int Solution(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int middle = (right + left) / 2;

                if (target > nums[middle])
                    left = middle + 1;
                else if (target < nums[middle])
                    right = middle - 1;
                else
                    return middle;
            }

            return right + 1;
        }
    }
}
