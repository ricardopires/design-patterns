namespace FactoryMethod.Vehicles
{
    public class Bicycle : IVehicle
    {
        public void GetSubject() => Console.Write("Getting order...");

        public void StartRoute()
        {
            GetSubject();
            Console.Write(" start route.");
        }
    }
}