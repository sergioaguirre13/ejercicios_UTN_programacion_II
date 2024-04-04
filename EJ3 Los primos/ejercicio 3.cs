using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel.DataAnnotations;

namespace EJ3_Los_primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
            // Validar que el dato ingresado por el usuario sea un número.
            // Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
            // Si ingresa "salir", cerrar la consola.
            // Al finalizar, preguntar al usuario si desea volver a operar.Si la respuesta es afirmativa, iterar.De lo contrario, cerrar la consola.


            string numeroUser;
            int numeroConvertido;
            bool validacionEntero = false;
            string volverOperar = "si";
            bool esPrimo = false;

            Console.Title = "Ejercicio 3";

            do
            {
            do
            {
                Console.Write("Ingrese un numero: (o escriba 'salir'): ");
                numeroUser = Console.ReadLine();

                if (numeroUser == "salir")
                {
                    Console.Beep();
                    Console.Beep();
                    Environment.Exit(0);
                }

                if (!int.TryParse(numeroUser, out _))
                {
                    Console.WriteLine($"{numeroUser} no es un número entero");
                }
                else
                {
                   validacionEntero = true;
                    Console.Beep();

                        numeroConvertido = int.Parse(numeroUser);

                        for (int i = 2; i < numeroConvertido; i++)
                        {
                            esPrimo = true;

                            // Verificar si i es divisible por cualquier número entre 2 y su raíz cuadrada
                            // Si encuentra un divisor, i no es primo
                            for (int j = 2; j <= Math.Sqrt(i); j++)
                            {
                                if (i % j == 0)
                                {
                                    esPrimo = false;
                                    break;
                                }
                            }

                            // Si esPrimo es true, entonces i es primo
                            if (esPrimo)
                            {
                                Console.WriteLine($"{i} es numero primo de {numeroConvertido}");
                            }
                        }

                        Console.Write("Volver a operar? (si-no): ");
                        volverOperar = Console.ReadLine();

                    }
                } while (validacionEntero == false);

            } while (volverOperar == "si");
        }
    }
}
