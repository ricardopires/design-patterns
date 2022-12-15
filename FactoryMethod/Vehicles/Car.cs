namespace FactoryMethod.Vehicles
{
    public class Car : IVehicle
    {
        public void GetSubject() => Console.WriteLine("Getting passengers...");

        public void StartRoute()
        {
            GetSubject();
            Console.Write(" start route.");
        }
    }
}