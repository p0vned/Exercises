using System;
using System.Collections.Generic;

namespace Exercises.Tasks
{
    public static class TwoSum
    {
        public static int[] Solution(int[] nums, int target)
        {
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