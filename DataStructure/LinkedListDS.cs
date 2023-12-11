using System;


namespace DataStructure
{
    public class LinkedListDS
    {
        static void Main(string[] args)
        {
            LinkedList ls= new LinkedList();
            bool Continue= true;

            while(Continue)
            {
                Console.WriteLine("Choose Any Option to Perform");
                Console.WriteLine("Press 1 for Insertion");
                Console.WriteLine("Press 2 for Delete");
                Console.WriteLine("Press 3 for Display");
                Console.WriteLine("Press 4 for Search Node");
                Console.WriteLine("Press 5 for Insertion a Node at Front");
                Console.WriteLine("Press 6 for Insertion a Node at End");
                Console.WriteLine("Press 7 for Delete Node at Front");
                Console.WriteLine("Press 8 for Delete Node at End");
                Console.WriteLine("Press 0 for Exit");
                int choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 0: Continue = false; break;
                    case 1:
                        Console.WriteLine("Enter a Element to Insert");
                        int elem=int.Parse(Console.ReadLine());
                        ls.Insert(elem);
                        break;
                    case 3:
                        Console.WriteLine("Displaying ELements in the Node");
                        ls.Display();
                        break;
                    case 2:
                        Console.WriteLine("Enter a Value to Delete");
                        int val=int.Parse(Console.ReadLine());
                        ls.DeleteByValue(val);
                        break;
                    case 4:
                        Console.WriteLine("Enter a element to Search");
                        int search=int.Parse(Console.ReadLine());
                        ls.SearchNode(search);
                        break;
                    case 5:
                        Console.WriteLine("Enter a value Insert at front");
                        int frontnode=int.Parse(Console.ReadLine());
                        ls.InsertFront(frontnode);
                        break;
                    case 6:
                        Console.WriteLine("Enter a value to Insert at End");
                        int rearnode=int.Parse(Console.ReadLine());
                        ls.InsertRear(rearnode);
                        break;
                    case 7:
                        Console.WriteLine("Deleting a Node at Front");
                        ls.DeleteFront();
                        break;
                    case 8:
                        Console.WriteLine("Deleting Node at End");
                        ls.DeleteLast();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
