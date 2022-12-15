namespace AbstractFactory.LandVehicles
{
    public class Motorcycle : IAirVehicle
    {
        public void GetSubject()
        {
            Console.WriteLine("Fecthing cargo... ");
        }

        public void StartRoute()
        {
            Console.WriteLine("Starting route");
        }
    }
}
