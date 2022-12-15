namespace AbstractFactory.LandVehicles
{
    public class Scooter : IAirVehicle
    {
        public void GetSubject()
        {
            Console.WriteLine("Fethcing cargo...");
        }

        public void StartRoute()
        {
            Console.WriteLine("Off we go");
        }
    }
}
