// See https://aka.ms/new-console-template for more information

// 1. demander le nom de l'utilisateur et l'acueillir
// ex.: bienvenue _____ à l'application MonOutil
string name = Console.ReadLine();
double degré_C = Convert.ToDouble(Console.ReadLine());
double degré_F = Convert.ToDouble(Console.ReadLine());
degré_F = degré_C * 9 / 5 + 32;

Console.WriteLine("Quel est votre nom?");
// interpolation de chaîne, string interpolation
Console.WriteLine($"Bienvenue à l'application, {name}");

// 2. demander à l'utilisateur d'entrer une température en Celsius
Console.WriteLine($"Entrez une température en Celsius: {degré_C} °C");
// convertir la température en Fahrenheit et mettre le résultat ds la console
Console.WriteLine($"La température en Fahrenheit est: {degré_F} °F");

Console.ReadKey();