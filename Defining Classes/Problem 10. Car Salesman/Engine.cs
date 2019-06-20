using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Engine
    {
        public Engine(string model, int power, int displacement, string efficiency)
        {
            this.Model = model;
            this.Power = power;
            this.Displacement = displacement;
            this.Efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement) : this(model, power, displacement, "n/a")
        {
        }

        public Engine(string model, int power, string efficiency) : this(model, power, -1, efficiency)
        {
        }

        public Engine(string model, int power) : this(model, power, -1, "n/a")
        {
        }

        public string Model { get; set; }

        public int Power { get; set; }

        public int Displacement { get; set; }

        public string Efficiency { get; set; }

  //<CarModel>:
  //  <EngineModel>:
  //    Power: <EnginePower>
  //    Displacement: <EngineDisplacement>
  //    Efficiency: <EngineEfficiency>
  //  Weight: <CarWeight>
  //  Color: <CarColor>


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"  {this.Model}:");
            sb.AppendLine($"    Power: {this.Power.ToString()}");
            if (this.Displacement == -1)
            {
                sb.AppendLine($"    Displacement: n/a");
            }
            else
            {
                sb.AppendLine($"    Displacement: {this.Displacement.ToString()}");

            }
            sb.Append($"    Efficiency: {this.Efficiency}");

            return sb.ToString();
        }

    }
}
