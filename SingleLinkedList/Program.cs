using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Single_LinkedList<int> linkedList = new Single_LinkedList<int>();

            for (int i = 1; i <= 3; i++)
            {
                linkedList.InsertAtHead(i);

            }


            linkedList.printList();
            Console.WriteLine("Reverse LinkedList: ");
            Single_LinkedList<int> t = Single_LinkedList<int>.Reverse(linkedList);
            t.printList();
            Console.WriteLine("--------------------------------------------");

            //////////////////////////////Test if linkedlist contains loop--------------------------------------
            linkedList.TestDetectLoop();
            Console.WriteLine("--------------------------------------------");

            Single_LinkedList<int> list = new Single_LinkedList<int>();
            list.InsertAtEnd(1);
            list.InsertAtEnd(2);

            list.InsertAtEnd(2);
            list.InsertAtEnd(3);
            list.InsertAtEnd(3);
            list.InsertAtEnd(3);
            list.InsertAtEnd(4);
            list.InsertAtEnd(5);
            list.InsertAtEnd(5);
            list.InsertAtEnd(20);
            Console.WriteLine("Before removing duplicates from sorted linked list: ");
            list.printList();
            list.RemoveDuplicatesFromSortedLinkedList();
            Console.WriteLine("After removing duplicates from sorted linked list: ");
            list.printList();
            Console.WriteLine("--------------------------------------------");


            Single_LinkedList<int> list2 = new Single_LinkedList<int>();

            list2.InsertAtEnd(4);
            list2.InsertAtEnd(1478);
            list2.InsertAtEnd(4);
            list2.InsertAtEnd(20);
            list2.InsertAtEnd(2000);
            list2.InsertAtEnd(4);
            Console.WriteLine("Before removing duplicates from linked list: ");
            list2.printList();
            Single_LinkedList<int>.RemoveDuplicates(list2);
            Console.WriteLine("After removing duplicates from linked list: ");
            list2.printList();
            Console.WriteLine("--------------------------------------------");


            Console.WriteLine("Unioin Two Linked List: ");

            Single_LinkedList<int> list1 = new Single_LinkedList<int>();
            list1.InsertAtEnd(6);
            list1.InsertAtEnd(5);
            list1.InsertAtEnd(4);
            list1.InsertAtEnd(3);
            list1.InsertAtEnd(2);
            list1.InsertAtEnd(1);
            list1.InsertAtEnd(0);
            list1.printList();

            Single_LinkedList<int> list3 = new Single_LinkedList<int>();
            list3.InsertAtEnd(6);
            list3.InsertAtEnd(7);
            list3.InsertAtEnd(0);
            list3.printList();

            Single_LinkedList<int> unionList = Single_LinkedList<int>.Union(list1, list3);
            Console.WriteLine("Unioin Result: ");

            unionList.printList();
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Intersection Between Two Linked List: ");
            list1 = new Single_LinkedList<int>();
            list1.InsertAtEnd(1);
            list1.InsertAtEnd(2);
            list1.InsertAtEnd(3);
            list1.printList();

            list2 = new Single_LinkedList<int>();
            list2.InsertAtEnd(2);
            list2.InsertAtEnd(1);
            list2.printList();

            Single_LinkedList<int> intercet = Single_LinkedList<int>.Intersection(list1, list2);

            Console.WriteLine("Intersection Result: ");
            intercet.printList();

            Console.ReadLine();
        }
    }
}
