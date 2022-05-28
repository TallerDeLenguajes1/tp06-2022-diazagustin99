// See https://aka.ms/new-console-template for more information
using System;
TimeSpan aux;
Console.WriteLine("Hello, World!");
var Empleado1 = new Empleado("Nombre 1", "Apellido 1", new DateTime(1985, 02, 1) , new DateTime(1995, 02, 1), 'c','m', Cargos.Administrativo, 12500);
Console.WriteLine(Empleado1.Nombre1);
Console.WriteLine(Empleado1.Apellido1);
Console.WriteLine(Empleado1.Fnacimiento1.ToShortDateString());
aux= Empleado1.Antiguedad();
Console.WriteLine("La antiguedad del empleado es: "+ aux.Days/365 + " Años");
aux= Empleado1.Edad();
Console.WriteLine("El empleado tiene: " + aux.Days/365 + " Años");
System.Console.WriteLine("El Sueldo del empleado es: " + Empleado1.Salario());