using ReverseLinkedListApplication.Models;

var linkedList = new LinkedList(new List<int> { 1, 2, 3, 4, 5 });

linkedList.ReverseUsingLoop();

Console.WriteLine(linkedList.Count);

linkedList.InsertFront(77);

Console.WriteLine(linkedList.Count);

linkedList.ReverseRecursive();

Console.WriteLine(linkedList.Count);