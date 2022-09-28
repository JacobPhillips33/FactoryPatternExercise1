using FactoryPatternExercise1;

IVehicle vehicle1 = VehicleFactory.GetVehicle();
vehicle1.Drive();

Console.WriteLine();

IVehicle vehicle2 = VehicleFactory.GetVehicle();
vehicle2.Drive();