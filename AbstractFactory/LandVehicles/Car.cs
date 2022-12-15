namespace AbstractFactory.LandVehicles
{
    public class Car : IAirVehicle
    {
        public void GetSubject()
        {
            Console.WriteLine("Getting people... ");
        }

        public void StartRoute()
        {
            Console.WriteLine("Starting route");
        }
    }
}
