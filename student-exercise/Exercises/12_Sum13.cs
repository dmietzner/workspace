﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public partial class Exercises
    {
        /*
         Return the sum of the numbers in the array, returning 0 for an empty array. Except the number
         13 is very unlucky, so it does not count and numbers that come immediately after a 13 also do
         not count.
         Sum13([1, 2, 2, 1]) → 6
         Sum13([1, 1]) → 2
         Sum13([1, 2, 2, 1, 13]) → 6
         Sum13([3, 13, 12, 11]
         */
        public int Sum13(int[] nums)
        {
            int sum = 0;
            if(nums.Length == 0)
            {
                return sum;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                bool prev_num_13 = (i > 0 && nums[i-1] == 13);
                if(nums[i] != 13 && !prev_num_13)
                {
                    sum = sum + nums[i];
                }

            }
                return sum;
            
        
        }

    }
}
