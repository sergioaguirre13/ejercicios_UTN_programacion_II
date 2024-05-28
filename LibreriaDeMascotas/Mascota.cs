namespace LibreriaDeMascotas
{
    public class Mascota
    {
        //De las mascotas necesita conocer su especie, su nombre, su fecha de nacimiento y
        //su historial de vacunación. Los primeros tres datos son obligatorios para dar de 3
        //alta una mascota, mientras que el último arrancará vacío y se podrá ir agregando vacunas.
        //De las vacunas sólo interesa conocer el nombre.

       private string nombre;
       private string especie;
       private DateTime fechaDeNacimiento;
       private string[] vacunas;

        public Mascota(string nombre, string especie, DateTime fechaDeNacimiento, string[] vacunas)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.vacunas = vacunas;
        }

        #region setters & getters

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetEspecie(string especie)
        {
            this.especie = especie;
        }

        public void SetFechaDeNac(DateTime fechaDeNac)
        {
            this.fechaDeNacimiento = fechaDeNac;
        }

        public void SetVacunas(string[] vacunas)
        {
            this.vacunas = vacunas;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public string GetEspecie()
        {
            return this.especie;
        }

        public DateTime GetFechaDeNac()
        {
            return this.fechaDeNacimiento;
        }

        public string[] getVacunas()
        {
            return this.vacunas;
        }

        #endregion

    }
}
