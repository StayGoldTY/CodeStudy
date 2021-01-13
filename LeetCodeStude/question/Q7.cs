using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeStude.question
{
    public class Q7
    {
        public static int Reverse(int x)
        {
            long ret = 0;
            while (x != 0)
            {
                ret = 10 * ret + x%10;
                x /= 10;
            }

            return (int)ret == ret ? (int)ret : 0;
            //if (ret > Int32.MaxValue || ret < Int32.MinValue)
            //{
            //    return 0;
            //}
            //else
            //{
            //    return Convert.ToInt32(ret);
            //}
        }

        public static int Reverse2(int x)
        {
            int ret = 0;
            long test = 2;
           var m = test.GetType();
            while (x!=0)
            {
                int pop = x % 10;
                x /= 10;
                if (ret > Int32.MaxValue/10 || ret == Int32.MinValue && pop>7)
                {
                    return 0;
                }
                if (ret < Int32.MinValue / 10 || ret == Int32.MinValue && pop < -8)
                {
                    return 0;
                }

                ret = 10 * ret + pop;
               
            }

            return ret;

        }

        public static int Reverse1(int x)
        {
            
            if (x >= Math.Pow(2, 32))
            {
                return 0;
            }
            bool b = true;
            if (x<0)
            {
                b = false;
            };
            Char[] arr = x.ToString().ToCharArray();
           
            int length = arr.Length;
            

            if (b)
            {
                Char[] brr = new char[length];
                for (int i = 0; i < length; i++)
                {
                    brr[i] = arr[length - i - 1];
                }

                try
                {
                    return int.Parse(brr);
                }
                catch
                {
                    return 0;
                }
                
            }
            else
            {
                Char[] brr = new char[length-1];
                for (int i = 0; i < length - 1; i++)
                {
                    brr[i] = arr[length - i - 1];
                }
               
                try
                {
                    return (0 - int.Parse(brr));
                }
                catch
                {
                    return 0;
                }
            }

           
        }
    }
}
