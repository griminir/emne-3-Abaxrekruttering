// See https://aka.ms/new-console-template for more information

using emne_3_Abaxrekruttering;

Console.WriteLine("Abaxrekruttering");

var car1 = new Car("NF123456", 147, 200, "Km/h", "Lett kjøretøy", "grønn");
var car2 = new Car("NF654321", 150, 195, "km/h", "Lett Kjøretøy", "blå");
var fly = new Airplane("LN1234", 1000, "jetfly", 30, 2, 10);
var båt = new Boat("ABC123", 100, 30, "Knop", "båt", 500);

car1.info();

Console.WriteLine();

car2.info();

Console.WriteLine();

car1.sameCar(car2);

Console.WriteLine();

fly.info();

Console.WriteLine();

fly.run();

Console.WriteLine();

car1.run();

Console.WriteLine();

båt.info();