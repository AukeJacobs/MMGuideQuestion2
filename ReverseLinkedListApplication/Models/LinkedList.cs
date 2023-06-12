namespace ReverseLinkedListApplication.Models
{
    public class LinkedList
    {
        public ListNode Head { get; set; }
        public int Count { get; set; } = 1;

        public LinkedList(List<int> intList)
        {
            foreach (int i in intList)
            {
                InsertLast(i);
            }
        }

        public void InsertFront(int value)
        {
            ListNode newNode = new ListNode(value);
            newNode.Next = Head;
            Head = newNode;

            Count++;
        }

        public void InsertLast(int value)
        {
            ListNode newNode = new ListNode(value);

            if (Head == null)
            {
                Head = newNode;
                return;
            }

            var lastNode = GetLastNode();
            lastNode.Next = newNode;

            Count++;
        }

        public ListNode GetLastNode()
        {
            ListNode currentNode = Head;

            while (currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }

            return currentNode;
        }

        public void ReverseUsingLoop()
        {
            ListNode previous = null;
            ListNode current = Head;

            while (current != null)
            {
                ListNode next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }

            Head = previous;
        }

        public void ReverseRecursive()
        {
            Head = ReverseNode(Head, null);
        }

        private ListNode ReverseNode(ListNode current, ListNode previous)
        {
            if (current == null)
                return previous;

            ListNode next = current.Next;
            current.Next = previous;

            return ReverseNode(next, current);
        }
    }
}
