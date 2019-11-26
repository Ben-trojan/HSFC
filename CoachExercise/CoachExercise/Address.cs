using System;
using System.Collections.Generic;
using System.Text;

namespace CoachExercise
{
    public class Address
    {
        private string houseName;
        private string street;
        private string city;
        private string country;
        private string postcode;
        public void SethouseName(string aHouse)
        {
            houseName = aHouse;
        }
        public string gethouseName()
        {
            return houseName;
        }
        public void SetStreet(string aStreet)
        {
            street = aStreet;
        }
        public string GetStreet()
        {
            return street;
        }
        public void SetCity(string aCity)
        {
            city = aCity;
        }
        public string GetCity()
        {
            return city;
        }
        public void SetCountry(string aCountry)
        {
            country = aCountry;
        }
        public string GetCountry()
        {
            return country;
        }
        public void SetPostcode(string aPostcode)
        {
            postcode = aPostcode;
        }
        public string GetPostcode()
        {
            return postcode;
        }
    }
}
