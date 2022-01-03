using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentLesson7
{
     public class Rectangle : Shape, IComparable, ICloneable
    {
        public int width { get; }
        public int height { get; }
        private string _type;

        public Rectangle(int Width, int Height)
        {
            if (Width < 0)
            {
                throw new Exception("Width cannot be negative number");
            }
            else width = Width;

            if (Height < 0)
            {
                throw new Exception("Height cannot be negative number");
            }
            else height = Height;
        }

        public virtual int GetArea()
        {
            return this.width * this.height;
        }

        public override string GetInfo()
        {
            return $"Rectangle of color {this.color}, width {this.width} and height {this.height}";
        }
        public override string ToString()
        {
            return this.GetInfo();
        }
    }
}
