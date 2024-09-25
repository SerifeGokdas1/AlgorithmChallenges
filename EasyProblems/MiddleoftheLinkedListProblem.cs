using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmChallenges.EasyProblems
{
    public class MiddleoftheLinkedListProblem
    {
        public static ListNode MiddleNode(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;


            while (fast != null && fast.next != null)
            {
                slow = slow.next;      // slow bir adım ilerliyor
                fast = fast.next.next; // fast iki adım ilerliyor
            }
            return slow;

        }
    }
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
}
