using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AddressBookRegexValidation
{
    class AddressBookManagement
    {
        List<Contacts> addressBook = new List<Contacts>();
        Dictionary<string, List<Contacts>> dictionary = new Dictionary<string, List<Contacts>>();
        public bool CheckIfValid(string regex, string input)
        {
            var matchInput = Regex.Match(input, regex);
            if (matchInput.Success)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CreateANewContact()
        {
            Contacts contact = new Contacts();
            addressBook.Add(contact);
        }

    }
}
