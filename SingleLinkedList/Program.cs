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
            //Single_LinkedList<int> linkedList = new Single_LinkedList<int>();

            //for (int i = 1; i <= 3; i++)
            //{
            //    linkedList.InsertAtHead(i);

            //}


            //linkedList.printList();

            //Single_LinkedList<int> t= Single_LinkedList<int>.reverse(linkedList);
            //t.printList();


            //////////////////////////////Test if linkedlist contains loop--------------------------------------
            //Boolean hasloop = Single_LinkedList<int>.detectLoop(linkedList);
            //Console.WriteLine(hasloop);
            //// for (int i = 1; i <= linkedList.size; i++)
            //{
            //    linkedList.printList();
            //}
            //  linkedList.testDetectLoop();


            ///get middle of linkedlist--------------------------------------------------------------
            //Single_LinkedList<int> list = new Single_LinkedList<int>();
            //list.InsertAtEnd(1);
            //list.InsertAtEnd(2);

            //list.InsertAtEnd(123);
            //list.InsertAtEnd(101);
            //list.InsertAtEnd(61);
            //list.printList();
            //Console.WriteLine("Middle element is : " + Single_LinkedList<int>.findMiddle(list));

            //Single_LinkedList<int> list = new Single_LinkedList<int>();
            //list.InsertAtEnd(1);
            //list.InsertAtEnd(2);

            //list.InsertAtEnd(2);
            //list.InsertAtEnd(3);
            //list.InsertAtEnd(3);
            //list.InsertAtEnd(3);
            //list.InsertAtEnd(4);
            //list.InsertAtEnd(5);
            //list.InsertAtEnd(5);
            //list.InsertAtEnd(61);
            //list.printList();
            //list.removeDuplicatesFromSortedLinkedList();
            //list.printList();

            //4->2321->4->55->1000
            //Single_LinkedList<int> list = new Single_LinkedList<int>();

            //list.InsertAtEnd(4);
            //list.InsertAtEnd(2321);
            //list.InsertAtEnd(4);
            //list.InsertAtEnd(55);
            //list.InsertAtEnd(1000);
            //list.printList();

            //Single_LinkedList<int>.removeDuplicatesAndAddResultInAnotherList(list);
            //Console.WriteLine("In main: ");
            //list.printList();

            //4->2321->4->55->1000
            //list.InsertAtEnd(4);
            //list.InsertAtEnd(2321);
            //list.InsertAtEnd(4);
            //list.InsertAtEnd(55);
            //list.InsertAtEnd(1000);

            //1000->55->4->2321->55-> null
            //Single_LinkedList<int> list = new Single_LinkedList<int>();
            //list.InsertAtEnd(1000);
            //list.InsertAtEnd(55);
            //list.InsertAtEnd(4);
            //list.InsertAtEnd(2321);
            //list.InsertAtEnd(2321);
            //list.InsertAtEnd(55);

            //list.printList();

            //Single_LinkedList<int>.removeDuplicates3(list);
            //Console.WriteLine("In main: ");
            //list.printList();

            //Single_LinkedList<int> list1 = new Single_LinkedList<int>();
            //list1.InsertAtEnd(6);
            //list1.InsertAtEnd(5);
            //list1.InsertAtEnd(4);
            //list1.InsertAtEnd(3);
            //list1.InsertAtEnd(2);
            //list1.InsertAtEnd(1);
            //list1.InsertAtEnd(0);

            //Single_LinkedList<int> list2 = new Single_LinkedList<int>();
            //list2.InsertAtEnd(6);
            //list2.InsertAtEnd(7);

            //Single_LinkedList<int> unionList = Single_LinkedList<int>.union(list1, list2);
            //unionList.printList();

            //Single_LinkedList<int> list1 = new Single_LinkedList<int>();
            //list1.InsertAtEnd(1);
            //list1.InsertAtEnd(2);
            //list1.InsertAtEnd(3);

            //Console.WriteLine("List1: ");
            //list1.printList();

            //Single_LinkedList<int> list2 = new Single_LinkedList<int>();
            //list2.InsertAtEnd(2);
            //list2.InsertAtEnd(1);

            //Console.WriteLine("List2: ");
            //list2.printList();

            //Single_LinkedList<int> intercet = Single_LinkedList<int>.intersection(list1, list2);

            //Console.WriteLine("Intercet: ");
            //intercet.printList();

            //   22->18->60->78->47->39->99
            //Single_LinkedList<int> list1 = new Single_LinkedList<int>();
            //list1.InsertAtEnd(22);
            //list1.InsertAtEnd(18);
            //list1.InsertAtEnd(60);
            //list1.InsertAtEnd(78);
            //list1.InsertAtEnd(47);
            //list1.InsertAtEnd(39);
            //list1.InsertAtEnd(99);

            // int value = Single_LinkedList<int>.nthElementFromEnd(list1, 3);
            // Console.WriteLine("value will be: " + value);


            Single_LinkedList<int> list2 = new Single_LinkedList<int>();
            list2.InsertAtEnd(15);
            list2.InsertAtEnd(22);
            list2.InsertAtEnd(8);
            list2.InsertAtEnd(7);
            list2.InsertAtEnd(14);
            list2.InsertAtEnd(21);
             int value = Single_LinkedList<int>.nthElementFromEnd(list2, 4);
            Console.WriteLine("value will be: " + value);

            Console.ReadLine();
        }
    }
}
