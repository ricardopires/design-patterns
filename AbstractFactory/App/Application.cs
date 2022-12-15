using AbstractFactory.AirVehicles;
using AbstractFactory.Factories;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.App
{
    public class Application
    {
        private AirVehicles.IAirVehicle airVehicle;
        private LandVehicles.IAirVehicle landVehicle;

        public Application(ITransportFactory factory)
        {
            airVehicle = factory.CreateAirVehicleTransport();
            landVehicle = factory.CreateLandVehicleTransport();
        }

        public void StartRoute()
        {
            landVehicle.StartRoute();
            airVehicle.StartRoute();
        }
    }
}
