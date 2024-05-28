using LibreriaDeClientes;
using LibreriaDeMascotas;

namespace ConsolaVeterinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaDeNac = new DateTime(1990, 10, 13);
            string[] vacunas = { "rabia" };

            Mascota mascota1 = new Mascota("Kero", "Gato", fechaDeNac, vacunas);

            Cliente cliente1 = new Cliente("Sergio", "Aguirre", "Olavarria 525", 49582454, mascota1.GetNombre());

            Console.WriteLine(cliente1.ClienteToString()); 
        }
    }
}
