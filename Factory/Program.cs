using Factory;

var type = Console.ReadLine();
CarFactory car = new CarFactory();
var a = car.GetCar(type);
a.Start();
