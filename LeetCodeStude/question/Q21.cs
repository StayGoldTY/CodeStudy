using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeStude.question
{
     //   *
     //* Definition for singly-linked list.
     //所以ListNode不是一连串的数据只是某一个节点的数据。这个节点的属性就是包括val 和 类型为下一个节点的 next 属性
     public class ListNode
     {
         public int val;
         public ListNode next;
    
         public ListNode(int val = 0, ListNode next = null)
         {
             this.val = val;
             this.next = next;
         }
     }




    public class Q21
    {
        public static ListNode  MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode lret = new ListNode();
            while (l1 != null && l2 !=null)
            {
                if (l1.val > l2.val)
                {
                    l1.next = l2;
                }
                else
                {
                    l2.next = l1;
                }
            }
            if (l1 == null)
            {
                l1.next = l2;
            }
            else
            {
                
            }

            return l1;

        }
    }
}
