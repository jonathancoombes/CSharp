using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Transactions;

namespace ConsoleApp.Data_Structures_Manual
{

    public class LinkedList2
    {
        private Node2 _head;
        private Node2 _tail;

        public LinkedList2(int data)
        {
            var Node2 = new Node2(data);
            _head = _tail = Node2;
            _tail.Next = null;
        }

        public class Node2
        {
            public int Data;
            public Node2 Next { get;set; }

            public Node2(int value)
            {
                Data = value;
                Next = null;
            }

        }


        //AddFirst (Prepend) - Add before head
        
        public void Prepend(int val)
        {
            var newN = new Node2(val);

            if (IsEmpty())
            {
                _head = _tail = newN;
            }
            else
            {
                newN.Next = _head;
                _head = newN;
            }

        }
        

        //AddLast (Append) - Add after tail

        public void Append(int val)
        {
            var newNa = new Node2(val);

            if (IsEmpty())
            {
                _head = _tail = newNa;
            }
            else
            {
                _tail.Next = newNa;
                _tail = newNa;

            }

        }


        private bool IsEmpty()
        {
            return _head == null;

        }
        
        //IndexOf:  finds the index of the item if contained in the list

        public int IndexOf(int val)
        {
            var count = 0;
            var current = _head;

            while (current != null)
            {
                if (current.Data == val)
                {
                    return count;
                }
                else
                {
                    count++;
                    current = current.Next;
                }
            }
            return -1;
        }

        //Contains:  returns whether an item is contained in the list

        public bool Contains(int val)
        {
           var current = _head;

            while (current != null)
            {
                if (current.Data == val)
                {
                    return true;
                }
                current = current.Next;
                
            }
            return false;
        }


        //SizeOf:  returns the size / count of the list

        public int SizeOf()
        {
            var current = _head;
            var count = 0;

            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }

        //RemoveFirst: Removes the Head Node

        public void RemoveHead()
        {
            _head = _head?.Next;  //  Using Null Propagation checks inline for null value and completes assignment if not null
        }

        //RemoveLast: Removes the Tail Node

        public void RemoveTail()
        {
            var size = SizeOf();
            var current = _head;

         while (current != _tail && current != null)
            {

                if (current.Next == _tail)
                {
                    _tail = current;
                    _tail.Next = null;
                }

                current = current.Next;
            }

            
        }


        public void PrintContents()
        {
            var current = _head;

            while (current != null)
            {
                Console.WriteLine($"{current.Data} ->");
                current = current.Next;

            }

        }

       


    }

}





