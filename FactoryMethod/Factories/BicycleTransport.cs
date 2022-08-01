using FactoryMethod.Vehicles;

namespace FactoryMethod.Factories
{
    class BicycleTransport : Transport
    {
        protected override IVehicle CreateTransport() => new Bicycle();
    }
}