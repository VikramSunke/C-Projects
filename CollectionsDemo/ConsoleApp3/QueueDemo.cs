using System.Collections;
namespace ConsoleApp3
{
    internal class QueueDemo
    {
        static void Main(string[] args)
        { 

            //Follows First In First out principle
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

            object dequeueItem = myQueue.Dequeue();   // removes first element from the queue list

            Console.WriteLine($"\nDequeued Item : {dequeueItem}\n");

            

            object peekedItem= myQueue.Peek();   // returns top element from the queue list
            Console.WriteLine($"\nPeeked Item: {peekedItem}\n");
            
            foreach (var queue in myQueue)
            {
                Console.WriteLine(queue);
            }

            bool containsItem = myQueue.Contains(4.90);  // checks wheater the queue list contains the given item or not
            Console.WriteLine(containsItem);

            myQueue.Clear();

            Console.WriteLine("\nCount: {0}",myQueue.Count);   // prints count of queue list

        }
    }
}
