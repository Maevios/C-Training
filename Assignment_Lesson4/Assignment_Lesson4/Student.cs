using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Lesson4
{
    class Student : Person
    {
       
        public void Study()
        {
            Console.WriteLine("I am studying");
        }

        public void ShowAge(int age)
        {
            Console.WriteLine("My age is " + age + " years old");
        }

    }
}
