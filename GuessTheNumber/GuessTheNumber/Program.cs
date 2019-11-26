using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int intNumber;
            int intGuess;
            intNumber = rnd.Next(1, 101);
            do
            {


                Console.WriteLine("enter your guess between 1 and 100");
                intGuess = Convert.ToInt32(Console.ReadLine());
                if (intGuess > intNumber)
                {
                    Console.WriteLine("too high!!!!");
                }
                if (intGuess < intNumber)
                {
                    Console.WriteLine("Too Low!");
                }
                if (intGuess == intNumber)
                {
                    Console.WriteLine("YOU GOT IT! GODDAMNIT!");
                }

            } while (intGuess != intNumber);
                Console.ReadLine();
        }   
    }
}
