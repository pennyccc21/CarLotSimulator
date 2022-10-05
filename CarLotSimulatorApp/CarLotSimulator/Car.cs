using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        private int v1;
        private string v2;
        private string v3;
        private string v4;
        private string v5;
        private bool v6;
        private object CarLot;

        public Car()
        {
            CarLot.numberOfCars++;
        }


        public Car(int v1, string v2, string v3, string v4, string v5, bool v6)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
        }

        public string Make { get; set; 
        public int Year { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public string IsDriveable { get; set; }

        public void MakeEngineNoise(string MakeEngineNoise)
        {
            Console.WriteLine(MakeEngineNoise);
        }

        public void MakeHonkNoise(string honkNoise)
        {
            Console.Write(honkNoise);
        }

        internal void MakeEngineNoise()
        {
            throw new NotImplementedException();
        }
    }
    
    
    

