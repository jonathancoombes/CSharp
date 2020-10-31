using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ConsoleApp.Data_Structures_Manual
{
    public class Stack
    {

        private int _maxSize;
        private string[] _stackArray;
        private int _top;

        public Stack(int size)
        {
            _stackArray = new string[size];
            _maxSize = size;
            _top = -1;
        }

        public void Push(string item){

            if (isFull())
            {
                WriteLine("The stack is full");
                ReadLine();
            }
            else {
                _top++;
                _stackArray[_top] = item;
                WriteLine("New item pushed onto the stack!");
                ReadLine();
            }
        
        }

        public void Pop() {

            if (isEmpty()) {
                WriteLine("The stack is empty!");
                ReadLine();
            }
            else{
                int oldTop = _top;
                _stackArray[oldTop] = null;
                _top--;
                WriteLine("Existing item popped off of the stack!");
                ReadLine();
            }          
        }

        public bool isFull() {

            return _top == _maxSize -1 ? true : false;

        }
        public bool isEmpty() {

            return _top == -1 ? true : false;
        }

        public string peek() {
            if (!isEmpty()) {
            return _stackArray[_top -1];
            }
            return "The stack is empty!";
        }

        public void checkContent()
        {
            WriteLine("The array now contains: ");
            foreach (var element in _stackArray)
            {
                if (element != null)
                {
                    WriteLine(element);
                }

                else
                {
                    WriteLine("Null");
                }
            }
        }


    }
}
