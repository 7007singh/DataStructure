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
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }
        public void Append(int data)
        {
            AddLast(data);
        }
        public void Insert(int data)
        {
            Node newNode = new Node(data);
            newNode.data = data;
            newNode.next = head.next;
            head.next = newNode;
        }
        public void RemoveFirst()
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is empty, Please add node");
            }
            else
            {
                Console.WriteLine("Removed: " + head.data);
                head = head.next;
            }
        }
        public void RemoveLast()
        {
            Node temp = head;
            if (head == null)
            {
                Console.WriteLine("LinkedList is empty, please add node");
            }
            else if(head.next == null)
            {
                int data = temp.data;
                temp = null;
                Console.WriteLine("{0} node is deleted", data);
            }
            else
            {
                while(temp.next.next != null)
                {
                    temp = temp.next;
                }
                int lastDeletedNode = temp.next.data;
                temp.next = null;
                Console.WriteLine("{0} node is deleted", lastDeletedNode    );
            }
        }
        public void Search(int data)
        {
            Node temp = head;
            if(temp == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
                while(temp != null)
                {
                    if(temp.data == data)
                    {
                        Console.WriteLine("Node is present " + data);
                        break;
                    }
                    temp = temp.next;
                }
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
