using LibreriaEjercicio2;

namespace Ejercicio_I02___Desea_continuar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //        Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".
            //Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.
            //El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.

            char deseaContinuar = 'a';
            int numero = 0;
            int sumaNumeros = 0;
            int contarVuelta = 0;

            do
            {
                contarVuelta++;
                Console.WriteLine("Ingrese un numero");
                numero = int.Parse(Console.ReadLine());

                sumaNumeros += numero;

                Console.WriteLine("Desea continuar?");
                deseaContinuar = char.Parse(Console.ReadLine());



            } while (Validador.ValidarRespuesta(deseaContinuar));

            Console.WriteLine($"La suma de los valores ingresados es: {sumaNumeros}");

        }
    }
}
