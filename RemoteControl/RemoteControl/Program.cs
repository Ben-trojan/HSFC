using System;

namespace RemoteControl
{
    class Program
    {
        static void Main(string[] args)
        {

            int buttoninput;
           
            string[] commands = new string[10];
            int remotecontrolbuttoninput;
            Console.WriteLine("Lazy Lewis(tm) remote control. please select your required function");
            do
            {
                Console.WriteLine("press 1 to program your remote control");
                Console.WriteLine("press 2 to display your commands");
                Console.WriteLine("press 3 to run your commands");
                Console.WriteLine("press 4 to quit");

                buttoninput = Convert.ToInt32(Console.ReadLine());

                if (buttoninput == 1)
                {
                    do
                    {

                        Console.WriteLine("you have chosen to program your remote control");
                        Console.WriteLine("enter the button(-1) to end");
                        remotecontrolbuttoninput = Convert.ToInt32(Console.ReadLine());

                        if (remotecontrolbuttoninput != -1)
                        {
                            Console.WriteLine("please enter the command");
                          commands[remotecontrolbuttoninput]  = Console.ReadLine();
                            Console.WriteLine(" set ");
                        }


                    } while (remotecontrolbuttoninput != -1);
                }
                if (buttoninput == 2)
                {
                    Console.WriteLine("you have chosen to display the commands");

                    for (int i = 0; i < 10; i++)
                    {

                    }
                }

                if (buttoninput == 3)
                {
                    Console.WriteLine("select the (-1) command to finish");
                    remotecontrolbuttoninput = Convert.ToInt32(Console.ReadLine());
                    do
                    {
                        if (remotecontrolbuttoninput == 0)
                        {

                        }
                    } while (remotecontrolbuttoninput != -1);
                }
            } while ( buttoninput != 4);
            Console.WriteLine("thank you for selecting lazy lewis(tm) for all your remote control needs");
            Console.ReadLine();

        }
    }
}
