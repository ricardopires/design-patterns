namespace FactoryMethod.Vehicles
{
    public class Bicycle : IVehicle
    {
        public void GetCargo() => Console.Write("Getting order...");

        public void StartRoute()
        {
            GetCargo();
            Console.Write(" start route.");
        }
    }
}