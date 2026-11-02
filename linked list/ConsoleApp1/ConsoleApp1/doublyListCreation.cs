using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task3
{
     class Node
    {
        public int data;
        public Node next;
        public Node prev;

        public Node(int value)
        {
            data = value;
            next = null;
            prev = null;

        }
    }

     public class doublyListCreation
    {
        static Node head = null;

        static void Insert(int value)
        {
            Node newNode = new Node(value);

            if (head == null)
            {
                head = newNode;
                return;
            }

            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;
            newNode.prev = temp;
        
        }
        static void Display()
        {
            Node temp = head;
            while(temp != null)
            {
                Console.Write(temp.data);
                temp = temp.next;

            }

            Console.WriteLine("NUll");
        }

         public void Run(string[] args)
        {
            Insert(18);
                Console.WriteLine("boubly linked list");
            Display();
        }

    }
}
