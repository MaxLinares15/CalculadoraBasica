using System;

namespace CalculadoraBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n===============================================");
                Console.WriteLine("           Bienvenido a la Calculadora          ");
                Console.WriteLine("===============================================");
                Console.WriteLine("Seleccione una de las siguientes operaciones:");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Raíz cuadrada");
                Console.WriteLine("6. Salir");
                Console.WriteLine("===============================================");

                Console.Write("Ingrese su opción (1-7): ");
                int opcion = int.Parse(Console.ReadLine()!);

                if (opcion == 6)
                {
                    Console.WriteLine("\n¡Gracias por usar la calculadora! ¡Hasta pronto!");
                    break;
                }

                double resultado = 0;

                if (opcion >= 1 && opcion <= 4)
                {
                    Console.Write("Ingrese el primer número: ");
                    double num1 = double.Parse(Console.ReadLine()!);

                    Console.Write("Ingrese el segundo número: ");
                    double num2 = double.Parse(Console.ReadLine()!);

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
                    }
                }
               
                else if(opcion == 5)
                {
                    // Raíz cuadrada
                    Console.Write("Ingrese el número para calcular la raíz cuadrada: ");
                    double numero = double.Parse(Console.ReadLine()!);

                    if (numero < 0)
                    {
                        Console.WriteLine("Error: No se puede calcular la raíz cuadrada de un número negativo.");
                    }
                    else
                    {
                        resultado = Math.Sqrt(numero);
                        Console.WriteLine($"Resultado: √{numero} = {resultado}");
                    }
                }
                else
                {
                    Console.WriteLine("Opción no válida.");
                }
            }
        }
    }
}
