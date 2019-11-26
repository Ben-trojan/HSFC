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
            int userScore;

            Console.WriteLine("Hello World! welcome to the multiplication quiz!");


            for (int j=0; j < 10; j++)
            {
                number1 = rnd.Next(1, 11);
                number2 = rnd.Next(1, 11);
                Console.WriteLine("what is "+number1 + "*" + number2 +"?");
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
            Console.WriteLine("well done for finishing my quiz! please count up your score and input it!");
            userScore = Convert.ToInt32(Console.ReadLine());
            if (userScore == 0-3)
            {
                Console.WriteLine("you need to practice your times tables more. good effort though!");
            }
            else if (userScore == 4 - 6)
            {
                Console.WriteLine("well done! could do better though!");
            }
            else if (userScore == 7 - 9)
            {
                Console.WriteLine("your a great mathematitian! strive for 10 next time!");
            }
            else if(userScore == 10){
                Console.WriteLine("You are absolutely stunning! dont get behind on practice!");
            }
            Console.ReadLine();
        }
    }
}
