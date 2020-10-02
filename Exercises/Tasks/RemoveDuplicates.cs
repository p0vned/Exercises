using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tasks
{
    public static class RemoveDuplicates
    {
        /*
        Given a sorted array nums, remove the duplicates in-place such that each element appears only once and returns the new length.
        Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
        */

        public static int Solution(int[] nums)
        {
            if (nums.Length == 0) return 0;
            
            int length = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[length])
                {
                    length++;
                    nums[length] = nums[i];
                }
            }

            return length + 1;
        }
    }
}
