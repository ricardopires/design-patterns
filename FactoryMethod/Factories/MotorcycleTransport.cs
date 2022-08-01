using FactoryMethod.Vehicles;

namespace FactoryMethod.Factories
{
    class MotorcycleTransport : Transport
    {
        protected override IVehicle CreateTransport() => new Motorcycle();
    }
}