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
        private int position = 0;

        // addName takes in a name, adds it to the list maintaining the order
        // passes back an integer (-1 if error), giving inserted location
        public int AddNameToList(string theName)
        {
            if (nextFreeLocation > names.Length)
            {

                return -1;
            }

            while (position < nextFreeLocation &&
                (theName.CompareTo(names[position]) > 0))
            {
                position = position + 1;
            }

            for(int i = nextFreeLocation; i > position; i--)
            {
                names[i] = names[i - 1];
            }
            names[position] = theName;

            nextFreeLocation++;

            return position;
        }

        // FindPositionOfName locates a name in the list
        // passes back an integer (-1 if error), giving inserted location
        public int FindPositionOfName(string theName)
        {
           for (int i = 0; i < nextFreeLocation; i++)
            {
                if(names[i] == theName)
                {
                    return i;
                }
            }
            return -1;
        }

           public bool RemoveByPosition(int position)
        {

            return false;
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
