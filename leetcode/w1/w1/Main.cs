using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace w1
{
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }
        
    public class MainMethod
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode h = l1;
            while (l1 != null && l2 != null)
            {
                h.val += l2.val;
                if (h.val >= 10)
                {
                    int tmp = h.val / 10; 
                    h.val %= 10;
                    h.next.val += tmp;
                }
                h = h.next;
                l2 = l2.next;
            }
            while(l2 == null)
            {
                h.val += 0;
                if (h.val >= 10)
                {
                    int tmp = h.val / 10;
                    h.val %= 10;
                    if(h.next == null)
                    {
                        ListNode t = new ListNode(tmp);
                        h.next = t;
                        break;
                    }
                    h.next.val += tmp;
                }
                h = h.next;
            }
            return l1;
        }
        public static ListNode listToNode(int[] ls)
        {
            ListNode l = new ListNode(ls[0]);
            ListNode h = l;
            for(int x = 1; x < ls.Length; x++)
            {
                ListNode temp = new ListNode(ls[x]);
                h.next = temp;
                h = h.next;
            }
            return l;
        }
        public static void Main(string[] args)
        {
            Solution sl = new Solution();
            int[] list1 = { 9,9,9,9,9,9,9 };
            int[] list2 = { 9,9,9,9,9 };
            ListNode l1 = listToNode(list1);
            ListNode l2 = listToNode(list2);
            ListNode r = AddTwoNumbers(l1, l2);
            while (r != null)
            {
                Console.Write(r.val);
                r = r.next;
            }
            Console.ReadKey();
        }
    }
}
