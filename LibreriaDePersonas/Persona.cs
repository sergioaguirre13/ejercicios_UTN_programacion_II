namespace LibreriaDePersonas
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string FechaDeNacimiento { get; set; }
        public int Dni { get; set; }
        public int Edad { get; private set; }

        //constructor
        public Persona(string nombre, string fechaDeNacimiento, int dni)
        {
            Nombre = nombre;
            FechaDeNacimiento = fechaDeNacimiento;
            Dni = dni;
            Edad = CalcularEdad();
        }

        // Método privado para calcular la edad
        private int CalcularEdad()
        {
            DateTime fechaNacimiento = DateTime.ParseExact(FechaDeNacimiento, "dd/MM/yyyy", null);
            TimeSpan diferencia = DateTime.Today - fechaNacimiento;
            int edad = (int)(diferencia.Days / 365.25);
            return edad;
        }

        // Método para mostrar los datos de la persona
        public string Mostrar()
        {   
            return @$"Los datos de la persona son:
                 Nombre: {Nombre}
                 DNI: {Dni}
                 Edad: {Edad}";
        }

        public string EsMayorDeEdad()
        {
            if (Edad < 18)
            {
                return "Es menor de edad";
            }
            else
            {
                return "Es mayor de edad!";
            }
        }
    }
}









