using System;

namespace LinkedList
{
    public class LinkedList
    {
        public Node headNode;
        public Node tailNode;
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
        public void AddFirst(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = headNode;
            headNode = newNode;
        }
        public void AddLast(int data)
        {
            Node newNode = new Node(data);
            if (headNode == null)
                tailNode = headNode = newNode;
            else
            {
                tailNode.Next = newNode;
                tailNode = newNode;
            }
        }
        public void Display()
        {
            Node tempNode = this.headNode;
            if (tempNode == null)
            {
                Console.WriteLine("Linked list is empty");
            }
            else
            {
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
}
