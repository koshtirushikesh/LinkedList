using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            LinkedList linkedList = new LinkedList();
            LinkedListStack stack = new LinkedListStack();
            LinkedListQueues queues = new LinkedListQueues();

            while (flag)
            {

                Console.WriteLine("\n1.Add");
                Console.WriteLine("2.AddFirst");
                Console.WriteLine("3.AddLast");
                Console.WriteLine("4.Remove the First Node");
                Console.WriteLine("5.Remove the Last Node");
                Console.WriteLine("6.Find");
                Console.WriteLine("7.Size");
                Console.WriteLine("8.Add After");
                Console.WriteLine("9.Display linkedlist");
                Console.WriteLine("10.LinedList Stack Push");
                Console.WriteLine("11.LinedList Stack Pop");
                Console.WriteLine("12.LinedList Queue Enqueue");
                Console.WriteLine("13.LinedList Queue Dequeue");
                Console.Write("Enter The Option:");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (option)
                {
                    case 1:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        break;
                    case 2:
                        linkedList.AddFirst(70);
                        linkedList.AddFirst(30);
                        linkedList.AddFirst(56);
                        //linkedList.ReversOrder(70);
                        //linkedList.ReversOrder(30);
                        //linkedList.ReversOrder(56);
                        break;
                    case 3:
                        linkedList.AddLast(56);
                        linkedList.AddLast(30);
                        linkedList.AddLast(70);
                        //linkedList.Add(56);
                        //linkedList.Add(30);
                        //linkedList.Add(70);
                        break;
                    case 4:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.RemoveFirstNode();
                        break;
                    case 5:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.RemoveLastNode();
                        break;
                    case 6:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.Display();
                        linkedList.Find(30);
                        break;
                    case 7:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.Display();
                        linkedList.Size();
                        break;
                    case 8:
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        linkedList.Display();
                        linkedList.AddAfter(30, 40);
                        linkedList.Display();
                        break;
                    case 9:
                        linkedList.Display();
                        break;
                    case 10:
                        stack.Push(56);
                        stack.Push(30);
                        stack.Push(70);
                        stack.Display();
                        break;
                    case 11:
                        stack.Pop();
                        stack.Display();
                        break;
                    case 12:
                        queues.Enqueue(10);
                        queues.Enqueue(20);
                        queues.Enqueue(30);
                        queues.Display();
                        break;
                    case 13:
                        queues.Display();
                        queues.Dequeue();
                        queues.Display();
                        break;


                    default: Console.WriteLine("Please Enter Currect Option"); break;
                }
            }
        }
    }
}
