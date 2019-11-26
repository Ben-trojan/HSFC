using System;

namespace Quiz1
{
    class Program
    {
        static void Main(string[] args)
        {

            int number1;
            int number2;
            Random rnd = new Random();
            int answer;
            int userResponse;
            int userScore = 0;
            int option;
            int skilllevel = 1;
            do
            {



                Console.WriteLine("Hello World! welcome to the quiz menu!");

                Console.WriteLine("what would you like to 'order'?");

                Console.WriteLine("press (1) for Addition");
                Console.WriteLine("press (2) for subtraction");
                Console.WriteLine("press (3) for multiplication");
                Console.WriteLine("press (4) for current Score");
                Console.WriteLine("press (5) for skill level");
                Console.WriteLine("press (6) to quit");
                option = Convert.ToInt32(Console.ReadLine());
                if (option == 1)
                {
                    Console.WriteLine("welcome too the addition quiz!");
                    for (int j = 0; j < 10; j++)
                    {

                        number1 = rnd.Next(1, 11);
                        number2 = rnd.Next(1, 11);
                        Console.WriteLine("what is " + number1 + "+" + number2 + "?");
                        Console.WriteLine("Please Input your answer");
                        answer = number1 + number2;

                        userResponse = Convert.ToInt32(Console.ReadLine());

                        if (userResponse == answer)
                        {
                            Console.WriteLine("correct! you earn a point");
                            userScore = userScore + 1;

                        }
                        else
                        {
                            Console.WriteLine("incorrect! no points for you! the correct answer is...");
                            Console.WriteLine(answer);
                        }
                    }


                }


                if (option == 2)
                {
                    Console.WriteLine("welcome too the subtraction quiz!");
                    for (int j = 0; j < 10; j++)
                    {
                        number1 = rnd.Next(1, 11);
                        number2 = rnd.Next(1, 11);
                        Console.WriteLine("what is " + number1 + "-" + number2 + "?");
                        Console.WriteLine("Please Input your answer");
                        answer = number1 - number2;

                        userResponse = Convert.ToInt32(Console.ReadLine());

                        if (userResponse == answer)
                        {
                            Console.WriteLine("correct! you earn a point");
                        }
                        else
                        {
                            Console.WriteLine("incorrect! no points for you! the correct answer is...");
                            Console.WriteLine(answer);
                        }
                    }
                }


                if (option == 3)
                {
                    Console.WriteLine("welcome too the multiplication quiz!");
                    for (int j = 0; j < 10; j++)
                    {
                        number1 = rnd.Next(1, 11);
                        number2 = rnd.Next(1, 11);
                        Console.WriteLine("what is " + number1 + "*" + number2 + "?");
                        Console.WriteLine("Please Input your answer");
                        answer = number1 * number2;

                        userResponse = Convert.ToInt32(Console.ReadLine());

                        if (userResponse == answer)
                        {
                            Console.WriteLine("correct! you earn a point");
                        }
                        else
                        {
                            Console.WriteLine("incorrect! no points for you! the correct answer is...");
                            Console.WriteLine(answer);
                        }
                    }
                }
                if (option == 4)
                {
                    Console.WriteLine(userScore);
                }
                if (option == 5)
                {
                    Console.WriteLine("please input the skill level");
                    Console.WriteLine("press 1 to add a level");
                    Console.WriteLine("press 2 to reduce the level to 1");
                    Console.WriteLine("press 3 to display current skill level");
                    if (option == 1)
                    {
                        skilllevel = skilllevel + 1;
                    }
                    if (option == 2)
                    {
                        skilllevel = 1;
                    }
                    if (option == 3)
                    {
                        Console.WriteLine(skilllevel);
                    }
                }
                Console.ReadLine();

            } while (option != 6);
        }
    }
}

