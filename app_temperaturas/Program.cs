using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Conversor de Temperatura ---");

        Console.Write("Ingrese la temperatura en grados Celsius: ");
        string entrada = Console.ReadLine() ?? string.Empty;

        try
        {
            double celsius = double.Parse(entrada);
            double fahrenheit = (celsius * 1.8) + 32;

            Console.WriteLine($"Resultado: {celsius:F2} °C = {fahrenheit:F2} °F");
        }
        catch (Exception)
        {
            Console.WriteLine("Error: ingrese un valor numérico válido.");
        }
    }
}
