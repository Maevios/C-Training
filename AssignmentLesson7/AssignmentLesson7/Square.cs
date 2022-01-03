using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentLesson7
{
    public class Square : Rectangle, IComparable, ICloneable
    {
        public Square(int Width, int Height) : base(Width, Height)
        {
        }
        private string _type;

        public override string GetInfo()
        {
            return $"Square of color {this.color} and side length {this.width}";
        }

        public override string ToString()
        {
            return this.GetInfo();
        }
    }
}
