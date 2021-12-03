using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Lesson5
{
    class PhoneBookEntry
    {
        protected string name { get; }
        protected string number { get; }

        public PhoneBookEntry(string name, string number)
        {
            name = name;
            number = number;
        }

        public static bool operator ==(PhoneBookEntry a, PhoneBookEntry b)
        {

            if (a.name == b.name && a.number == b.number)
            {
                return true;
            }
            else return false;

        }
        public static bool operator !=(PhoneBookEntry a, PhoneBookEntry b)
        {

            if (a.name == b.name && a.number == b.number)
            {
                return false;
            }
            else return true;

        }
    }
}
