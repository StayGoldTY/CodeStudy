using System;
using LeetCodeStude.question;

namespace LeetCodeStude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrIn = { 49, 89, 5, 6, 88, 47, 15 };
            // int[] retarr = Q1.TwoSum(arrIn, 11);
            //  int retint = Q7.Reverse(-2147483412);
            //  bool retb = Q9.IsPalindrome(15751);
            // int retint = Q7.Reverse(-2);
            // int retint = Q13.RomanToInt("MMMCMXCIX");
            // string[] arrs = { "flower", "flow", "flight" };
            // string rets = Q14.LongestCommonPrefix(new string[] {"caa", "", "a", "acb" });
            //string rets = Q14.LongestCommonPrefix(new string[] { "flower", "flow", "flight" });
              bool rets = Q20.IsValid("((");
          //  bool rets = Q20.IsValid("[({])}");
            
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
