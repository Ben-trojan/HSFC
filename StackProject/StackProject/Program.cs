using System;

namespace StackProject
{
    class Program
    {
      public static void Main(string[] args)
        {
            IntStack myStack = new IntStack();

            myStack.Push(5);
            myStack.Push(4);
            Console.WriteLine(myStack.Pop());
            Console.ReadLine();
            myStack.Push(8);
            Console.WriteLine(myStack.Pop());
            Console.ReadLine();
            Console.WriteLine("depth is " + myStack.Depth());
            Console.ReadLine();
        }
    }
}
