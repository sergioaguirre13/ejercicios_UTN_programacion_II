namespace Ejercicio_I01___Validador_de_rangos
{
    internal class EJ1
    {
        static void Main(string[] args)
        {

            //Pedir al usuario que ingrese 10 números enteros.Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.
            //Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.

                int num = 0;
                int cantNumeros = 10;
                int sumaNum = 0;
                int min = -100;
                int max = 100;
                int valorMax = int.MinValue;
                int valorMin = int.MaxValue;
                double promedio = 0;

                for (int i = 0; i < cantNumeros; i++)
                {

                    Console.WriteLine($"Ingrese un numero - {i + 1}");
                    num = int.Parse(Console.ReadLine());

                    if (Validador.Validar(num,min,max))
                    {
                        Console.WriteLine("Numero valido, siga cargando!");
                        sumaNum += num;
                        valorMax = Math.Max(valorMax, num);
                        valorMin = Math.Min(valorMin, num);

                    }
                    else
                    {
                        Console.WriteLine("Numero invalido. ALTO AHI!");
                        break;
                    }

                }

                Console.WriteLine($"Valor maximo: {valorMax}");
                Console.WriteLine($"Valor minimo: {valorMin}");

                Console.WriteLine($"La suma de todos los numeros ingresados es: {sumaNum}");
                promedio = (double)sumaNum / cantNumeros;
                Console.WriteLine($"El promedio de los números ingresados es: {promedio}");

        }


    }
}


