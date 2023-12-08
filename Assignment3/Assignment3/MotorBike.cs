using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment3
{
    internal class MotorBike
    {
        public string TypeOfTyres;
        public string NameOfTyres;
        public int EngineCapacity;
        public int TopSpeed;
        public string TypeOfBike;
        public string NameOfBike;
        public double speed;

        public Rider Currentdriver = new Rider();

        public MotorBike(string typeOfTyres,string nameOfTyres,int engineCapacity,int topSpeed,string typeOfBike,string nameOfBike)
        {
            TypeOfTyres = typeOfTyres;
            NameOfTyres = nameOfTyres;
            EngineCapacity = engineCapacity;
            TopSpeed = topSpeed;
            TypeOfBike = typeOfBike;
            NameOfBike = nameOfBike;
        }

        public void Accelerate(double speedAmount)
        {
            speed += speedAmount;
        }

        public double GetCurrentSpeed()
        {
            return speed;
        }

    }
}
