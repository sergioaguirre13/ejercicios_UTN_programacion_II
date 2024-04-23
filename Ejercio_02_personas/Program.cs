using LibreriaDePersonas;


namespace Ejercio_02_personas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Sergio", "13/10/1990", 30333302);
            Persona persona2 = new Persona("Pipa", "13/10/2012", 22323102);
            Persona persona3 = new Persona("Manchi", "13/10/1890", 92346743);



            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine(persona1.EsMayorDeEdad());
            Console.WriteLine("--------------------------------");
            Console.WriteLine(persona2.Mostrar());
            Console.WriteLine(persona2.EsMayorDeEdad());
            Console.WriteLine("--------------------------------");
            Console.WriteLine(persona3.Mostrar());
            Console.WriteLine(persona3.EsMayorDeEdad());


        }
    }
}
