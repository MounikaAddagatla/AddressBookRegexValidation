using System;

namespace AddressBookRegexValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This for Validating the Addressbook");
            // first name regex Validation//
            Contacts contact = new Contacts();
            contact.IsValidFirstName("Mounika");
            // for last name        
            contact.IsValidLastName("Addagatla");
            // for address
            contact.IsValidAddress("Ambhikanagar");
            // for City
            contact.IsValidCity("Siricilla");
            // for State
            contact.IsValidState("Tg");
            // for valid email
            contact.IsValidEmail("abc.xyz@bl.co.in");
            // for valid phn number
            contact.IsValidPhnNum("+91 6304727468");
            // for valid password 
            contact.IsValidZip("505301");
            Console.ReadLine();
        }
    }
}
