using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithm
{
    class LinearSearch
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Welcome to Linear Search");
            Console.WriteLine("Enter the Size of an Array");
            int size=int.Parse(Console.ReadLine());
            int []Arr = new int[size];
            Console.WriteLine("Enter element to insert");
            for(int i = 0; i < size; i++)
            {
                Arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter a Element to search");
            int key=int.Parse (Console.ReadLine());
            bool flag = false;
            foreach(int i in Arr)
            {
                if(i==key)
                {
                    flag = true;
                }
            }

            if(flag) { Console.WriteLine("Element is Found"); }
            else { Console.WriteLine("Element Not Found"); }
        }
    }
}
