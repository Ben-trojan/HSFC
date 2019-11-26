using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListProject
{
    class ListExercises
    {
        private string[] names = new string[10];
        private int nextFreeLocation = 0;

        // addName takes in a name, adds it to the list maintaining the order
        // passes back an integer (-1 if error), giving inserted location
        public int AddNameToList(string theName)
        {
            // not yet implemented
            return -1;
        }

        // FindPositionOfName locates a name in the list
        // passes back an integer (-1 if error), giving inserted location
        public int FindPositionOfName(string theName)
        {
            // not yet implemented
            return -1;
        }

        // GetListAsString just returns a formatted string of List
        public String GetListAsString()
        {
            string temp = "";
            for (int i = 0; i < nextFreeLocation; i++)
            {
                temp = temp + names[i] + "\n";
            }
            return temp;
        }
    }
}