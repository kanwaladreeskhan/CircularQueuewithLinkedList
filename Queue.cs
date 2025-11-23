using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueuewithLinkedList
{
    internal class Queue
    {
        public Node front;
        public Node rear;
        public Queue()
        {
            front = null;
            rear = null;    
        }
        public bool IsEmpty()
        {
            if (front == null && rear == null)
            {
                return true;
            }
            return false;
        }
        public void Enqueue(int data)
        {
            Node newnode = new Node(data);
            if (IsEmpty())
            {
                front = newnode;
                rear = newnode;
                rear.next = front;
                Console.WriteLine("{0} is enqueued!", data);
            }
            else if (front == rear)
            {
                front.next = newnode;
                rear = newnode;
                rear.next = front;
                Console.WriteLine("{0} is Enqueued!",data);
            }
            else
            {
                rear.next = newnode;
                rear = rear.next;
                rear.next = front;
                Console.WriteLine("{0} is enqueued!", data);
            }
        }
        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty!");
            }
            else
            {
                Console.WriteLine("{0} is dequeued!", front.data);
                front = front.next;
                rear.next = front;
            }
        }
        public void Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty!");
            }
            else

            {
                Console.WriteLine("Front of the queue is {0}.", front.data);

            }
        }
        public void display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is Empty!");
            }
            else
            {
                Console.WriteLine("Elements in queue are:");
                Node temp = front;
                while (temp != null)
                {
                    Console.Write(temp.data + " ");
                    temp = temp.next;
                    if (temp == front)
                    {
                        break;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
