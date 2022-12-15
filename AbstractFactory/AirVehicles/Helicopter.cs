namespace AbstractFactory.AirVehicles
{
    public class Helicopter : IAirVehicle
    {
        public void CheckWind()
        {
            Console.WriteLine("Winds at 25km/k");
        }

        public void GetSubject()
        {
            Console.WriteLine("People boarding");
        }

        public void StartRoute()
        {
            Console.WriteLine("Taking off");
        }
    }
}
