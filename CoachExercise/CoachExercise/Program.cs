using System;

namespace CoachExercise
{
    class Program
    {
       public static void Main(string[] args)
        {
            int option;
            Coach C1 = new Coach();
            do
            {

                Console.WriteLine("What would you like to do?");
                Console.WriteLine("press 1 to add people to the coach");
                Console.WriteLine("press 2 to remove someone from the coach");
                Console.WriteLine("press 3 to display the amount of passengers");
                Console.WriteLine("Press 4 to Display the name of a passenger");
                Console.WriteLine("press 5 to display the name of every passenger");
                Console.WriteLine("press 6 to exit the program");

                option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    Person p = new Person();


                    Console.WriteLine("enter name");
                    p.SetName(Console.ReadLine());
                    if (C1.AddPerson(p) == true)
                    {
                        Console.WriteLine("success!");
                    }
                    else
                    {
                        Console.WriteLine("failure");
                    }
                }
                if (option == 2)
                {
                    Console.WriteLine("please enter the name of the person you wish to remove");
                    if (C1.RemovePersonByName(Console.ReadLine())== true)
                    {
                        Console.WriteLine("success!");
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    
                }

                if (option == 3)
                {
                    Console.WriteLine("there are");
                }

            } while (option != 6);
        }
    }
}
