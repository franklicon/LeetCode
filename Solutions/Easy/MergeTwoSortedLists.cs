namespace LeetCode.Solutions.Easy
{
    public static class MergeTwoSortedLists
    {
        public static ListNode Solution(ListNode list1, ListNode list2)
        {
            var headNode = new ListNode();
            var node = headNode;
            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    node.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    node.next = list2;
                    list2 = list2.next;
                }
                node = node.next;
            }
            while (list1 != null)
            {
                node.next = list1;
                list1 = list1.next;
                node = node.next;
            }
            while (list2 != null)
            {
                node.next = list2;
                list2 = list2.next;
                node = node.next;
            }

            return headNode.next;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
