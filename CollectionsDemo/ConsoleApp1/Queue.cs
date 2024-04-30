using System;
using System.Collections.Generic;

namespace Queue // Replace "YourNamespace" with your actual namespace
{
    class Queue
    {
        static void Main()
        {
            // Creating a Queue to represent the task queue
            Queue<Task> taskQueue = new Queue<Task>();

            // Adding tasks to the queue
            taskQueue.Enqueue(new Task("Task 1", Priority.High));
            taskQueue.Enqueue(new Task("Task 2", Priority.Medium));
            taskQueue.Enqueue(new Task("Task 3", Priority.Low));

            // Displaying the contents of the task queue
            DisplayTaskQueue(taskQueue);

            // Processing tasks from the queue
            while (taskQueue.Count > 0)
            {
                Task currentTask = taskQueue.Dequeue();
                Console.WriteLine($"Processing task: {currentTask.Name}");
                // Perform task processing logic here...
            }

            // Check if the queue is empty after processing
            if (taskQueue.Count == 0)
            {
                Console.WriteLine("All tasks processed. The queue is empty.");
            }
            else
            {
                Console.WriteLine($"There are {taskQueue.Count} tasks remaining in the queue.");
            }

            // Adding a new task to the queue
            taskQueue.Enqueue(new Task("Task 4", Priority.High));

            // Displaying the contents of the updated task queue
            DisplayTaskQueue(taskQueue);

            // Peek at the next task in the queue without removing it
            if (taskQueue.Count > 0)
            {
                Task nextTask = taskQueue.Peek();
                Console.WriteLine($"Next task in the queue: {nextTask.Name}");
            }
            else
            {
                Console.WriteLine("The queue is empty. No task to peek.");
            }
        }

        static void DisplayTaskQueue(Queue<Task> queue)
        {
            Console.WriteLine("Task Queue:");
            foreach (Task task in queue)
            {
                Console.WriteLine($"{task.Name} - Priority: {task.Priority}");
            }
            Console.WriteLine();
        }
    }

    class Task
    {
        public string Name { get; }
        public Priority Priority { get; }

        public Task(string name, Priority priority)
        {
            Name = name;
            Priority = priority;
        }
    }

    enum Priority
    {
        Low,
        Medium,
        High
    }
}
