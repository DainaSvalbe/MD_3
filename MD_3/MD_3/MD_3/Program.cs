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
