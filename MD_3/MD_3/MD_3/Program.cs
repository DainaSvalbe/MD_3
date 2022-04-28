// See https://aka.ms/new-console-template for more information
using MD_3;

Console.WriteLine("Hello, World!");
//----------------------------

Telefons person = new Telefons();

person.Marka = "Samsung";
person.Modelis = "S20";
person.IzmersX = 200;
person.IzmersY = 100;
person.IzmersZ = 30;

person.Call();
person.Sms();

//-------------------------------
Console.WriteLine("----------------------------------");

Masina car = new Masina();

car.Brand = "Tesla";
car.Number = "xx";
car.Speed = 50;

car.StartDrive();
car.Accelerate();
car.Stop();
car.Beep();

//-------------------------------
Console.WriteLine("----------------------------------");
Console.WriteLine("Ievadi X izmēru");
double gar = double.Parse(Console.ReadLine());

Product paka = new Product(gar, 20, 30);

paka.Izveidot();

paka.XYZpaka();



//-------------------------------


Console.WriteLine("----------------------------------");

Person pers = new Person();

Console.WriteLine("Ievadi vaardu");
pers.FirstName = Console.ReadLine();

Console.WriteLine("Ievadi uzvaardu");
pers.LastName = Console.ReadLine();

Console.WriteLine("Ievadi dzimšanas gadu");
pers.BirthYear = int.Parse(Console.ReadLine());

Console.WriteLine("Ievadi hobiju");
pers.Hobijs = Console.ReadLine();

Console.WriteLine("Ievadi dzimumu");
pers.Dzimums = Console.ReadLine();

pers.Hello();








