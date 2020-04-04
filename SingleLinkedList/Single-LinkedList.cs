﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedList
{
    public class Single_LinkedList<T>
    {
        class Node
        {
            public T Data { get; set; } //data in node
            public Node nextNode { get; set; } //pointer to next
        }

        Node headNode;

        public int Size { get; set; }

        public Single_LinkedList()
        {
            headNode = null;
            Size = 0;
        }

        public bool IsEmpty()
        {
            if (headNode == null) return true;
            return false;
        }

        public void InsertAtHead(T data)
        {
            Node newNode = new Node();
            newNode.Data = data;

            newNode.nextNode = headNode;
            headNode = newNode;

            Size++;
        }

        public void InsertAtEnd(T data)
        {
            Node newNode = new Node();
            newNode.Data = data;

            if (IsEmpty())
            {
                InsertAtHead(data);
                return;
            }


            Node temp = headNode;
            while (temp.nextNode != null)
            {
                temp = temp.nextNode;

            }
            temp.nextNode = newNode;
            Size++;

        }

        public Boolean SearchNode(T data)
        {
            Node tmp = headNode;
            Boolean isValExist = false;
            while (tmp.nextNode != null)
            {
                if (tmp.Data.Equals(data))
                {
                    isValExist = true;
                    break;
                }
                tmp = tmp.nextNode;
            }
            return isValExist;
        }

        public void printList()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty!");
                return;
            }

            Node temp = headNode;
            // Console.WriteLine("List : ");
            while (temp.nextNode != null)
            {
                Console.Write(temp.Data + " -> ");
                temp = temp.nextNode;

            }
            Console.WriteLine(temp.Data + " -> null ");
        }

        public void deleteAtHead()
        {

            if (IsEmpty()) return;

            Node node = headNode;
            headNode = node.nextNode;
            Size--;

        }

        public void deleteByValue(T data)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty!");
                return;
            }
            Node node = headNode;
            Node prev = node;

            while (node != null)
            {
                if (node.Data.Equals(data))
                {
                    prev.nextNode = node.nextNode;
                    Size--;
                    return;
                }

                prev = node;
                node = node.nextNode;
            }
        }

        public int Length()
        {
            int count = 0;
            // Write -- Your -- Code
            if (this.headNode == null)
                return 0;
            else
            {
                Node tmp = headNode;
                while (tmp != null)
                {
                    count++;
                    tmp = tmp.nextNode;
                }
            }
            return count;
        }

        public static Single_LinkedList<T> Reverse(Single_LinkedList<T> list)
        {
            //Write -- Your -- Code
            if (list == null) return null;
            Single_LinkedList<T> newList = null;
            Node tmp = list.headNode;
            while (tmp != null)
            {
                if (newList == null)
                {
                    newList = new Single_LinkedList<T>();
                    Node n = new Node();
                    n.Data = tmp.Data;
                    n.nextNode = null;
                    newList.headNode = n;
                    newList.headNode.nextNode = null;
                }
                else
                {
                    Node n = new Node();
                    n.Data = tmp.Data;

                    n.nextNode = newList.headNode;
                    newList.headNode = n;
                }
                tmp = tmp.nextNode;
            }
            return newList;
        }

        //public static Boolean detectLoop(Single_LinkedList<T> list)
        //{
        //    if (list == null) return false;
        //    Single_LinkedList<T>.Node h = list.headNode;
        //    h.Data = list.headNode.Data;
        //    h.nextNode = list.headNode.nextNode;

        //    Single_LinkedList<T>.Node tmp = list.headNode;
        //    while (tmp != null)
        //    {
        //        if (tmp.nextNode == h)
        //            return true;
        //        tmp = tmp.nextNode;
        //    }
        //    return false;
        //}

        public static Boolean DetectLoop(Single_LinkedList<T> list)
        {
            if (list == null) return false;
            Single_LinkedList<T>.Node first = list.headNode;
            Single_LinkedList<T>.Node second = list.headNode;

            while (first != null && second != null && second.nextNode != null)
            {
                first = first.nextNode;
                second = second.nextNode.nextNode;

                if (first == second) return true;

            }

            return false;
        }


        public void testDetectLoop()
        {
            Single_LinkedList<int> list = new Single_LinkedList<int>();
            list.InsertAtHead(1);
            list.InsertAtHead(2);
            list.InsertAtHead(3);
            Console.WriteLine("Before adding loop: " + Single_LinkedList<int>.DetectLoop(list));
            list.headNode.nextNode = list.headNode;
            Console.WriteLine("After adding loop: " + Single_LinkedList<int>.DetectLoop(list));
        }

        public static Object findMiddle(Single_LinkedList<T> list)
        {
            if (list.IsEmpty())
                return null;
            Single_LinkedList<T>.Node JumpOne = list.headNode;
            Single_LinkedList<T>.Node JumpTwo = list.headNode;
            while (JumpOne != null && JumpTwo != null && JumpTwo.nextNode != null)
            {
                JumpTwo = JumpTwo.nextNode.nextNode;
                if (JumpTwo != null)
                    JumpOne = JumpOne.nextNode;
            }
            return JumpOne.Data;
        }

        public void RemoveDuplicatesFromSortedLinkedList()
        {
            if (IsEmpty())
                return;
            Single_LinkedList<T>.Node firstPointer = headNode;
            Single_LinkedList<T>.Node secondPointer = headNode.nextNode;

            while (firstPointer != null & secondPointer != null)
            {
                if (!firstPointer.Data.Equals(secondPointer.Data))
                {

                    firstPointer.nextNode = secondPointer;
                    firstPointer = secondPointer;

                }
                secondPointer = secondPointer.nextNode;
            }
        }
      

        public static void RemoveDuplicatesAndAddResultInAnotherList(Single_LinkedList<T> list)
        {
            if (list.IsEmpty())
                return;
            Single_LinkedList<T> newList = new Single_LinkedList<T>();
            Single_LinkedList<T>.Node head = list.headNode;
            while (head != null)
            {
                Single_LinkedList<T>.Node newListHead = newList.headNode;
                Boolean exist = false;
                while (newListHead != null)
                {
                    if (newListHead.Data.Equals(head.Data))
                    {
                        exist = true;
                        break;
                    }
                    newListHead = newListHead.nextNode;
                }
                if (!exist)
                {
                    newList.InsertAtEnd(head.Data);
                }

                head = head.nextNode;
            }

            if (!newList.IsEmpty())
                newList.printList();

            Single_LinkedList<T>.Node newH = newList.headNode;
            list = new Single_LinkedList<T>();
            while (newH != null)
            {
                list.InsertAtEnd(newH.Data);
                newH = newH.nextNode;
            }
            

        }

        //4-> 2321 -> 55 -> 1000 -> null
        //1000 -> 55 -> 4 -> 2321 -> null
        //2321 -> 4 -> 55 -> 1000 -> null

        //1000->55->4->2321->55-> null
        public static void removeDuplicates(Single_LinkedList<T> list)
        {
            if (list.IsEmpty())
                return;
            Single_LinkedList<T>.Node first = list.headNode;
            while (first != null)
            {
                Single_LinkedList<T>.Node second = first;
                Single_LinkedList<T>.Node third = first.nextNode;

                while (second != null && third != null)
                {
                    if (first.Data.Equals(third.Data))
                    {
                        second.nextNode = third.nextNode;
                        if (second.nextNode == null)
                            break;
                    }
                    second = third;
                    third = third.nextNode;
                }
                first = first.nextNode;
            }
        }
        public void printList2()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty!");
                return;
            }

            Node temp = headNode;
            Console.WriteLine("List : ");

            while (temp.nextNode != null)
            {
                Console.WriteLine(temp.Data + " -> ");
                temp = temp.nextNode;
            }

            Console.WriteLine(temp.Data + " -> null");
        }

        //1000->55->4->2321->55-> null
        public static void removeDuplicates2(Single_LinkedList<T> list)
        {
            Single_LinkedList<T>.Node current = list.headNode; // will be used for outer loop
            Single_LinkedList<T>.Node compare = null;     // will be used for inner loop

            while (current != null && current.nextNode != null)
            {
                compare = current;
                while (compare.nextNode != null)
                {
                    if (current.Data.Equals(compare.nextNode.Data))
                    { //check if duplicate
                        compare.nextNode = compare.nextNode.nextNode;
                    }
                    else
                    {
                        compare = compare.nextNode;
                    }
                }
                current = current.nextNode;
            }
        }

        //1000->55->4->2321->55-> null

        public static void removeDuplicates3(Single_LinkedList<T> list)
        {
            if (list.IsEmpty())
                return;
            Single_LinkedList<T>.Node first = list.headNode;
            while (first != null && first.nextNode != null)
            {
                Single_LinkedList<T>.Node second = first;

                while (second != null && second.nextNode != null)
                {
                    if (first.Data.Equals(second.nextNode.Data))
                    {
                        second.nextNode = second.nextNode.nextNode;

                    }
                    else
                        second = second.nextNode;
                }
                first = first.nextNode;
            }
        }

        //1 -> 2
        //3 -> 4 -> 2
        public static Single_LinkedList<T> union(Single_LinkedList<T> list1, Single_LinkedList<T> list2)
        {
            if (list1.IsEmpty())
                return list2;
            if (list2.IsEmpty())
                return list1;
            Single_LinkedList<T> unionList = list1;
            Single_LinkedList<T>.Node node2 = list2.headNode;
            Single_LinkedList<T>.Node unionNode = unionList.headNode;
            int count = 0;
            while (node2 != null)
            {
                count = 0;
                unionNode = unionList.headNode;
                while (unionNode != null)
                {
                    if (!unionNode.Data.Equals(node2.Data))
                    {
                        count++;

                    }
                    unionNode = unionNode.nextNode;
                }
                if (count == unionList.Size)
                {
                    unionList.InsertAtEnd(node2.Data);
                    //  unionList.size++;
                }
                node2 = node2.nextNode;
            }
            return unionList;
        }

        public static Single_LinkedList<T> intersection(Single_LinkedList<T> list1, Single_LinkedList<T> list2)
        {
            Single_LinkedList<T> result = new Single_LinkedList<T>();

            if (list1.Size > list2.Size)
            {
                result = intersect(list2, list1);
            }
            else
            {
                result = intersect(list1, list2);

            }

            return result;
        }

        private static Single_LinkedList<T> intersect(Single_LinkedList<T> list1, Single_LinkedList<T> list2)
        {
            Single_LinkedList<T> result = new Single_LinkedList<T>();

            Single_LinkedList<T>.Node list1N = list1.headNode;
            Single_LinkedList<T>.Node list2N;
            while (list1N != null)
            {
                list2N = list2.headNode;
                while (list2N != null)
                {
                    if (list2N.Data.Equals(list1N.Data))
                    {
                        result.InsertAtEnd(list1N.Data);
                    }
                    list2N = list2N.nextNode;
                }
                list1N = list1N.nextNode;
            }
            return result;
        }

        public static T nthElementFromEnd(Single_LinkedList<T> list, int n)
        {

            int counter = 1;

            Single_LinkedList<T>.Node node = list.headNode;
            Single_LinkedList<T> newList = new Single_LinkedList<T>();

            while (node != null)
            {
                newList.InsertAtHead(node.Data);
                node = node.nextNode; 

            }
            while (newList != null)
            {
                if (counter == n)
                {
                    break;
                }
                node = node.nextNode;
                counter++;

            }

            return node.Data;
        }
    }
}