using System.ComponentModel.DataAnnotations;

namespace EJ2
{
    internal class Ejercicio2
    {
        static void Main(string[] args)
        {

            //Ingresar un número y mostrar el cuadrado y el cubo del mismo.
            //Se debe validar que el número sea mayor que cero, caso contrario,
            //mostrar el mensaje: "ERROR. ¡Reingresar número!".

            int numUser;
            double alCuadrado;
            double alcubo;
            bool error = false;


            do
            {
                Console.WriteLine("Ingrese un numero para potenciar al cuadrado y al cubo");
                numUser = int.Parse(Console.ReadLine());


                if (numUser > 0)
                {
                    alCuadrado = Math.Pow(numUser, 2);
                    alcubo = Math.Pow(numUser, 3);

                    Console.WriteLine($"{numUser} elevado al cuadrado da como resultado: {alCuadrado}");
                    Console.WriteLine($"{numUser} elevado al cubo da como resultado: {alcubo}");

                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                    error = true;
                }

            } while ( error == true );

        }
    }
}
