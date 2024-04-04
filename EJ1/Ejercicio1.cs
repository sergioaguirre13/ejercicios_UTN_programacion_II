using System;

namespace EJ1
{
    internal class Ejercicio1
    {
        static void Main(string[] args)
        {

            //Ingresar 5 números por consola, guardándolos en una variable escalar.Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.


            int num1;
            int num2;
            int num3;
            int num4;
            int num5;
            int valorMax;
            int valorMin;
            int sum;
            int cantNum = 5;
            int promedio;

            Console.WriteLine("Ingresa 5 números, por favor.");
            Console.Write("1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("2: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("3: ");
            num3 = int.Parse(Console.ReadLine());
            Console.Write("4: ");
            num4 = int.Parse(Console.ReadLine());
            Console.Write("5: ");
            num5 = int.Parse(Console.ReadLine());

            sum = num1 + num2 + num3 + num4 + num5;
            promedio = sum / cantNum;

            #region valorMax
            valorMax = num1;

            if (num2 > valorMax)
            {
                valorMax = num2;
            }
            if (num3 > valorMax)
            {
                valorMax = num3;
            }
            if (num4 > valorMax)
            {
                valorMax = num4;
            }
            if (num5 > valorMax)
            {
                valorMax = num5;
            }
            #endregion

            #region ValorMin
            valorMin = num1;

            if (num2 < valorMin )
            {
                valorMin = num2;
            }
            if (num3 < valorMin)
            {
                valorMin = num3;
            }
            if (num4 < valorMin)
            {
                valorMin = num4;
            }
            if (num5 < valorMin)
            {
                valorMin = num5;
            }
            #endregion


            Console.WriteLine($"El valor maximo es: {valorMax}");
            Console.WriteLine($"El valor minimo es: {valorMin}");
            Console.WriteLine($"La suma de los valores ingresados {sum}");
            Console.WriteLine($"El promedio de los 5 valores ingresados es: {promedio}");



        }
    }
}
