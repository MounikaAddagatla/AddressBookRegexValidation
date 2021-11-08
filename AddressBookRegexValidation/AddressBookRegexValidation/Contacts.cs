using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AddressBookRegexValidation
{
    class Contacts
    {
        const string FIRST_NAME = "^[A-Z]{1}[a-z]{3,}$";
        const string LAST_NAME = "^[A-Z]{1}[a-z]{3,}$";
        // const string SUPPORTED_DOMAIN = "@bl.co.";
        const string Address = "^[A-Za-z]{1,}$";
        const string City = "^[a-zA-Z]+(?:[\\s-][a-zA-Z]+)*$";
        const string State = "^[a-zA-Z]+(?:[\\s-][a-zA-Z]+)*$";
        const string EMAIL = "^[A-Z0-9a-z]+([.#$^_-][A-Za-z0-9]+)?[@][A-Za-z]{2,}[.][A-Za-z]{2,3}([.][a-zA-Z]{2})?$";
        const string PHN_NUM = "^([+][0-9]{2}\\s[6-9]{1}[0-9]{9}$)";
        const string Zip = "^\\d{5,}(?:[-\\s]\\d{4})?$";
        // First Name Validation
        public void IsValidFirstName(string firstname)
        {
            if (Regex.IsMatch(firstname, FIRST_NAME))
            {
                Console.WriteLine("FirstName is validated");
                return;
            }
            Console.WriteLine("FirstName is not validated");
        }
        // LastName validation
        public void IsValidLastName(string lastName)
        {
            if (Regex.IsMatch(lastName, LAST_NAME))
            {
                Console.WriteLine("lastname is validated");
                return;
            }
            Console.WriteLine("lastname is not validated");
        }
        public void IsValidAddress(string address)
        {
            if (Regex.IsMatch(address, Address))
            {
                Console.WriteLine("address is validated");
                return;
            }
            Console.WriteLine("address is not validated");
        }
        public void IsValidCity(string city)
        {
            if (Regex.IsMatch(city, City))
            {
                Console.WriteLine("city is validated");
                return;
            }
            Console.WriteLine("city is not validated");

        }

        public void IsValidState(string state)
        {
            if (Regex.IsMatch(state, State))
            {
                Console.WriteLine("state is validated");
                return;
            }
            Console.WriteLine("state is not validated");

        }

        // Email validation
        public void IsValidEmail(string email)
        {
            if (Regex.IsMatch(email, EMAIL))
            {
                Console.WriteLine("EMAIL_ID is validated");
                return;
            }
            Console.WriteLine("EMAIL_ID is not validated");

        }
        // Phone Number 
        public void IsValidPhnNum(string phnNum)
        {
            if (Regex.IsMatch(phnNum, PHN_NUM))
            {
                Console.WriteLine("PHN_NUM is validated");
                return;
            }
            Console.WriteLine("PHN_NUM is not validated");
        }
        // zip validation with 
        public void IsValidZip(string zip)
        {
            if (Regex.IsMatch(zip, Zip))
            {
                Console.WriteLine("Zip is validated");

                return;
            }
            Console.WriteLine("Zip is not validated");
        }
    }
}

