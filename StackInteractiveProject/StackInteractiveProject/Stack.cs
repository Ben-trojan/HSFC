using System;
using System.Collections.Generic;
using System.Text;

namespace StackInteractiveProject
{
    class Stack
    {
        private int[] theStack = new int[10];
        private int top = 0;

        public void Push(int aStack)
        {
            int stack = theStack[top];
            top++;
        }
        public int Pop()
        {
            top--;
            return theStack[top];
            
        }

        public int depth()
        {
            return top;
        }
    }
}
