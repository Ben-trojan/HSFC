using System;
using System.Collections.Generic;
using System.Text;

namespace CoachExercise
{
    public class Coach
    {
        private Person[] contents = new Person[52];

        private int nextfreelocation = 0;

        public bool AddPerson(Person Passenger)
        {
            if (nextfreelocation > 51)
            {
                return false;
            }
            contents[nextfreelocation++] = Passenger;
            return true;
        }
        public bool RemovePersonByName( String theName) 
        {
            int location = GetSeatByName(theName);
            if (location == -1)
            {
                return false;
            }
            nextfreelocation--;
            contents[location] = contents[nextfreelocation];
            return true;
        }
        public int GetNumberOfPassengers()
        {
            return nextfreelocation;
        }
        public int GetSeatByName(String theName)
        {
            for (int position = 0; position < nextfreelocation; position++)
            {
                if (theName == contents[position].GetName())
                {
                    return position;
                }


            }
            return -1;

      
        }

        public void DisplayPassengers()
        {
            Console.WriteLine(contents[nextfreelocation]);
        }
    }

 

 
}
