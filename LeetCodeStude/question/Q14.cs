using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace LeetCodeStude.question
{
    public class Q14
    {
        public static string LongestCommonPrefix1(string[] strs)
        {
            if (strs.Length==0)
            {
                return "";
            }

            var ret = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                int j = 0;
                for ( ;j < ret.Length; j++)
                {
                    if (strs[i].Length<j+1 || ret.Substring(j, 1) != strs[i].Substring(j, 1))
                    {
                        break;
                    }
                }
                ret = strs[i].Substring(0, j);
                if (ret == "")
                {
                    break;
                }
            }

            return ret;

        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
            {
                return "";
            }
            string ret = strs[0];
            for (int i = 0; i < ret.Length; i++)
            {
                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j].Length < i+1 || ret[i] != strs[j][i])
                    {
                        ret = ret.Substring(0, i);
                        return ret;
                    }
                    
                }
               
               
            }
            return ret;
        }
    }
}
