namespace SoftUniParking
{
    using System.Linq;
    using System.Text;

    public class Car
    {

        public Car(string make, string model, int horsePower, string registrationNumber)
        {
            this.Make = make;
            this.Model = model;
            this.HorsePower = horsePower;
            this.RegistrationNumber = registrationNumber;
        }

        public string RegistrationNumber { get => registrationNumber; set => registrationNumber = value; }
        public int HorsePower { get => horsePower; set => horsePower = value; }
        public string Model { get => model; set => model = value; }
        public string Make { get => make; set => make = value; }

        private string make;
        private string model;
        private int horsePower;
        private string registrationNumber;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make: {this.make}");
            sb.AppendLine($"Model: {this.model}");
            sb.AppendLine($"HorsePower: {this.horsePower}");
            sb.Append($"RegistrationNumber: {this.registrationNumber}");
            return sb.ToString();
        }
    }
}
