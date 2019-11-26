using System;

namespace PersonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new person();
            Console.WriteLine("please write your name");
            p1.SetName(Console.ReadLine());
            Console.WriteLine("please write your age");
            p1.SetAge(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(p1.GetName() + " is aged "  + p1.GetAge());
            Console.WriteLine("please write your gender");
            p1.SetGender(Console.ReadLine());
            Console.WriteLine("please enter your address");
            

            Address a1 = new Address();
            Console.WriteLine("please enter your house name");
            a1.SethouseName(Console.ReadLine());
            Console.WriteLine("please enter your street");
            a1.SetStreet(Console.ReadLine());
            Console.WriteLine("please enter your city");
            a1.SetCity(Console.ReadLine());
            Console.WriteLine("please enter your country");
            a1.SetCountry(Console.ReadLine());
            Console.WriteLine("please enter your postcode");
            a1.SetPostcode(Console.ReadLine());

            p1.SetAddress(a1);

            Console.WriteLine("you are" + p1.GetGender() + "and you live at" + p1.GetAddress());

            Console.ReadLine();
        }
    }
}
