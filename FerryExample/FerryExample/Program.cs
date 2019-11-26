using System;

namespace FerryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int passengernumber;
            string userinputcommuter;
            int passengerprice;
            int carprice;
            int coachprice;
            int lorryprice;
            int totalpassengerprice;
            int totalprice;

            passengerprice = 15;
            carprice = 30;
            coachprice = 60;
            lorryprice = 60;



            do
            {
                Console.WriteLine("hello! welcome to Ben and Terry's ferries!");
                Console.WriteLine("The prices are");
                Console.WriteLine("drivers go free");
                Console.WriteLine("passengers are £15 per person");
                Console.WriteLine("cars are 30 pounds (passenger amount added to totals)");
                Console.WriteLine("coaches are £60 (again, passenger prices are added to the totals)");
                Console.WriteLine("lorries are also £60 (cannot have passengers");
                Console.WriteLine("are you a driver or passenger?");
                Console.WriteLine("(type 'not interested' to quit)");


                userinputcommuter = Console.ReadLine();


                if (userinputcommuter == "driver")
                {
                    Console.WriteLine("are you driving a car, coach, or lorry?");
                    string userinputvehicle;
                    userinputvehicle = Console.ReadLine();

                    if (userinputvehicle == "car")
                    {
                        Console.WriteLine("please enter how many passengers are riding with you");
                        passengernumber = Convert.ToInt32(Console.ReadLine());

                        if (passengernumber > 5)
                        {
                            Console.WriteLine("invalid ammount");
                        }
                        if (passengernumber < 0)
                        {
                            Console.WriteLine("invalid ammount");

                        }

                        else
                        {
                            totalpassengerprice = passengernumber * passengerprice;
                            totalprice = totalpassengerprice + carprice;
                            Console.WriteLine("the price is" + totalprice);
                            Console.ReadLine();
                        }
                    }

                    if (userinputvehicle == "coach")
                    {
                        Console.WriteLine("please enter how many passengers are riding with you");
                        passengernumber = Convert.ToInt32(Console.ReadLine());

                        if (passengernumber > 52)
                        {
                            Console.WriteLine("invalid ammount");
                        }
                        if (passengernumber < 0)
                        {
                            Console.WriteLine("invalid ammount");

                        }

                        else
                        {
                            totalpassengerprice = passengernumber * passengerprice;
                            totalprice = totalpassengerprice + coachprice;
                            Console.WriteLine("the price is" + totalprice);
                            Console.ReadLine();
                        }
                    }


                    if (userinputvehicle == "lorry")
                    {
                        totalprice = lorryprice;
                        Console.WriteLine("your price is" + totalprice);
                        Console.ReadLine();
                    }
                }

                if (userinputcommuter == "passenger")
                {
                    Console.WriteLine("are you riding in a car or a coach?");
                    string userinputvehicle;
                    userinputvehicle = Console.ReadLine();

                    if (userinputvehicle == "car")
                    {
                        Console.WriteLine("please enter how many passengers are riding with you");
                        passengernumber = Convert.ToInt32(Console.ReadLine());

                        if (passengernumber > 5)
                        {
                            Console.WriteLine("invalid ammount");
                        }
                        if (passengernumber < 2)
                        {
                            Console.WriteLine("invalid ammount");

                        }

                        else
                        {
                            totalpassengerprice = passengernumber * passengerprice;
                            totalprice = totalpassengerprice + carprice;
                            Console.WriteLine("the price is" + totalprice);
                            Console.ReadLine();
                        }
                    }

                    if (userinputvehicle == "coach")
                    {
                        Console.WriteLine("please enter how many passengers are riding with you");
                        passengernumber = Convert.ToInt32(Console.ReadLine());

                        if (passengernumber > 52)
                        {
                            Console.WriteLine("invalid ammount");
                        }
                        if (passengernumber < 2)
                        {
                            Console.WriteLine("invalid ammount");

                        }

                        else
                        {
                            totalpassengerprice = passengernumber * passengerprice;
                            totalprice = totalpassengerprice + coachprice;
                            Console.WriteLine("the price is" + totalprice);
                            Console.ReadLine();
                        }
                    }
                }

            } while (userinputcommuter != "not interested");
            
         }
    }
}

