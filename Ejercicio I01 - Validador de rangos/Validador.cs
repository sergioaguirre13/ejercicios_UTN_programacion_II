using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01___Validador_de_rangos
{

                    //Pedir al usuario que ingrese 10 números enteros.Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.
                //Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
    public class Validador
    {
      

        public static bool Validar(int valor, int min, int max)
        {

           
            if (valor > min && valor < max )
            {
                return true;
            }
            else
            {
                return false;
            }
      
        }
    }
}
