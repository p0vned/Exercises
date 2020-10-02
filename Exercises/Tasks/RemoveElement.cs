using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Text;

namespace Exercises.Tasks
{
    public static class RemoveElement
    {
        /*
        Given an array nums and a value val, remove all instances of that value in-place and return the new length.
        Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
        The order of elements can be changed. It doesn't matter what you leave beyond the new length.
         */

        public static int Solution(int[] nums, int val)
        {
            if (nums.Length == 0) return 0;
            
            int l = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[l] = nums[i];
                    l++;
                }
            }

            return l;
        }
    }
}
