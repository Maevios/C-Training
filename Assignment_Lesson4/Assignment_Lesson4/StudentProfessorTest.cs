using System;

namespace Assignment_Lesson4
{
    class StudentProfessorTest
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Greet();

            Student student = new Student();
            student.SetAge(16);
            student.Greet();
            student.ShowAge(16);

            Professor professor = new Professor();
            professor.SetAge(37);
            professor.Greet();
            professor.Explain();
        }
    }
}
