using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class LinkedListDS
    {
        static void Main(string[] args)
        {
            LinkedList ls= new LinkedList();

            ls.Insert(34);
            ls.Insert(45);
            ls.Insert(12);
            ls.Insert(15);
            ls.Insert(41);
            ls.Insert(51);


            Console.WriteLine("ELements: ");
            ls.Display();

            Console.WriteLine("ELements After Deletion: ");
            ls.DeleteLast();
            ls.Display();

            Console.WriteLine("ELements After front Deletion: ");
            ls.DeleteFront();
            ls.Display();

            Console.WriteLine("After Insert at front");
            ls.InsertFront(88);
            ls.Display();

            ls.Insert(66);

            Console.WriteLine("After Insert at rear");
            ls.InsertRear(11);
            ls.Display();

        }
    }
}
