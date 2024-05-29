using static System.Runtime.InteropServices.JavaScript.JSType;
using LibreriaDeMascotas;

namespace LibreriaDeClientes
{
    public class Cliente
    {
        //De los clientes le interesa conocer el domicilio, el nombre y apellido y
        //un teléfono.A un cliente se le pueden asociar una o más mascotas.

        private string nombre;
        private string apellido;
        private string domicilio;
        private int telefono;
        private List<Mascota> listaMascotas; 
       

        public Cliente(string nombre, string apellido, string domicilio, int telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.domicilio = domicilio;
            this.telefono = telefono;
            listaMascotas =  new List<Mascota>();
        }

        #region setters & getters

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public void SetDomicilio(string domicilio)
        {
            this.domicilio = domicilio;
        }

        public void SetTelefono(int telefono)
        {
            this.telefono = telefono;
        }

      



        public string GetNombre()
        {
            return this.nombre;
        }

        public string GetApellido()
        { 
            return this.apellido;
        }

        public string GetDomicilio() 
        {
            return this.domicilio;
        }

        public int GetTelefono()
        {
            return this.telefono;
        }



        #endregion

        public void MascotaALista(Mascota mascota)
        {
            listaMascotas.Add(mascota);
        }

        

        public override string ToString()
        {
            return $"Cliente {nombre} {apellido} - Domicilio {domicilio} - telefono {telefono} - {string.Join(", ", listaMascotas )} ";
        }

        
    }
}