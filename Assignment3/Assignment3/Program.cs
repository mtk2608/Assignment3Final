namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rider rider = new Rider();
            rider.age = 44;
            rider.nameOfRider = "Valentino Rossi";
            rider.Championship = true;

            MotorBike Ducati = new MotorBike("Soft Compound", "GoodYear Tires", 1103, 300,"Superbike","Panigale V4" );
            Ducati.Accelerate(210);

            Console.WriteLine($"{rider.nameOfRider}, age {rider.age} has got a new bike this year it's a Ducati {Ducati.NameOfBike}.It's a {Ducati.EngineCapacity}cc {Ducati.TypeOfBike} with the ability to reach speeds of up to {Ducati.TopSpeed}.");
            Console.WriteLine("His really moving on the straight away, his reaching speeds of " + Ducati.speed + "km/h");

            
        }
    }
}
