using System;


namespace DataStructure
{
    public class QueueDS
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Queue Size");
            int n=int.Parse(Console.ReadLine());
            Queue q=new Queue(n);
            bool con = true;
            while (con)
            {
                Console.WriteLine("Choose operation");
                Console.WriteLine("Enter 1 for Insertion");
                Console.WriteLine("Enter 2 for Deletion");
                Console.WriteLine("Enter 3 for Display");
                Console.WriteLine("Enter 0 for Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        con = false;
                        break;
                    case 1:
                        Console.WriteLine("Enter an Element to Insert");
                        int num=int.Parse(Console.ReadLine());
                        q.Insert(num);
                        break;
                    case 2:
                        q.Delete();
                        break;
                    case 3:
                        q.Display();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;

                }
                    
            }

        }
    }

    internal class Queue
    {
        private int[] queue;
        private int size {  get; set; }
        private int rear = -1;
        private int front=0;


        public Queue(int n)
        {
            queue= new int[n];
            size = queue.Length;
        }

        public void Insert(int n)
        {
            if(rear==size)
            {
                Console.WriteLine("Queue is Full");
            }
            else
            {
                ++rear;
                queue[rear] = n;
            }
            
        }

        public void Delete()
        {
            if(front>rear || rear==-1)
            {
                Console.WriteLine("queue is Empty");
            }
            else
            {
                Console.WriteLine("Deleted Element is: " + queue[front]);
                ++front;
            }
        }

        public void Display()
        {
            if (front > rear || rear==-1)
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Console.WriteLine("Queue Elements is");
                for(int i=front;i<=rear;i++)
                {
                    Console.Write(queue[i]+" ");
                }
                Console.WriteLine();
            }
        }

    }
}
