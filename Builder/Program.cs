using Builder.Builders;
using Builder.Directors;
using Builder.Products;

VehicleBuilder builder = new VehicleBuilder();
Director director = new Director(builder);

director.ConstructSedan();

Vehicle sedan = builder.GetVehicle();

Console.WriteLine($"vehicle type {sedan.VehicleType}");

director.ConstructTruck();

Vehicle truck = builder.GetVehicle();

Console.WriteLine($"vehicle type {truck.VehicleType}");