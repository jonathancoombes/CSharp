using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp.Data_Structures_Manual
{

    //Consist of two classes
    // 1) LinkedList Class (Consists of the methods to insert, delete nodes and to check if node is last)
    // 2) Node Class  (Consists of the node and data element)

    public class LinkedList { 

        private Node _first;

        public bool isEmpty() {
            return (_first == null);
        }

        public void insertFirst(int data) {

            Node newNode = new Node();
            newNode.data = data;
            newNode.next = _first;
            _first = newNode;
        }



        public void insertLast(int data)
        {

            Node current = _first;

            while (current.next != null)
            {

                current = current.next;

            }

            Node newNode = new Node();
            newNode.data = data;
            current.next = newNode;

        }

        public Node deleteFirst() {

            Node temp = _first;
            _first = _first.next;
            return temp;

        }

        public void displayList() {

            Console.WriteLine("List (first -- to -- last)");
            Node current = _first;

            while (current != null) {
                current.displayNode();
                current = current.next;
            }

            Console.WriteLine();
        }

    }

   public class Node {

        public Node next;
        public int data;

        public void displayNode() {

            Console.WriteLine("<" + data + ">");

        }


    }
}
