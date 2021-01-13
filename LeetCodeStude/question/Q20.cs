using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace LeetCodeStude.question
{
    //给定一个只包括 '('，')'，'{'，'}'，'['，']' 的字符串，判断字符串是否有效。
    //有效字符串需满足：
    //左括号必须用相同类型的右括号闭合。
    //左括号必须以正确的顺序闭合。
    //注意空字符串可被认为是有效字符串。
    //示例 1:
    //输入: "()"
    //输出: true
    //示例 2:
    //输入: "()[]{}"
    //输出: true
    //示例 3:
    //输入: "(]"
    //输出: false
    //示例 4:
    //输入: "([)]"
    //输出: false
    //示例 5:
    //输入: "{[]}"
    //输出: true

    public class Q20
    {
        public static bool IsValid(string s)
        {
            Dictionary<Char,Char> dic = new Dictionary<char, char>();
            Stack<Char> sk = new Stack<char>();
            if (s.ToCharArray().Length % 2 != 0)
            {
                return false;
            }
            dic.Add('(',')');
            dic.Add('[', ']');
            dic.Add('{', '}');
            for (int i = 0; i < s.Length; ++i)
            {
                if (dic.ContainsKey(s[i]))
                {
                    sk.Push(s[i]);
                }
                else
                {
                    if (sk.Count==0 || dic[sk.Pop()] != s[i])
                    {
                        return false;
                    }
                }
            }

            if (sk.Count != 0) return false;
            return true;
        }

        public static bool IsValid1(string s)
        {
            
            if (s.ToCharArray().Length % 2 != 0)
            {
                return false;
            }

            while (s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
            {
               s= s.Replace("()", "");
               s = s.Replace("[]", "");
               s = s.Replace("{}", "");
            }

            if (s == "")
            {
                return true;
            }

            return false;
        }

       




}
}
