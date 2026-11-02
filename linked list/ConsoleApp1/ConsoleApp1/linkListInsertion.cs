using System;

namespace Task2{


	public class Node
	{
		public int data;
		public Node next;

		public Node(int value)
		{
			data = value;
			next = null;


		}
	}


	public class linkListInsertion
	{
		static Node head = null;
		static void Insert(int value)
		{
			Node newnode = new Node(value);
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
				}
				temp.next = newnode;

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
			Console.WriteLine("Null");
		}

		public void Run(string[] args)
		{
			Console.Write("How many Nodes do you want");
			int n = Convert.ToInt32(Console.ReadLine());
			for (int i = 1; i <= n; i++) {
				Console.Write("Enter Value:");
				int value = Convert.ToInt32(Console.ReadLine());
				Insert(value);

			}

			Console.WriteLine("linked list");
			Display();
		}

	}
}