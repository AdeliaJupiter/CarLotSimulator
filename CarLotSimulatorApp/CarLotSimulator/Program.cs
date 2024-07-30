using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //DONE -- Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.

            var lot = new CarLot();

            //DONE--Create a seperate class file called Car
            //DONE--Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //DONE--Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //DONE--The methods should take one string parameter: the respective noise property


            //DONE--Now that the Car class is created we can instanciate 3 new cars
            //DONE--Set the properties for each of the cars
            //DONE--Call each of the methods for each car

            var dreamCar = new Car();
            dreamCar.Make = "BMW";
            dreamCar.Model = "i8";
            dreamCar.Year = 2024;
            dreamCar.IsDriveable = true;
            dreamCar.EngineNoise = "vavroom";
            dreamCar.HonkNoise = "beep";

            dreamCar.MakeEngineNoise(dreamCar.EngineNoise);
            dreamCar.MakeHonkNoise(dreamCar.HonkNoise);

            lot.Cars.Add(dreamCar);

            //*************BONUS*************//

            //DONE-- Set the properties utilizing the 3 different ways we learned about, one way for each car
            var charliesCar = new Car()
            {
                Make = "Toyota",
                Model = "Avalon",
                Year = 2002,
                IsDriveable = false,
                EngineNoise = "kaklunk",
                HonkNoise = "braaaaap"
            };
            lot.Cars.Add(charliesCar);

            var caitysCar = new Car(2007, "Cheverolet", "Impala", "cachuga", "hooonk", true);
            lot.Cars.Add(caitysCar);

            //*************BONUS X 2*************//

            //DONE -- Create a CarLot class
            //DONE -- It should have at least one property: a List of cars

            //DONE -- At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach(var car in  lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
            }
        }
    }
}
