using System;
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
                        linkedList.Add(10);
                        linkedList.Add(20);
                        linkedList.Add(30);
                        linkedList.Add(40);
                        linkedList.Add(50);
                        linkedList.Add(60);
                        linkedList.Add(70);
                        linkedList.Add(80);
                        linkedList.Add(90);

                        break;
                    case 2:
                        linkedList.Addfirst(70);
                        linkedList.Addfirst(30);
                        linkedList.Addfirst(56);
                        break;
                    case 3:

                    case 4:
                        linkedList.Display();
                        break;
                    default: Console.WriteLine("Please Enter Currect Option"); break;
                }
            }
        }
    }
}
