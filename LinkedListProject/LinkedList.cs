using System;

namespace LinkedList
{
    public class LinkedList
    {
        public Node head;
        public void Add(int Data)
        {
            Node node = new Node(Data);

            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = node;
            }
        }
        public void Addfirst(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
                this.head = newNode;
            else
            {
                Node temp = head;
                head = newNode;
                head.Next = temp;
            }
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            Console.Write("Linked list is: ");
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }
            Console.WriteLine("\n");
        }
    }
}
