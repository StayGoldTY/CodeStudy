using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeStude.question
{
    //罗马数字包含以下七种字符: I， V， X， L，C，D 和 M。

    //字符 数值
    //I             1
    //V             5
    //X             10
    //L             50
    //C             100
    //D             500
    //M             1000


    //示例 1:

    //输入: "III"
    //输出: 3
    //示例 2:

    //输入: "IV"
    //输出: 4
    //示例 3:

    //输入: "IX"
    //输出: 9
    //示例 4:

    //输入: "LVIII"
    //输出: 58
    //解释: L = 50, V= 5, III = 3.
    //示例 5:

    //输入: "MCMXCIV"
    //输出: 1994
    //解释: M = 1000, CM = 900, XC = 90, IV = 4.

    //M－1000、MC－1100、MCD－1400、MD－1500、MDC－1600、MDCLXVI－1666、
    //MDCCCLXXXVIII－1888、MDCCCXCIX－1899、MCM－1900、MCMLXXVI－1976、
    //MCMLXXXIV－1984、MCMXC－1990、MM－2000、MMMCMXCIX－3999

    //例如， 罗马数字 2 写做 II ，即为两个并列的 1。12 写做 XII ，即为 X + II 。 27 写做 XXVII, 即为 XX + V + II 。

    //通常情况下，罗马数字中小的数字在大的数字的右边。但也存在特例，例如 4 不写做 IIII，而是 IV。数字 1 在数字 5 的左边，所表示的数等于大数 5 减小数 1 得到的数值 4 。同样地，数字 9 表示为 IX。这个特殊的规则只适用于以下六种情况：

    //I 可以放在 V(5) 和 X(10) 的左边，来表示 4 和 9。
    //X 可以放在 L(50) 和 C(100) 的左边，来表示 40 和 90。 
    //C 可以放在 D(500) 和 M(1000) 的左边，来表示 400 和 900。
    //给定一个罗马数字，将其转换成整数。输入确保在 1 到 3999 的范围内。

    //提示：

    //题目所给测试用例皆符合罗马数字书写规则，不会出现跨位等情况。
    //IC 和 IM 这样的例子并不符合题目要求，49 应该写作 XLIX，999 应该写作 CMXCIX 。
    //关于罗马数字的详尽书写规则，可以参考 罗马数字 - Mathematics 。
    public class Q13
    {
        public static int RomanToInt(string s)
        {
            int ret = 0;
            Dictionary<string,int> dic = new Dictionary<string, int>();
            dic.Add("M",1000);
            dic.Add("D", 500);
            dic.Add("CM", 900);
            dic.Add("CD", 400);
            dic.Add("C", 100);
            dic.Add("L", 50);
            dic.Add("XC", 90);
            dic.Add("XL", 40);
            dic.Add("X", 10);
            dic.Add("V", 5);
            dic.Add("IX", 9);
            dic.Add("IV", 4);
            dic.Add("I", 1);

            for (int i = 0; i < s.Length; i++)
            {
                if ((i + 1) < s.Length && dic.ContainsKey(s.Substring(i,2)))
                {
                    ret = ret + dic[s.Substring(i, 2)];
                    i += 1;
                }
                else
                {
                    ret = ret + dic[s.Substring(i, 1)];
                }
            }

            return ret;
        }

       
        public static int RomanToInt2(string s)
        {
            int ret = 0;
            int pre = getValue2(s[0].ToString());
            for (int i = 1; i < s.Length; i++)
            {
                int num = getValue2(s[i].ToString());
                if (pre < num)
                {
                    ret = ret - pre;
                  
                }
                else
                {
                    ret = pre + ret;
                }

                pre = num;
            }
            return ret+ pre;
        }

        public static int getValue2(string x)
        {
            switch (x)
            {
                case "M":
                   return 1000; break;
                case "D":
                    return 500; break;
                case "C":
                    return 100; break;
                case "L":
                    return 50; break;
                case "X":
                    return 10; break;
                case "V":
                    return 5; break;
                default:
                    return 1; break;
                    
            }
        }

        public static int RomanToInt1(string s)
        {
            Char[] charArr = s.ToCharArray();
            int ret = 0;
            //对于左边的判断
            for (int i = 0; i < charArr.Length; i++)
            {
                switch (charArr[charArr.Length-i-1])
                {
                    case 'M':
                        if ( charArr.Length - i - 2>=0)
                        {
                            if (charArr[charArr.Length - i - 2] == 'C')
                            {
                                ret = ret+ 900;
                                i += 1;
                            }
                            else
                            {
                                ret = ret + 1000;
                            }
                        }
                        else if(charArr.Length - i - 1 == 0)
                        {
                            ret = ret + 1000;
                        }
                        break;
                    case 'D':
                        if (charArr.Length - i - 2 >= 0)
                        {
                            if (charArr[charArr.Length - i - 2]  == 'C')
                            {
                                ret = ret + 400;
                                i += 1;
                            }
                            else
                            {
                                ret = ret + 500;
                            }
                        }
                        else if (charArr.Length - i - 1 == 0)
                        {
                            ret = ret + 500;
                        }
                        break;
                    case 'C':
                        if (charArr.Length - i - 2 >= 0)
                        {
                            if (charArr[charArr.Length - i - 2] == 'X')
                            {
                                ret = ret + 90;
                                i += 1;
                            }
                            else
                            {
                                ret = ret + 100;
                            }
                        }
                        else if (charArr.Length - i - 1 == 0)
                        {
                            ret = ret + 100;
                        }
                        break;
                    case 'L':
                        if (charArr.Length - i - 2 >= 0)
                        {
                            if (charArr[charArr.Length - i - 2] == 'X')
                            {
                                ret = ret + 40;
                                i += 1;
                            }
                            else
                            {
                                ret = ret + 50;
                            }
                        }
                        else if (charArr.Length - i - 1 == 0)
                        {
                            ret = ret + 50;
                        }
                        break;
                    case 'X':
                        if (charArr.Length - i - 2 >= 0)
                        {
                            if (charArr[charArr.Length - i - 2] == 'I')
                            {
                                ret = ret + 9;
                                i += 1;
                            }
                            else
                            {
                                ret = ret + 10;
                            }
                        }
                        else if (charArr.Length - i - 1 == 0)
                        {
                            ret = ret + 10;
                        }
                        break;
                    case 'V':
                        if (charArr.Length - i - 2 >= 0)
                        {
                            if (charArr[charArr.Length - i - 2] == 'I')
                            {
                                ret = ret + 4;
                                i += 1;
                            }
                            else
                            {
                                ret = ret + 5;
                            }
                        }
                        else if (charArr.Length - i - 1 == 0)
                        {
                            ret = ret + 5;
                        }
                        break;
                    default: ret = ret + 1;break;
                       

                }
            }

            return ret;
        }
    }
}
