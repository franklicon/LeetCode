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
                if (list1.Val < list2.Val)
                {
                    node.Next = list1;
                    list1 = list1.Next;
                }
                else
                {
                    node.Next = list2;
                    list2 = list2.Next;
                }
                node = node.Next;
            }
            while (list1 != null)
            {
                node.Next = list1;
                list1 = list1.Next;
                node = node.Next;
            }
            while (list2 != null)
            {
                node.Next = list2;
                list2 = list2.Next;
                node = node.Next;
            }

            return headNode.Next;
        }
    }

    public class ListNode(int val = 0, ListNode? next = null)
    {
        public readonly int Val = val;
        public ListNode? Next = next;
    }
}
