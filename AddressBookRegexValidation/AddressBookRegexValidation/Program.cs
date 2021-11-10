using System;
using System.Collections.Generic;

namespace AddressBookRegexValidation
{
    class Program
    {
        public static Contacts getContact()
        {
            Contacts contacts = new Contacts();
            string firstName;
            string lastName;
            string address;
            string state;
            string email;
            string city;
            string phnNum;
            string zip;
            Console.WriteLine("Enter firstname");
            firstName = Console.ReadLine();
            if (!contacts.SetFirstName(firstName))
            {
                Console.WriteLine("The FirstName that you have entered is InValid");
                return null;
            }
            Console.WriteLine("Enter LastName");
            lastName = Console.ReadLine();
            if (!contacts.SetLastName(lastName))
            {
                Console.WriteLine("The LastName that you have entered is InValid");
                return null;
            }
            Console.WriteLine("Enter Address");
            address = Console.ReadLine();
            if (!contacts.SetAddress(address))
            {
                Console.WriteLine("The Address that you have entered is InValid");
                return null;
            }
            Console.WriteLine("Enter City");
            city = Console.ReadLine();
            if (!contacts.SetCity(city))
            {
                Console.WriteLine("The City that you have entered is InValid");
                return null;
            }
            Console.WriteLine("Enter State");
            state = Console.ReadLine();
            if (!contacts.SetState(state))
            {
                Console.WriteLine("The State that you have entered is InValid");
                return null;
            }
            Console.WriteLine("Enter PhoneNumber");
            phnNum = Console.ReadLine();
            if (!contacts.SetPhnNumber(phnNum))
            {
                Console.WriteLine("The PhoneNumber that you have entered is InValid");
                return null;
            }
            Console.WriteLine("Enter MailID");
            email = Console.ReadLine();
            if (!contacts.SetEmail(email))
            {
                Console.WriteLine("The MailID that you have entered is InValid");

                return null;
            }
            Console.WriteLine("Enter Zip");
            zip = Console.ReadLine();
            if (!contacts.SetZip(zip))
            {
                Console.WriteLine("The Zip that you have entered is InValid");
                return null;
            }
            //new Contacts(firstName, lastName, address, state, email, city, phnNum, zip);


            return contacts; 
        }
        static void Main(string[] args)
        {
            AddressBookManagement addressBookManagement = new AddressBookManagement();
            int a;
            bool run = true;
            do
            {
                Console.WriteLine("Enter options \n1.Create a new Address Book   \n2.Add Contact to a specific address book  \n3. Get Specific Address Book\n4. Delete Contact from an Address Book " +
                    "\n5.Get list of Address Books  \n6 Edit contact  \n7 Quit");
                a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        string str = Console.ReadLine();
                        addressBookManagement.AddAnAddressBook(str);
                        //Console.WriteLine(addressBookManagement.GetAddressBooks());
                       
                        break;
                    case 2:
                        string s;
                        s = Console.ReadLine();
                        Contacts contact = getContact();
                        if (contact != null && contact.IsValid())
                        {
                            addressBookManagement.AddAContactToAddressBook(s, contact);
                            Console.WriteLine("Contact added");
                        }
                        else
                        {
                            Console.WriteLine("The contact details you have entered are not valid");
                        }
                        break;
                    case 3:
                        
                        s = Console.ReadLine();
                        foreach (Contacts c in addressBookManagement.GetAnAddressBook(s))
                        {
                            Console.WriteLine(c.GetFirstName());
                            Console.WriteLine(c.GetLastName());
                            Console.WriteLine(c.GetAddress());
                            Console.WriteLine(c.GetCity());
                            Console.WriteLine(c.GetState());
                            Console.WriteLine(c.GetEmail());
                            Console.WriteLine(c.GetPhnNumber());
                            Console.WriteLine(c.GetZip());
                        }
                        break;
                    case 4:
                        s = Console.ReadLine();
                        string firstn = Console.ReadLine();
                        addressBookManagement.RemoveAContactFromAddressBook(s,firstn);
                        break;
                    case 5:
                        foreach (string swt in addressBookManagement.GetAddressBooks().Keys)
                        {
                            Console.WriteLine(swt);
                        }
                        break;
                    case 6:
                        str = Console.ReadLine();
                        string stri = Console.ReadLine();
                        if (addressBookManagement.EditContact(str, stri, getContact()))
                        {
                            Console.WriteLine("Contact edited");
                        }
                        else
                        {
                            Console.WriteLine("Unable to edit contact");
                        }
                        break;
                    case 7:                     
                        run = false;
                        break;
                    default:
                        Console.WriteLine("Enter valid options");
                        break;
                }
            }
            while (run);
        }
    }
}
