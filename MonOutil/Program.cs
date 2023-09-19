// See https://aka.ms/new-console-template for more information



using MonOutil;

Console.WriteLine("Bonjour, quel est votre nom?");

// Code qui lit la console pour stocker le nom
string username = Console.ReadLine();


// Code qui accueille l'utilisateur par son nom
Console.WriteLine($"Bienvenue {username} à MonOutil.");

new Meteo();

double tempEnCelcius;
double tempEnFahrenheit;
string? line;


Console.WriteLine("Bienvenue à l'outil Météo!");
Console.WriteLine("Entrez la température (en Celsius) que vous souhaitez convertir:");
line = Console.ReadLine();
tempEnCelcius = Convert.ToDouble(line);
tempEnCelcius = (tempEnCelcius * 9 / 5) + 32;
Console.WriteLine("La température en Fahrenheit: {tempEnFarenheit} ");