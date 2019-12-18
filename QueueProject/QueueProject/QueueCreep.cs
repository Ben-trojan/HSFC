using System;
using System.Collections.Generic;
using System.Text;

namespace QueueProject
{
    class QueueCreep
    {
        string[] contents = new string[10];
        int front = 0;
        int back = 0;
        int length = 0;
        string name;
        public void add(string aName)
        {
            name = aName;
            if(length == 0)
            {
                contents[front] = name;
            }
            else
            {
                back = back + 1;
                contents[back] = name;
            }
            length = length + 1;
        }
        public string Remove()
        {
            string temp = contents[front];
            contents[front] = "";
            front = front + 1;
            length = length - 1;
            return temp;
        }

        public int Length()
        {
            Console.WriteLine(length);

            return length;
        }

        public void display()
        {
             for(int i = front; i <= back; i++)
            {
                Console.WriteLine(contents[i]);
            }
        }
    }
}
