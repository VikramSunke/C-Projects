using System;
using System.Collections;

namespace CollectionsDemo
{
    internal class QueueDemo
    {
        static void Main(string[] args)
        {
            // Follows First In First Out principle
            Queue myQueue = new Queue();

            myQueue.Enqueue("First");   // Using Enqueue() method
            myQueue.Enqueue(2);
            myQueue.Enqueue("Third");
            myQueue.Enqueue(4.90);
            myQueue.Enqueue(true);

            foreach (var queue in myQueue)
            {
                Console.WriteLine(queue);
            }

            object dequeueItem = myQueue.Dequeue();   // Removes first element from the queue list

            Console.WriteLine($"\nDequeued Item : {dequeueItem}\n");

            object peekedItem = myQueue.Peek();   // Returns top element from the queue list
            Console.WriteLine($"\nPeeked Item: {peekedItem}\n");

            foreach (var queue in myQueue)
            {
                Console.WriteLine(queue);
            }

            bool containsItem = myQueue.Contains(4.90);  // Checks whether the queue list contains the given item or not
            Console.WriteLine(containsItem);

            myQueue.Clear();

            Console.WriteLine("\nCount: {0}", myQueue.Count);   // Prints count of queue list
        }
    }
}
