using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaWindowsForms
{
    public partial class SaludarForm : Form
    {
        public SaludarForm(string nombre,string apellido,string materia)
        {
            InitializeComponent();


            lblHola.Text = "Hola! Windows Forms!";
            lblNombreApellido.Text = $"soy {nombre} {apellido} y mi materia favorita es: {materia} ";
        }


    }
}
