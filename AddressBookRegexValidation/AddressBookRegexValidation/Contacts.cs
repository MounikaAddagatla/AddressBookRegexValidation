using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AddressBookRegexValidation
{
    class Contacts
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Address { get; set; }
        private string State { get; set; }
        private string Email { get; set; }
        private string City { get; set; }
        private string PhnNum { get; set; }
        private string Zip { get; set; }
        const string FIRST_NAME = "^[A-Z]{1}[a-z]{3,}$";
        const string LAST_NAME = "^[A-Z]{1}[a-z]{3,}$";
        const string ADDRESS = "^[A-Za-z]{3,}$";
        const string CITY = "^[a-zA-Z]+(?:[\\s-][a-zA-Z]+)*$";
        const string STATE = "^[a-zA-Z]+(?:[\\s-][a-zA-Z]+)*$";
        const string EMAIL = "^[A-Z0-9a-z]+([.#$^_-][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
        const string PHN_NUM = "^([+][0-9]{2}\\s)?[6-9]{1}[0-9]{9}$";
        const string ZIP = "^\\d{5,}(?:[-\\s]\\d{4})?$";

       
        public Contacts(string firstName, string lastName, string address, string state, string email, string city, string phnNum, string zip)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.State = state;
            this.Email = email;
            this.City = city;
            this.PhnNum = phnNum;
            this.Zip = zip;
        }

        public Contacts()
        {
        }

        public bool IsValid()
        {
            return IsValidFirstName(FirstName) && IsValidLastName(LastName) && IsValidAddress(Address) && IsValidCity(City) && IsValidEmail(Email) &&  IsValidPhnNum(PhnNum) && IsValidState(State) && IsValidZip(Zip);
        }
        // First Name Validation
        public bool IsValidFirstName(string firstname)
        {
            if (Regex.IsMatch(firstname, FIRST_NAME))
            {
                return true;
            }
            return false;
        }
        // LastName validation
        public bool IsValidLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, LAST_NAME))
            {
                return true;
            }
            return false;
        }
        public bool IsValidAddress(string address)
        {
            if (Regex.IsMatch(address, ADDRESS))
            {
                return true;
            }
            return false;
        }
        public bool IsValidCity(string city)
        {
            if (Regex.IsMatch(city, CITY))
            {
                return true;
            }
            return false;
        }

        public bool IsValidState(string state)
        {
            if (Regex.IsMatch(state, STATE))
            {
                return true;
            }
            return false;
        }

        // Email validation
        public bool IsValidEmail(string email)
        {
            if (Regex.IsMatch(email, EMAIL))
            {
                return true;
            }
            return false;
        }
        // Phone Number 
        public bool IsValidPhnNum(string phnNum)
        {
            if (Regex.IsMatch(phnNum, PHN_NUM))
            {
                return true;
            }
            return false;
        }
        // zip validation with 
        public bool IsValidZip(string zip)
        {
            if (Regex.IsMatch(zip, ZIP))
            {
                return true;
            }
            return false;
        }
        public String GetFirstName()
        {
            return FirstName;
        }
        public String GetLastName()
        {
            return LastName;
        }
        public String GetAddress()
        {
            return Address;
        }
        public String GetCity()
        {
            return City;
        }
        public String GetState()
        {
            return State;
        }
        public String GetPhnNumber()
        {
            return PhnNum;
        }
        public String GetZip()
        {
            return Zip;
        }
        public String GetEmail()
        {
            return Email;
        }
        public bool SetFirstName(string s)
        {
            if (IsValidFirstName(s))
            {
                FirstName = s;
                return true;
            }
            return false;
        }
        public bool SetLastName(string s)
        {
            if (IsValidLastName(s))
            {
                LastName = s;
                return true;
            }
            return false;
        }
        public bool SetAddress(string s)
        {
            if (IsValidAddress(s))
            {
                Address = s;
                return true;
            }
            return false;
        }
        public bool SetEmail(string s)
        {
            if (IsValidEmail(s))
            {
                Email = s;
                return true;
            }
            return false;
        }
        public bool SetCity(string s)
        {
            if (IsValidCity(s))
            {
                City = s;
                return true;
            }
            return false;
        }
        public bool SetState(string s)
        {
            if (IsValidState(s))
            {
                State = s;
                return true;
            }
            return false;
        }
        public bool SetZip(string s)
        {
            if (IsValidZip(s))
            {
                Zip = s;
                return true;
            }
            return false;
        }
        public bool SetPhnNumber(string s)
        {
            if (IsValidPhnNum(s))
            {
                PhnNum = s;
                return true;
            }
            return false;
        }
    }
}

