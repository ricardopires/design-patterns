using AbstractFactory.AirVehicles;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.Factories
{
    public interface ITransportFactory
    {
        AirVehicles.IAirVehicle CreateAirVehicleTransport();
        LandVehicles.IAirVehicle CreateLandVehicleTransport();
    }
}
