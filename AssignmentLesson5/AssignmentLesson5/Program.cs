using Assignment_Lesson5;
using System;

namespace AssignmentLesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook(6);
            PhoneBookEntry entry1 = new PhoneBookEntry("John", "1");
            PhoneBookEntry entry2 = new PhoneBookEntry("James", "2");
            PhoneBookEntry entry3 = new PhoneBookEntry("Mike", "3");
            PhoneBookEntry entry4 = new PhoneBookEntry("Jordan", "4");
            PhoneBookEntry entry5 = new PhoneBookEntry("Maria", "5");
            PhoneBookEntry entry6 = new PhoneBookEntry("Joe", "6");



            phoneBook.insert("John", "1");

            phoneBook.insert("James", "2");


            phoneBook.LookUp("James", "2", out PhoneBookEntry foundEntry);

          
        }
    }
}
