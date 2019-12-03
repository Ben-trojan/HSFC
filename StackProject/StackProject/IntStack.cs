using System;
using System.Collections.Generic;
using System.Text;

namespace StackProject
{
    class IntStack
    {
        private int top ;
        private int[] theStack = new int[10];

        public void Push(int aStack)
        {
            theStack[top] = aStack;
            
            top++;
        }

        public int Pop()
        {
            top--;
            return theStack[top];
        }
        public int Depth()
        {
            return top;
        }
    } 
}
