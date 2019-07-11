using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureCoding
{
    public class RevereseLinkedList
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return head;
            }
            ListNode p = ReverseList(head.next);
            head.next.next = head;
            head.next = null;
            return p;
        }
    }
}
