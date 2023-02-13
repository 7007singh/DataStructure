using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose program to execute \n1:LinkList Add Last\n2:LinkList Add First");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    CustomLinkedList linkedList = new CustomLinkedList();
                    linkedList.AddLast(56);
                    linkedList.AddLast(30);
                    linkedList.AddLast(70);
                    linkedList.Display();
                    break;
                case 2:
                    CustomLinkedList linkedListAddFirst = new CustomLinkedList();
                    linkedListAddFirst.AddFirst(70);
                    linkedListAddFirst.AddFirst(30);
                    linkedListAddFirst.AddFirst(56);
                    linkedListAddFirst.Display();
                    break;
            }            
            Console.ReadLine();
        }
    }
}
