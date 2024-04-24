using LibreriaDeConductores;
using static LibreriaDeConductores.Conductores;

namespace Ejercicio___A01
{
    internal class EjercicioA01
    {
        static void Main(string[] args)
        {

            EmpresaTransporte empresa = new EmpresaTransporte(3);

            int[] kilometrosConductor1 = { 200, 599, 899, 0, 256, 0, 0 };
            Conductores conductor1 = new Conductores("Eva", kilometrosConductor1);
            empresa.AgregarConductor(conductor1, 0);

            int[] kilometrosConductor2 = { 300, 700, 1000, 50, 150, 300, 100 };
            Conductores conductor2 = new Conductores("Sergio", kilometrosConductor2);
            empresa.AgregarConductor(conductor2, 1);

            int[] kilometrosConductor3 = { 150, 500, 800, 20, 0, 50, 80 };
            Conductores conductor3 = new Conductores("Pipo", kilometrosConductor3);
            empresa.AgregarConductor(conductor3, 2);

            // Mostrar el conductor que hizo más km en la semana
            Conductores conductorMasKmSemana = empresa.ConductorConMasKilometrosEnLaSemana();
            Console.WriteLine($"Conductor con más kilómetros en la semana: {conductorMasKmSemana.Nombre} ({conductorMasKmSemana.CalcularTotalKilometros()} km)");

            // Mostrar el conductor que hizo más km el día 3
            Conductores conductorMasKmDia3 = empresa.ConductorConMasKilometrosEnDia(3);
            Console.WriteLine($"Conductor con más kilómetros el día 3: {conductorMasKmDia3.Nombre} ({conductorMasKmDia3.KilometrosEnDia(3)} km)");

            // Mostrar el conductor que hizo más km el día 5
            Conductores conductorMasKmDia5 = empresa.ConductorConMasKilometrosEnDia(5);
            Console.WriteLine($"Conductor con más kilómetros el día 5: {conductorMasKmDia5.Nombre} ({conductorMasKmDia5.KilometrosEnDia(5)} km)");

            




        }
    }
 }

