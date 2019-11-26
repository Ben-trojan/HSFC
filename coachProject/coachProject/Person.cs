using System;
using System.Collections.Generic;
using System.Text;

namespace PersonProgram
{
    public class Person
    {
        private string name = "";
        private int age = 0;
        private string gender;
        private Address livesin = null;

        public void SetName(String aName)
        {
            name = aName;
        }
        public string GetName()
        {
            return name;
        }
        public void SetAge(int aAge)
        {
            age = aAge;
        }
        public int GetAge()
        {
            return age;
        }
        public void SetGender(String aGender)
        {
            gender = aGender;
        }
        public string GetGender()
        {
            return gender;
        }
        public void SetAddress(Address aAddress)
        {
            livesin = aAddress;
        }
        public Address GetAddress()
        {
            return livesin;
        }
    }
}