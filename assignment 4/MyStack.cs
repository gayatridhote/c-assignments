using System;
using System.Collections.Generic;
using System.Text;

namespace assignment_3b_and_4
{  
    public class StackException :Exception
    {
        public StackException(String message):base(message)
        {

        }
    }
    public class MyStack : ICloneable
    {
        private int[] a = new int[10];
        private int topPosition = 0;
        private int size;
        public object Clone()
        {
            MyStack myStack = new MyStack {
                a = this.a,
                topPosition=this.topPosition,
                size=this.size
            };
            return myStack;
        }
        public void push(int i)
        {
            try
            {
                if(topPosition==a.Length)
                {
                    throw new StackException("Fullstack Exception");
                }
                a[++topPosition] = i;
                Console.WriteLine($"{i} is pushed onto the stack");
            }
            catch(StackException st)
            {
                Console.WriteLine(st);
            }
        }
        public void pop()
        {
           try
            {
                if(topPosition==0)
                {
                    throw new StackException("Emptystack Exception");
                }
                a[topPosition--] = 0;
                Console.WriteLine($"{a[topPosition]} is pooped ");

            }
            catch(StackException st)
           {
                Console.WriteLine(st);
           }
        }
        public void display()
        {
            foreach(int i in a)
            {
                Console.Write(i + " ");
            }
        }
    }
}
