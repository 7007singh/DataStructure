using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class CustomLinkedList
    {
        public Node head;

        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if(head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }        

        public void Display()
        {
            Console.WriteLine("Displaying nodes");
            if(head == null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            else
            {
                Node temp = head;
                while(temp != null)
                {
                    Console.Write(temp.data+" ");
                    temp = temp.next;
                }
            }
        }
    }
}
