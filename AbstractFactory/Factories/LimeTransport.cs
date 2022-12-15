using AbstractFactory.AirVehicles;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.Factories
{
    public class LimeTransport : ITransportFactory
    {
        public AirVehicles.IAirVehicle CreateAirVehicleTransport() => new Drone();

        public LandVehicles.IAirVehicle CreateLandVehicleTransport() => new Scooter();
    }
}
