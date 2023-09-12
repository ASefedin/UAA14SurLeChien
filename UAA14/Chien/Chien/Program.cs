// See https://aka.ms/new-console-template for more information
using Chien;

Console.WriteLine("Hello, World!");
Console.WriteLine("Première Methode");
UnChien chien1 = new UnChien("Nathan", "GrosChien", 18, true, true, true, true, "blanc");

Console.WriteLine(chien1.AfficherCaracteristiques());

Console.WriteLine(chien1.Age);
chien1.Age += 1;