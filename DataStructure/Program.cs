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
            Console.WriteLine("Choose program to execute \n1:LinkList Add Last\n2:LinkList Add First\n3:LinkList Append\n4:Insertion LinkList");
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
                    linkedListAddFirst.AddFirst(56);
                    linkedListAddFirst.AddFirst(30);
                    linkedListAddFirst.AddFirst(70);
                    linkedListAddFirst.Display();
                    break;
                case 3:
                    CustomLinkedList linkedListAppend = new CustomLinkedList();
                    linkedListAppend.Append(56);
                    linkedListAppend.Append(30);
                    linkedListAppend.Append(70);
                    linkedListAppend.Display();
                    break;
                case 4:
                    CustomLinkedList linkedListInsert = new CustomLinkedList();
                    linkedListInsert.Append(56);
                    linkedListInsert.Append(70);
                    linkedListInsert.Insert(30);
                    linkedListInsert.Display();
                    break;
            }            
            Console.ReadLine();
        }
    }
}
