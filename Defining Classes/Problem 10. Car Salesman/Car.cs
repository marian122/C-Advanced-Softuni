using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public Car(string model, Engine engine, double weigth, string color)
        {
            this.Model = model;
            this.Engine = engine;
            this.Weigth = weigth;
            this.Color = color;
        }

        public Car(string model, Engine engine, double weigth) : this(model, engine, weigth, "n/a")
        {
        }

        public Car(string model, Engine engine, string color) : this(model, engine, -1, color)
        {
        }

        public Car(string model, Engine engine) : this(model, engine, -1, "n/a")
        {
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public double Weigth { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.Model}:");
            sb.AppendLine(Engine.ToString());
            if (this.Weigth == -1)
            {
                sb.AppendLine($"  Weight: n/a");

            }
            else
            {
                sb.AppendLine($"  Weight: {this.Weigth}");

            }
            sb.Append($"  Color: {this.Color}");

            return sb.ToString();
        }

    }
}
