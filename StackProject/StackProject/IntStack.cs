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

        public string Pop()
        {
            top--;
            return Convert.ToString(theStack[top]);
        }
        public int Depth()
        {
            return theStack[top];
        }
    } 
}
