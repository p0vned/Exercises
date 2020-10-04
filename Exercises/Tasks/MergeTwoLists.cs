using Exercises.Models;

namespace Exercises.Tasks
{
    public static class MergeTwoLists
    {
        public static ListNode Solution(ListNode l1, ListNode l2)
        {
            var temp = new ListNode(-1);
            var head = temp;

            while (l1 != null && l2 != null)
            {
                if (l1.val < l2.val)
                {
                    temp.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    temp.next = l2;
                    l2 = l2.next;
                }

                temp = temp.next;
            }

            if (l1 != null)
                temp.next = l1;

            if (l2 != null)
                temp.next = l2;

            return head.next;
        }
    }
}
