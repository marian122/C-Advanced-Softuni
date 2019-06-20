using System;
using System.Collections.Generic;
using System.Text;

namespace _1._Generic_Box_of_String
{
    public class Box<T> : IComparable<T>
        where T : IComparable<T>
    {
        private T Value;
        
        public Box(T value)
        {
            this.Value = value;
        }

        public int CompareTo(T other)
        {
            return this.Value.CompareTo(other);
        }

        public override string ToString()
        {
            return $"{this.Value.GetType().FullName}:{this.Value}";
        }
    }
}
