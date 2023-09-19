// See https://aka.ms/new-console-template for more information



using MonOutil;

Console.WriteLine("Hello, what is your name?");

// Code qui lit la console pour stocker le nom
string username = Console.ReadLine();


// Code qui accueille l'utilisateur par son nom
Console.WriteLine($"Welcome {username} to MonOutil.");

new Meteo();

double tempInCelcius;
double tempInFahrenheit;
string? line;


Console.WriteLine("Wecome to Meteo tool!");
Console.WriteLine("Enter the temperature (in Celsius) that you want to convert:");
line = Console.ReadLine();
tempInCelcius = Convert.ToDouble(line);
tempInFahrenheit = (tempInCelcius * 9 / 5) + 32;
Console.WriteLine($"The temperature in Fahrenheit is: {tempInFahrenheit} ");