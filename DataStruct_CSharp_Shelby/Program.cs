using System;
using System.Text;
using System.Collections.Generic;

namespace DataStruct_CSharp_Shelby
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> test = new LinkedList<int>();
            test.AddLast(2);
            test.AddLast(3);
            test.AddLast(4);

            foreach (int b in test)
            {
                Console.WriteLine(b);
            }
            ReverseLinkedList(test);

            FindNode();

            /* Let us create two sorted linked  
           lists to test the methods  
           Created lists:  
                  llist1: 5->10->15,  
               llist2: 2->3->20  
           */
            MergeList llist1 = new MergeList();
            MergeList llist2 = new MergeList();

            // Node head1 = new Node(5);  
            llist1.addToTheLast(new Node(5));
            llist1.addToTheLast(new Node(10));
            llist1.addToTheLast(new Node(15));

            // Node head2 = new Node(2);  
            llist2.addToTheLast(new Node(2));
            llist2.addToTheLast(new Node(3));
            llist2.addToTheLast(new Node(20));


            llist1.head = new Gfg().sortedMerge(llist1.head,
                                            llist2.head);
            llist1.printList();


            //***************************************************************
            ReverseStack();
            
        }
        //REVERSE LINKED LIST****************************************************
        //***********************************************************************************
        static public void ReverseLinkedList(LinkedList<int> linkedList)
        {
            //Creating a new linked list to add the items in reverse order
            LinkedList<int> copyList = new LinkedList<int>();

            //start from the latest node
            LinkedListNode<int> start = linkedList.Last;
            //Traverse until the first node is found
            while(start!= null)
            {
                //adds item to the new linked list
                copyList.AddLast(start.Value);
                start = start.Previous;
            }
            linkedList = copyList;

            foreach (int b in linkedList)
            {
                Console.WriteLine(b);
            }
        }


        //FIND NODE----------------------------------------------------------------------------
        //---------------------------------------------------------------------------------------------------
        static public void FindNode()
        {
            //new linked list
            LinkedList<string> linked = new LinkedList<string>();

            linked.AddLast("A");
            linked.AddLast("B");
            linked.AddLast("C");

            LinkedListNode<string> node = linked.Find("A");
            linked.AddAfter(node, "inserted");

            foreach (var value in linked)
            {
                Console.WriteLine(value);
            }
        }

        //MERGE SORTED LIST ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }

        public class MergeList
        {

            public Node head;

            public void addToTheLast(Node node)
            {
                if (head == null)
                {
                    head = node;
                }
                else
                {
                    Node temp = head;
                    while (temp.next != null)
                        temp = temp.next;
                    temp.next = node;
                }
            }

            public void printList()
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data + "  ");
                    temp = temp.next;
                }
                Console.WriteLine();

            }
        }
            public class Gfg
            {
                public Node sortedMerge(Node headA, Node headB)
                {
                    Node dummyNode = new Node(0);
                    Node tail = dummyNode;

                    while(true)
                    {
                        if (headA == null)
                        {
                            tail.next = headB;
                            break;
                        }
                        if(headB == null)
                        {
                            tail.next = headA;
                            break;
                        }

                        if(headA.data <= headB.data)
                        {
                            tail.next = headA;
                            headA = headA.next;
                        }
                        else
                        {
                            tail.next = headB;
                            headB = headB.next;
                        }

                        tail = tail.next;
                    }
                    return dummyNode.next;
                }
        }

        //REVERSE STACK 888888888888888888888888888888888888888888888888888888888888888888
        //8888888888888888888888888888888888888888888888888888888888888888888888888888888888888888888
         static public void ReverseStack()
        {
         Stack<char> st = new Stack<char>();
         Stack<char> rev = new Stack<char>();
         st.Push('P');
         st.Push('Q');
         st.Push('R');
         Console.WriteLine("Current stack: ");
         foreach(char c in st) {
            Console.Write(c + " ");
         }
    Console.WriteLine();
         while (st.Count != 0) {
            rev.Push(st.Pop());
         }
Console.WriteLine("Reversed stack: ");
         foreach(char c in rev) {
            Console.Write(c + " ");
         }
      }
        }

    
    }

