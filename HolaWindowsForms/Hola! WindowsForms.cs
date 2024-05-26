using System.Security.Cryptography.X509Certificates;

namespace HolaWindowsForms
{
    public partial class HolaForm : Form
    {


        public HolaForm()
        {
            InitializeComponent();
            
        }

        private void HolaForm_Load(object sender, EventArgs e)
        {
            CargarMaterias(ListaMaterias());
        }



        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string materiaFav = cmbMateria.SelectedItem.ToString();

            SaludarForm saludar = new SaludarForm(nombre, apellido, materiaFav);
            saludar.Show();


        }

        public static List<string> ListaMaterias()
        {
            List<string> listaDeMaterias = new List<string>()
            {
                "programacion I","programacion II","programacion III"
            };

            return listaDeMaterias;
        }

        private void CargarMaterias(List<string> materias)
        {
            foreach (string materia in materias)
            {
                cmbMateria.Items.AddRange(materias.ToArray());
            }

        }

        
    }
}
