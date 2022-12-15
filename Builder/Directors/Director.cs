using Builder.Builders;

namespace Builder.Directors
{
    public class Director
    {
        IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public void ConstructSedan()
        {
            builder.SetVehicleType(Components.VehicleType.SEDAN);
            builder.SetEngine(new Components.Engine(2000));
            builder.SetSeats(5);
            builder.SetTransmission(Components.Transmission.AUTOMATIC);
        }
        public void ConstructTruck()
        {
            builder.SetVehicleType(Components.VehicleType.TRUCK);
            builder.SetEngine(new Components.Engine(4000));
            builder.SetSeats(2);
            builder.SetTransmission(Components.Transmission.MANUAL);
        }
        public void ConstructSportCar()
        {
            builder.SetVehicleType(Components.VehicleType.SPORTCAR);
            builder.SetEngine(new Components.Engine(6000));
            builder.SetSeats(2);
            builder.SetTransmission(Components.Transmission.MANUAL);
        }
    }
}
