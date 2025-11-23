using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueuewithLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.display();
            queue.Dequeue();
            queue.Dequeue();
            queue.Enqueue(6);
            queue.display();
            queue.Peek();
        }
    }
}
