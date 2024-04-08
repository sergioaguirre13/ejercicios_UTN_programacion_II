using System;

namespace Ejercicio5
{
    internal class Ejercicio5
    {
        static void Main(string[] args)
        {

            //  Un centro numérico es un número que separa una lista de números enteros(comenzando en 1) en dos grupos de números,
            //  cuyas sumas son iguales. 
            //El primer centro numérico es el 6, el cual separa la lista(1 a 8) en los grupos: (1; 2; 3; 4; 5) y(7; 8)
            //cuyas sumas son ambas iguales a 15.El segundo centro numérico es el 35, el cual separa la lista(1 a 49) en los grupos: (1 a 34) y(36 a 49)
            //cuyas sumas son ambas iguales a 595.
            //Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el usuario ingrese por consola.


            int NumUser;

            Console.WriteLine("Ingrese un número para encontrar los centros numéricos:");
            NumUser = int.Parse(Console.ReadLine());

            Console.WriteLine("Los centros numéricos hasta " + NumUser + " son:");
            for (int num = 1; num <= NumUser; num++)
            {
                int sumaIzquierda = 0;
                int sumaDerecha = 0;

                // Calcula la suma de los números a la izquierda de num
                for (int i = 1; i < num; i++)
                {
                    sumaIzquierda += i;
                }

                // Calcula la suma de los números a la derecha de num
                for (int j = num + 1; sumaDerecha < sumaIzquierda && j <= NumUser; j++)
                {
                    sumaDerecha += j;
                }

                // Si las sumas son iguales, num es un centro numérico
                if (sumaIzquierda == sumaDerecha)
                {
                    Console.WriteLine(num);
                }
            }




        }
    }
}
