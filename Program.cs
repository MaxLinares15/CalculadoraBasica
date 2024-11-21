using System;

namespace CalculadoraBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============================================");
            Console.WriteLine("           Bienvenido a la Calculadora          ");
            Console.WriteLine("===============================================");
            Console.WriteLine("Seleccione una de las siguientes operaciones:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Potenciación");
            Console.WriteLine("6. Módulo");
            Console.WriteLine("===============================================");

            Console.Write("Ingrese su opción (1-6): ");
            int opcion = int.Parse(Console.ReadLine()!);
            Console.WriteLine("\n¡Gracias por usar la calculadora! Sigamos...");
         

            Console.Write("Ingrese el primer número: ");
            double num1 = double.Parse(Console.ReadLine()!);

            Console.Write("Ingrese el segundo número: ");
            double num2 = double.Parse(Console.ReadLine()!);

            double resultado = 0;
            switch (opcion)
            {
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}");
                    break;
                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}");
                    break;
                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine($"Resultado: {num1} * {num2} = {resultado}");
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"Resultado: {num1} / {num2} = {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir entre cero.");
                    }
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}
