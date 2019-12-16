using System;

namespace QueueProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! welcome to the queue!");
            int menuinput;
            QueueCreep myQueue = new QueueCreep();
            myQueue.add(aName:);
            myQueue.remove();
            do
            {
                Console.WriteLine("please enter what you wish to do");
                Console.WriteLine("press 1 to add an entity to the queue");
                Console.WriteLine("press 2 to remove an entity to the queue");
                Console.WriteLine("press 3 to give the queue's length");
                Console.WriteLine("press 4 to display the queue");
                Console.WriteLine("press 5 to quit");
                menuinput = Convert.ToInt32(Console.ReadLine());

                if (menuinput == 1)
                {
                    
                }
                if (menuinput == 2)
                {

                }
                if (menuinput == 3)
                {

                }
                if (menuinput == 4)
                {

                }

            } while (menuinput != 5);
            Console.WriteLine("thank you!");
            Console.ReadLine();
        }
    }
}
