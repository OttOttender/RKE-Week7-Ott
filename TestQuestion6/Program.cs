

Console.WriteLine("Convert to: (Fahrenheit/Celsius)");
string choice = Console.ReadLine();

if (choice == "Fahrenheit")
{
    Console.WriteLine("Enter your temperature in Celsius");
    double celsius = Double.Parse(Console.ReadLine());
    //double because temp can have decimal points, especially after conversions
    ConvertToFahrenheit(celsius);
}
else if (choice == "Celsius")
{
    Console.WriteLine("Enter your temperature in Fahrenheit");
    double fahrenheit = Double.Parse(Console.ReadLine());
    ConvertToCelsius(fahrenheit);
}

static void ConvertToCelsius(double fahrenheit)
{
    double celsius = (fahrenheit - 32) * 5 / 9;
    Console.WriteLine($"{fahrenheit} fahrenheit is {celsius} celsius.");
}
static void ConvertToFahrenheit(double celsius)
{
    double fahrenheit = (celsius * 9) / 5 + 32;
    Console.WriteLine($"{celsius} Celsius is {fahrenheit} fahrenheit.");
}

