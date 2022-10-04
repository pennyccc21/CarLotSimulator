using Microsoft.VisualBasic;
using System;
using System.Xml.Schema;

namespace CarLotSimulator
{
    class Program
    {
        private static object lot;

        public static string Make { get; private set; }
        public static int Year { get; private set; }
        public static string Model { get; private set; }
        public static string EngineNoise { get; private set; }
        public static string HonkNoise { get; private set; }
        public static string IsDriveable { get; private set; }

        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            var pennyCar = new Car();
            pennyCar.Make = "RTX";
            pennyCar.Year = 2013;
            pennyCar.Model = "Dodge Charger";
            pennyCar.IsDriveable = "Yes";
            pennyCar.EngineNoise = "no";
            pennyCar.HonkNoise = "Yes";

            var freddyCar = new Car();
            {
                Make = "tesla";
                Year = 2019;
                Model = "Cyber Truck";
                EngineNoise = "...";
                HonkNoise = "not loud";
                IsDriveable = "Yes";

            };

            var marlonCar = new Car(2013, "Honda", "Civic", "Vroom", "Vrugga", true);

            

            pennyCar.MakeEngineNoise();
            freddyCar.MakeEngineNoise();
            marlonCar.MakeEngineNoise();



            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }   
    


