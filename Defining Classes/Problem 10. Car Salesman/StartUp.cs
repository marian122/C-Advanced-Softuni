using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
   public class StartUp
    {
        static void Main()
        {
            int engineCount = int.Parse(Console.ReadLine());
            List<Engine> engineList = new List<Engine>();
            List<Car> carList = new List<Car>();
            for (int i = 0; i < engineCount; i++)
            {
                string[] engines = Console.ReadLine().Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries);
                var engineType = engines[0];
                var enginePower = int.Parse(engines[1]);
                

                Engine engine = null;

                if (engines.Length == 2)
                {
                    engine = new Engine(engineType, enginePower);
                }
                else if (engines.Length == 4)
                {
                    var engineDisplacement = int.Parse(engines[2]);
                    var engineEfficiency = engines[3];
                    engine = new Engine(engineType, enginePower, engineDisplacement, engineEfficiency);
                }
                else
                {
                    
                    bool isDisplacement = int.TryParse(engines[2], out int engineDisplacement);

                    if (isDisplacement)
                    {
                        engine = new Engine(engineType, enginePower, engineDisplacement);

                    }
                    else
                    {
                        engine = new Engine(engineType, enginePower, engines[2]);

                    }
                }
                engineList.Add(engine);

            }

            int carCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carCount; i++)
            {
                string[] cars = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var carModel = cars[0];
                var carEngine = cars[1];
                
                Engine engine = engineList.Where(x=> x.Model == carEngine).FirstOrDefault();

                Car car = null;

                if (cars.Length == 2)
                {
                    car = new Car(carModel, engine);
                }
                else if (cars.Length == 4)
                {
                    var carWeigth = double.Parse(cars[2]);
                    var carColor = cars[3];
                    car = new Car(carModel, engine, carWeigth, carColor);

                }
                else
                {

                    bool isWeigth = double.TryParse(cars[2], out double carWeigth);
                    
                    if (isWeigth)
                    {
                        car = new Car(carModel, engine, carWeigth);

                    }
                    else
                    {
                        car = new Car(carModel, engine, cars[2]);

                    }
                }
                carList.Add(car);
            }
            Console.WriteLine(string.Join(Environment.NewLine, carList));
        }
    }
}
