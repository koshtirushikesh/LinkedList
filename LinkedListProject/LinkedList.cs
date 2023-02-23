using System;

namespace LinkedList
{
    public class LinkedList
    {
        public Node headNode;
        public void Add(int Data)
        {
            Node newNode = new Node(Data);

            if (this.headNode == null)
                this.headNode = newNode;
            else
            {
                Node tempNode = headNode;
                while (tempNode.Next != null)
                {
                    tempNode = tempNode.Next;
                }
                tempNode.Next = newNode;
            }
        }
        public void Addfirst(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = headNode;
            headNode = newNode;
        }
        public void Display()
        {
            Node tempNode = this.headNode;
            if (tempNode == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            Console.Write("Linked list is: ");
            while (tempNode != null)
            {
                Console.Write(tempNode.Data + " ");
                tempNode = tempNode.Next;
            }
            Console.WriteLine("\n");
        }
    }
}
