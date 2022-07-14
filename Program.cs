using dotnet_poo.src.entities;

Knight knight = new Knight("Arus", 23, "Knight", 499);
Wizard wizard = new Wizard("Jennica", 29, "Wizard", 275);

System.Console.WriteLine(wizard.Attack());
System.Console.WriteLine(knight.Attack());
