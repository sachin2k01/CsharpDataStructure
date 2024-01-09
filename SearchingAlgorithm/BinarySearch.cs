using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithm
{
    public class Binarysearch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search");
            Console.WriteLine();
            Console.WriteLine("Enter the Array size");
            int size=int.Parse(Console.ReadLine());
            int[]arr = new int[size];
            Console.WriteLine("Enter the array elements");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter an Target value to search");
            int target = int.Parse(Console.ReadLine());
            int res=binarysearch(arr, target);
            if(res!=-1)
            {
                Console.WriteLine("Key is Found");
            }
            else { Console.WriteLine("Key is Not Found"); }
        }
        public static int binarysearch(int[] arr,int key)
        {
            int left = 0;
            int right = arr.Length - 1;
            while(left<=right)
            {
                int mid = (left + right) / 2;

                if (arr[mid] == key)
                {
                    return mid;
                }
                else if (arr[mid] < key)
                {
                    left = mid + 1;
                }
                else
                    right = mid - 1;

            }
            return -1;
            
        }
    }
}
