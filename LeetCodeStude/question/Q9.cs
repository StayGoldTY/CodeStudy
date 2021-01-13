using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeStude.question
{
    public class Q9
    {
        public static bool IsPalindrome(int x)
        {
            int copyx = x;
            if (x < 0)
            {
                return false;
            }
            else
            {
                long ret=0;
                while (x!=0)
                {
                    ret = 10 * ret + x % 10;
                    x /= 10;
                }

                return (int)ret == ret ? (int)ret== copyx ? true:false : false;
            }
        }
    }
}
