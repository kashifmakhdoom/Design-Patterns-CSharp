using BuilderPattern;

Console.Title = "Builder";

var garage = new Garage();

var yarisBuilder = new YarisBuilder();
var landCruiserBuilder = new LandCruiserBuilder();

garage.Construct(yarisBuilder);
garage.Show();

garage.Construct(landCruiserBuilder);
garage.Show();

Console.ReadKey();