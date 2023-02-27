using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class LinkedListQueues
    {
        public Node tail;
        public Node head;
        
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (tail == null)
                tail = head = node;
            else
            {
                node.Next = tail;
                tail = node;
            }
            Console.WriteLine(data+"is Added to Queue");
        }
       

        public void Display()
        {
            Node temp = tail;
            while(temp != null)
            {
                Console.WriteLine(temp.Data+" ");
                temp = temp.Next;
            }
        }
    }
}
