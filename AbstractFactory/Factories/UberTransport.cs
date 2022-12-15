using AbstractFactory.AirVehicles;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.Factories
{
    public class UberTransport : ITransportFactory
    {
        public AirVehicles.IAirVehicle CreateAirVehicleTransport() => new Airplane();

        public LandVehicles.IAirVehicle CreateLandVehicleTransport() => new Car();
    }
}
