// See https://aka.ms/new-console-template for more information
using Sampleconsola;


int x = 1;
Console.WriteLine("Hello, World!");



Casa casa = new Casa();

Console.WriteLine("Introduzca la descripcion de la casa");

casa.Description = Console.ReadLine();

Console.WriteLine("Introduzca la ubicacion de la casa");

casa.Location = Console.ReadLine();

casa.Id = x;
x++;


Console.WriteLine($" {casa.Id} -  {casa.Description}  {casa.Location} ");

Console.ReadKey();
