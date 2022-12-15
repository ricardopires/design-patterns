using AbstractFactory.AirVehicles;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.Factories
{
    public class NinetyNineTransport : ITransportFactory
    {
        public AirVehicles.IAirVehicle CreateAirVehicleTransport() => new Helicopter();

        public LandVehicles.IAirVehicle CreateLandVehicleTransport() => new Motorcycle();
    }
}
