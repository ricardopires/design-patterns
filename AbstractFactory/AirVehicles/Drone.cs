namespace AbstractFactory.AirVehicles
{
    public class Drone : IAirVehicle
    {
        public void CheckWind()
        {
            Console.WriteLine("Winds are too strong!");
        }

        public void GetSubject()
        {
            Console.WriteLine("Attaching cargo to the compartment...");
        }

        public void StartRoute()
        {
            Console.WriteLine("Taking off");
        }
    }
}
