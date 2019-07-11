using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureCoding
{
    public class MergeTwoSortedLists
    {
        //public void MergeTwoLists()
        //{
        //    IEnumerable<int> first = new List<int>() { 1, 3, 3 };
        //    IEnumerable<int> second = new List<int>() { 2, 4 };
        //    var mergedList = first.ToList().Concat(second).OrderBy(x => x).ToList();

        //}
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }
            else if (l2 == null)
            {
                return l1;
            }
            else if (l1.val < l2.val)
            {
                l1.next = AddTwoNumbers(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = AddTwoNumbers(l1, l2.next);
                return l2;
            }
        }
    }

    // Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) 
        { 
            val = x;
        }
    }

}
