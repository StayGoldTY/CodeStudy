using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LeetCodeStude.question
{
    public class Q1
    {
       
            public static int[] TwoSum(int[] nums, int target)
            {

            int[] retarr = new int[2];
            int value1 = 0;
            int value2 = 0;
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(target - nums[i]))
                {

                    dic.TryGetValue(target - i, out value1);
                    dic.TryGetValue(nums[i], out value2);
                    retarr[0] = i;
                    retarr[1] = dic[target - nums[i]];
                    return retarr;
                }
                dic.Add(nums[i], i);

            }

            return retarr;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i + 1; j < nums.Length; j++)
            //    {
            //        if (target == nums[i] + nums[j])
            //        {
            //            // retarr = {i,j+1};
            //            retarr[0] = i;
            //            retarr[1] = j;

            //        }
            //    }
            //}
            //return retarr;
        }
        
    }
}
