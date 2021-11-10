using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AddressBookRegexValidation
{
    class AddressBookManagement
    {
        Dictionary<string, List<Contacts>> addressBooks = new Dictionary<string, List<Contacts>>();
        public Dictionary<string, List<Contacts>> GetAddressBooks()
        {
            return addressBooks;
        }
        public List<Contacts> GetAnAddressBook(string s) => addressBooks.GetValueOrDefault(s);
        public void AddAContactToAddressBook(string s, Contacts c)
        {
             addressBooks.GetValueOrDefault(s).Add(c);
        }
        public void AddAnAddressBook(string s)
        {
            List<Contacts> contacts = new List<Contacts>();
            addressBooks.Add(s, contacts);
        }
        public void AddAnAddressBook(string s,List<Contacts> contacts)
        {
            addressBooks[s] = contacts;
        }
        public bool RemoveAContactFromAddressBook(string s,string firstName)
        {
            List<Contacts> tempList = addressBooks.GetValueOrDefault(s);
            Contacts contactToRemove = null;
            foreach(Contacts temp in tempList)
            {
                if (temp.GetFirstName() == firstName)
                {
                    contactToRemove = temp;
                }
            }
            if (contactToRemove != null)
            {
                tempList.Remove(contactToRemove);
                AddAnAddressBook(s, tempList);
                return true;
            }
            return false;
        }
        public bool EditContact(string s, string firstName,Contacts contacts)
        {
            List<Contacts> tempList = addressBooks.GetValueOrDefault(s);
            Contacts contactToEdit = null;
            foreach (Contacts temp in tempList)
            {
                if (temp.GetFirstName() == firstName)
                {
                    contactToEdit = temp;
                }
                if (contactToEdit != null)
                {
                    tempList.Remove(temp);
                    tempList.Add(contacts);
                    return true;
                }
            }
            return false;
        }
    }
}
