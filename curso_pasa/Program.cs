using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Evaluador de Notas ---");

        double nota;
        string entrada;
        int opcion;

        Console.Write("Ingrese la nota final (0 - 100): ");
        entrada = Console.ReadLine() ?? string.Empty;

        try
        {
            nota = double.Parse(entrada);

            if (nota >= 0 && nota <= 100)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Evaluar nota");
                Console.WriteLine("2. Salir");
                Console.Write("Opción: ");
                opcion = int.Parse(Console.ReadLine() ?? "0");

                switch (opcion)
                {
                    case 1:
                        if (nota >= 70)
                        {
                            Console.WriteLine("Aprobado");
                        }
                        else
                        {
                            Console.WriteLine("Reprobado");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error: la nota debe estar entre 0 y 100.");
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Error: ingrese un valor numérico válido.");
        }
    }
}
