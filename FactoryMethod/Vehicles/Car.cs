namespace FactoryMethod.Vehicles
{
    public class Car : IVehicle
    {
        public void GetCargo() => Console.WriteLine("Getting passengers...");

        public void StartRoute()
        {
            GetCargo();
            Console.Write(" start route.");
        }
    }
}