using System;

namespace AssignmentLesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Rectangle rectangle = new Rectangle(1,2);
            rectangle.color = color.blue;

            Console.WriteLine(rectangle.GetInfo());

            
            var rectangleArea = rectangle.GetArea();

            Console.WriteLine(rectangleArea);


            Console.WriteLine(rectangle.ToString());



            Square square = new Square(3,3);
            square.color = color.green;

            var squareArea = square.GetArea();

            Console.WriteLine(squareArea);

            Console.WriteLine(square.GetInfo());

            Console.WriteLine(square.ToString());
        }
    }
}
