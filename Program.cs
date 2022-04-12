using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the LinkedList Program\n");

            SimpleLinkedList linkedList = new SimpleLinkedList();
            //linkedList.Add(56);
            //linkedList.Add(30);
            //linkedList.Add(70);

            //linkedList.AddInReverseOrder(70);
            //linkedList.AddInReverseOrder(30);
            //linkedList.AddInReverseOrder(56);
            //linkedList.Append(56);
            //linkedList.Append(30);
            //linkedList.Append(70);
            //linkedList.Append(56);
            //linkedList.Append(70);
            //linkedList.Insert(1, 30);
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.RemoveFirstNode();
            Console.WriteLine("After removing the first node of Linked List : ");

            linkedList.Display();
            

            Console.ReadLine();
        }
    }
}
    

