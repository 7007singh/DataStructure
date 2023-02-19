﻿using System;
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
