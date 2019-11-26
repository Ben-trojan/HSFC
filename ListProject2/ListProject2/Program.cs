using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProject
{
    class Program
    {
        public static void Main(String[] args)
        {
            String[] names = new string[10];
             ListExercises myList = new ListExercises();
            
            Console.WriteLine("Enter ten names, one per line");
            for (int i = 0; i < 10; i++)
            {
                myList.AddNameToList(Console.ReadLine());
            }
            Console.WriteLine("Results are " + myList.GetListAsString());
            Console.ReadLine();
        }
    }

}


