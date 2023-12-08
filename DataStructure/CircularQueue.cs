using System;


namespace DataStructure
{
    public class CircularQueue
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Circular Queue size");
            int s=int.Parse(Console.ReadLine());
            CQueue cq=new CQueue(s);
            bool req= true;
            while (req)
            {
                Console.WriteLine("Choose the Operation");
                Console.WriteLine("Press 1 for EnQueue");
                Console.WriteLine("Press 2 for DeQueue");
                Console.WriteLine("Press 3 for Display");
                Console.WriteLine("Press 0 to Ext");
                int choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 0:
                        req = false; 
                        break;
                    case 1:
                        Console.WriteLine("Enter an element to insert");
                        int num=int.Parse(Console.ReadLine());
                        cq.EnQueue(num);
                        break;
                    case 2:
                        cq.DeQueue();
                        break;
                    case 3:
                        cq.Display();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }

    internal class CQueue
    {
        private int[] circularque;
        private int size;
        private int rear = -1;
        private int front = 0;
        private int count = 0;

        public CQueue(int n)
        {
            circularque = new int[n];
            size = circularque.Length;

        }

        public void EnQueue(int num)
        {
            if (count == size)
            {
                Console.WriteLine("Circular Queue is Empty");
            }
            else
            {
                rear = (rear + 1) % size;
                circularque[rear] = num;
                count++;
            }
        }
        public void DeQueue()
        {
            if (count == 0 )
            {
                Console.WriteLine("Queue is Empty");
            }
            else
            {
                Console.WriteLine("Deleted Element is " + circularque[front]);
                front= (front + 1) % size;
                count--;
            }
        }

        public void Display()
        {
            if(count==0)
            {
                Console.WriteLine("Queue is Display ");
            }
            else
            {
                for(int i = 0;i<count;i++)
                {
                    Console.WriteLine(circularque[front]);
                    front=(front + 1) % size;
                }
                Console.WriteLine();
            }
        }
    }
}
