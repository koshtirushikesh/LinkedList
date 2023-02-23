﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            LinkedList linkedList = new LinkedList();
            
            while (flag)
            {
                Console.WriteLine("1.Add");
                Console.WriteLine("2.AddFirst");
                Console.WriteLine("3.AddLast");
                Console.WriteLine("4.Display");
                Console.Write("Enter The Option:");
                int option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
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
                        break;
                    case 3:
                        linkedList.AddLast(56);
                        linkedList.AddLast(30);
                        linkedList.AddLast(70);
                        break;
                    case 4:
                        linkedList.Display();
                        break;
                    default: Console.WriteLine("Please Enter Currect Option"); break;
                }
            }
        }
    }
}
