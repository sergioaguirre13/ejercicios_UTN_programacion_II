namespace EJ3__Un_número_perfecto
{
    internal class Ejercicio4
    {
        static void Main(string[] args)
        {

            // Un número perfecto es un entero positivo, que es igual a la suma de todos
            // los enteros positivos(excluido el mismo) que son divisores del número.
            //El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
            //Escribir una aplicación que encuentre los 4 primeros números perfectos.


            int numero = 1; // Comenzamos desde 1 para encontrar los primeros números perfectos
            int encontrados = 0; // Contador para llevar el control de los números perfectos encontrados
            int sumaDivisores = 0;

            while (encontrados < 4) // Buscamos los primeros 4 números perfectos
            {
                

                // Iteramos desde 1 hasta la mitad del número
                for (int i = 1; i <= numero / 2; i++)
                {
                    if (numero % i == 0)
                    {
                        sumaDivisores += i;
                    }
                }

                // Comprobamos si la suma de los divisores es igual al número original
                if (sumaDivisores == numero)
                {
                    Console.WriteLine("Número perfecto encontrado: " + numero);
                    encontrados++;
                }

                numero++; // Pasamos al siguiente número para continuar la búsqueda

            }

            }
    }
}
