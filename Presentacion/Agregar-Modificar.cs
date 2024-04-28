using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class Agregar_Modificar : Form
    {
        public Agregar_Modificar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Agregar_Modificar_Load(object sender, EventArgs e)
        {
            ProfesionNegocio negocio = new ProfesionNegocio();
            cbxProfesion.DataSource = negocio.listar();

        }
    }
}
