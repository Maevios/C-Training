using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_Lesson4
{
    class Person
    {
        int age;
        public void Greet()
        {
            Console.WriteLine("Hello");
        }
        public int SetAge(int age)
        {
            this.age = age;
            return age;
        }

    }
}
