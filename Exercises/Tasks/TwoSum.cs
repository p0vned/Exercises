using System;
using System.Collections.Generic;

namespace Exercises.Tasks
{
    public static class TwoSum
    {
        public static int[] Solution(int[] nums, int target)
        {
            /*
             Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
             You may assume that each input would have exactly one solution, and you may not use the same element twice.
             You can return the answer in any order.
             */ 


            var valueDictPosition = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var desiredValue = target - nums[i];

                if (valueDictPosition.ContainsKey(desiredValue))
                    return new int[] { i, valueDictPosition[desiredValue] };

                valueDictPosition[nums[i]] = i;
            }

            throw new Exception("Not found");
        }
    }
}