using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentLesson7
{
    public  abstract class Shape: IComparable , ICloneable
    {
        public color color { get; set; }

        public void setColor(color color)
        {
            this.color = color;
        }

        public virtual string GetInfo()
        {
            string info = $"The color of this shape is {this.color}";
            return info;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return this.GetInfo();
        }
    }

   public enum color
    {
        black,
        white,
        yellow,
        blue,
        green
    }
}
