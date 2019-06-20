using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_8._Raw_Data
{
    public class Cargo
    {
        private int weight;
        private string type;

        public Cargo(int weight, string type)
        {
            this.weight = weight;
            this.type = type;
        }

        public string Type
        {
            get { return this.type; }
        }
    }
}
