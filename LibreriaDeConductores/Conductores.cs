namespace LibreriaDeConductores
{
    public class Conductores
    {
        string nombres { get; set; }
        int[] kilometrosPorDia { get; set; }

        public Conductores(string Nombre, int[] kilometrosPorDia)
        {
            Nombre = nombres;
            kilometrosPorDia = kilometrosPorDia;
        }

       public int SumaKilometrosSemanal()
        {
            int total = 0;

            foreach (int kilometros in kilometrosPorDia)
            {
                total += kilometros;
            }

            return total;
        }

        public int KilometrosPorDia(int dia)
        {
            return kilometrosPorDia[dia];
        }

         





    }
}
