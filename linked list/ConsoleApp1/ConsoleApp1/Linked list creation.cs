using System;

namespace Task1{

    class Node
    {
        public int data;
        public Node next;


        public Node(int data)
        {
            data = data;
            next = null;

        }


    }

    class LinkListCreation
    {
        static Node head = null;

        static void insert(int data)
        {
            Node newnode = new Node(data);

            if (head == null)
            {
                head = newnode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;

                    temp.next = newnode;
                }
            }
        }
        static void Display()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
            Console.WriteLine("nulll");
        }

        public void Run(string[] args)
        {
            insert(0);
            insert(100);
            insert(200);

            Display();
        }
    }



}