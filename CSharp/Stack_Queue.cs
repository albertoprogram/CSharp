using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal class Stack_Queue
    {
        internal static void StackQueue()
        {
            //Queue example

            Queue queue = new Queue();

            for(int i = 1; i <= 25; i++)
            {
                queue.Enqueue(i);
            }

            Console.WriteLine($"The queue has {queue.Count} elements");
            Console.WriteLine("The elements of the queue are:");

            while (queue.Count > 0)
            {
                Console.WriteLine(queue.Dequeue());
            }

            Console.WriteLine($"Now, the queue has {queue.Count} elements");

            Console.Read();
        }

    }
}
