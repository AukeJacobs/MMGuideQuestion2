using ReverseLinkedListApplication;
using ReverseLinkedListApplication.Models;

namespace ReverseLinkedListTests
{
    public class ReverseLinkedListTests
    {
        [Fact]
        public void ReverseLinkedListLoopEquals()
        {
            var orderedList = new List<int> { 1, 2, 3, 4, 5 };
            var linkedList = new LinkedList(orderedList);

            linkedList.ReverseUsingLoop();
            orderedList.Reverse();

            Assert.True(Enumerable.SequenceEqual(GetNodeValuesInOrder(linkedList), orderedList));
        }

        [Fact]
        public void ReverseLinkedListRecursionEquals()
        {
            var orderedList = new List<int> { 1, 2, 3, 4, 5 };
            var linkedList = new LinkedList(orderedList);

            linkedList.ReverseRecursive();
            orderedList.Reverse();

            Assert.True(Enumerable.SequenceEqual(GetNodeValuesInOrder(linkedList), orderedList));
        }

        private List<int> GetNodeValuesInOrder(LinkedList linkedList)
        {
            var valuesInOrder = new List<int>();
            var current = linkedList.Head;

            for (int i = 0; linkedList.Count > i; i++) 
            {
                valuesInOrder.Add(current.Value);
                current = current.Next;
            }

            return valuesInOrder;
        }
    }
}