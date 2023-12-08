using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class StackDs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Size of the Stack");
            int size=int.Parse(Console.ReadLine());
            Stack s=new Stack(size);
            bool con = true;
            while (con)
            {
                Console.WriteLine("Choose operation");
                Console.WriteLine("Enter 1 for Push");
                Console.WriteLine("Enter 2 for Pop");
                Console.WriteLine("Enter 3 for Display");
                Console.WriteLine("Enter 0 for Exit");
                int choice=int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        con= false;
                        break;

                    case 1:
                        Console.WriteLine("Enter an element to insert");
                        int num=int.Parse(Console.ReadLine());
                        s.Push(num); 
                        break;
                    case 2:
                        s.Pop();
                        break;
                    case 3:
                        s.Display();    
                        break;
                    default: Console.WriteLine("Invalid Choice");
                        break;
                }

            }

        }

    }

    internal class Stack
    {
        public int count { get; private set; }
        private int[] stack;

        public Stack(int size)
        {
            stack = new int[size];
            count = 0;
        }

        public void Push(int val)
        {
            if(count == stack.Length)
            {
                Console.WriteLine("Stack is Full! ");
            }
            else
            {

                stack[count++] = val;
            }
        }

        public void Pop()
        {
            if(count <= 0)
            {
                Console.WriteLine("Stack is Empty!");
            }
            else
            {
                Console.WriteLine("Deleted ELement is " + stack[count-1]);
                count--;
            }
        }

        public void Display()
        {
            if(count==0)
            {
                Console.WriteLine("Stack is Empty to Display!");
            }
            else
            {
                Console.WriteLine("Stack Element are:");
                for (int i = count-1; i >= 0; i--)
                {
                    Console.WriteLine(stack[i]);
                }

            }
            
        }
    }
}
