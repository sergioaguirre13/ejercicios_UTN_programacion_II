namespace LibreriaDeConductores
{
    public class Conductores
    {
        public string Nombre { get; set; }
        public int[] KilometrosPorDia { get; set; }

        public Conductores(string nombre, int[] kilometrosPorDia)
        {
            Nombre = nombre;
            KilometrosPorDia = kilometrosPorDia;
        }

        public int CalcularTotalKilometros()
        {
            int totalKilometros = 0;
            foreach (int km in KilometrosPorDia)
            {
                totalKilometros += km;
            }
            return totalKilometros;
        }

        public int KilometrosEnDia(int dia)
        {
            return KilometrosPorDia[dia - 1];
        }

        //**********************************************

        public class EmpresaTransporte
        {
            private Conductores[] conductores;

            public EmpresaTransporte(int cantidadConductores)
            {
                conductores = new Conductores[cantidadConductores];
            }

            public void AgregarConductor(Conductores conductor, int indice)
            {
                conductores[indice] = conductor;
            }

            public Conductores ConductorConMasKilometrosEnLaSemana()
            {
                Conductores conductorMasKilometros = conductores[0];
                foreach (Conductores conductor in conductores)
                {
                    if (conductor.CalcularTotalKilometros() > conductorMasKilometros.CalcularTotalKilometros())
                    {
                        conductorMasKilometros = conductor;
                    }
                }
                return conductorMasKilometros;
            }

            public Conductores ConductorConMasKilometrosEnDia(int dia)
            {
                Conductores conductorMasKilometros = conductores[0];
                foreach (Conductores conductor in conductores)
                {
                    if (conductor.KilometrosEnDia(dia) > conductorMasKilometros.KilometrosEnDia(dia))
                    {
                        conductorMasKilometros = conductor;
                    }
                }
                return conductorMasKilometros;
            }
        }







    }
}
