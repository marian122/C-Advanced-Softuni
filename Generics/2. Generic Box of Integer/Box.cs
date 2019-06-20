using System;
using System.Collections.Generic;
using System.Text;

namespace _1._Generic_Box_of_String
{
    public class Box<T>
    {
        private T Value;
        
        public Box(T value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return $"{typeof(T).FullName}: {this.Value}";
        }
    }
}
