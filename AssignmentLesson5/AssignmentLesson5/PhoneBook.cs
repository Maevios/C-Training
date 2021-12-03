using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Lesson5
{
    class PhoneBook
    {
        private PhoneBookEntry[] _phoneBookEntries;

        public PhoneBook() :this(10)
        {

        }

        public PhoneBook(int numberOfEntries)
        {
            _phoneBookEntries = new PhoneBookEntry[numberOfEntries];
        }


        public bool LookUp(string name, out PhoneBookEntry foundEntry)
        {
            PhoneBookEntry entry = new PhoneBookEntry(name, "test");
            for (int i = 0; i < _phoneBookEntries.Length; i++)
                if (_phoneBookEntries[i] == entry) // den katalabainw pws mporw na exw access sto name
                {
                    _phoneBookEntries[i] = null;
                    if (_phoneBookEntries[i] == entry)
                    {
                        foundEntry = _phoneBookEntries[i];
                        return true;
                    }
                }
            foundEntry = null;
            return false;
        }

        public bool LookUp(string name, string phone, out PhoneBookEntry foundEntry)
        {
            PhoneBookEntry entry = new PhoneBookEntry(name, phone);
            
            for (int i = 0; i < _phoneBookEntries.Length; i++)
                if (_phoneBookEntries[i] == entry)
                {
                    _phoneBookEntries[i] = null;
                    foundEntry = _phoneBookEntries[i];
                    if (_phoneBookEntries[i + 1] == entry)
                    {
                        return true;
                    }
                }
            foundEntry = null;
            return false;

        }

        public void insert(string name, string number)
        {
            PhoneBookEntry entry = new PhoneBookEntry(name, number);
            for (int i = 0; i < _phoneBookEntries.Length; i++)
                if (_phoneBookEntries[i] == null)
                {
                    _phoneBookEntries[i] = entry;
                    break;
                }
        }

        public bool Delete(PhoneBookEntry entry)
        {
            for (int i = 0; i < _phoneBookEntries.Length; i++)
                if (_phoneBookEntries[i] == entry)
                {
                    _phoneBookEntries[i] = null;
                    return true;
                }
            return false;
        }

        public PhoneBookEntry this[int i]
        {
            get {
                if (i > _phoneBookEntries.Length)
                {
                    return null;
                }
                return _phoneBookEntries[i]; }
            set { _phoneBookEntries[i] = value; }
        }
    }
}
