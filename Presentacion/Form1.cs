using Negocio;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToolTip = System.Windows.Forms.ToolTip;

namespace Presentacion
{
    public partial class Empresa : Form
    {
        ToolTip toolTip = new ToolTip();
        private List<Persona> lista = new List<Persona>();
        public Empresa()
        {
            InitializeComponent();
            personalizado();
            toolTip.SetToolTip(txtBuscar, "Presione Enter para buscar entre nombres, apellidos y DNI");
            txtBuscar.KeyPress += txtBuscar_KeyPress;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void personalizado()
        {
            panelSubGestion.Visible = false;
            panelSubReportes.Visible = false;
        }
        private void ocultarSubMenus()
        {
            if(panelSubGestion.Visible == true)
                panelSubGestion.Visible = false;
            if(panelSubReportes.Visible == true)
                panelSubReportes.Visible = false;
        }
        private void mostrarSubmenu(Panel subMenu)
        {
            if(subMenu.Visible == false){
                ocultarSubMenus();
                subMenu.Visible = true;
            }else
                subMenu.Visible = false;
            
        }
        private void btnGestion_MouseEnter(object sender, EventArgs e)
        {
            btnGestion.ForeColor = Color.FromArgb(179, 177, 176);
        }

        private void btnReportes_MouseEnter(object sender, EventArgs e)
        {
            btnReportes.ForeColor = Color.FromArgb(179, 177, 176);
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.FromArgb(179, 177, 176);
        }

        private void btnGestion_MouseLeave(object sender, EventArgs e)
        {
            btnGestion.ForeColor = Color.FromArgb(17, 25, 27);
        }

        private void btnReportes_MouseLeave(object sender, EventArgs e)
        {
            btnReportes.ForeColor = Color.FromArgb(17, 25, 27);
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.ForeColor = Color.FromArgb(17, 25, 27);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinizar_Click(object sender, EventArgs e)
        {
            this.WindowState= FormWindowState.Minimized;
        }
        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                txtBuscar.Text = "Buscar..";
            }
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar..")
            {
                txtBuscar.Text = "";
            }
        }

        private void btnAgregar_MouseEnter(object sender, EventArgs e)
        {
            btnAgregar.ForeColor = Color.FromArgb(179, 177, 176);
        }

        private void btnModificar_MouseEnter(object sender, EventArgs e)
        {
            btnModificar.ForeColor = Color.FromArgb(179, 177, 176);
        }

        private void btnEliminar_MouseEnter(object sender, EventArgs e)
        {
            btnEliminar.ForeColor = Color.FromArgb(179, 177, 176);
        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            btnAgregar.ForeColor = Color.FromArgb(17, 25, 27);
        }

        private void btnModificar_MouseLeave(object sender, EventArgs e)
        {
            btnModificar.ForeColor = Color.FromArgb(17, 25, 27);
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            btnEliminar.ForeColor = Color.FromArgb(17, 25, 27);
        }

        private void btnInfo_MouseLeave(object sender, EventArgs e)
        {
            btnInfo.ForeColor = Color.FromArgb(17, 25, 27);
        }

        private void btnDesempleados_MouseLeave(object sender, EventArgs e)
        {
            btnDesempleados.ForeColor = Color.FromArgb(17, 25, 27);
        }

        private void btnProfesion_MouseLeave(object sender, EventArgs e)
        {
            btnProfesion.ForeColor = Color.FromArgb(17, 25, 27);
        }

        private void btnInfo_MouseEnter(object sender, EventArgs e)
        {
            btnInfo.ForeColor = Color.FromArgb(179, 177, 176);
        }

        private void btnDesempleados_MouseEnter(object sender, EventArgs e)
        {
            btnDesempleados.ForeColor = Color.FromArgb(179, 177, 176);
        }

        private void btnProfesion_MouseEnter(object sender, EventArgs e)
        {
            btnProfesion.ForeColor = Color.FromArgb(179, 177, 176);
        }

        private void btnGestion_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelSubGestion);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            mostrarSubmenu(panelSubReportes);
        }

        private void TimerDGV_Tick(object sender, EventArgs e)
        {
            TimerDGV.Stop();
            panelDgvLector.Visible = true;
            CargarDataGridView();
        }

        private void Empresa_Load(object sender, EventArgs e)
        {
            TimerDGV.Start();
        }
        public void ocultarColumnas()
        {
            dgvLector.Columns["Id"].Visible = false;
            dgvLector.Columns["Descripcion"].Visible = false;
        }
        private void CargarDataGridView()
        {
            PersonaNegocio persona = new PersonaNegocio();
            lista = persona.listar();
            dgvLector.DataSource = lista;
            ocultarColumnas();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                List<Persona> listaFiltrada;
                listaFiltrada = lista.FindAll(x => x.Nombres.ToUpper().Contains(txtBuscar.Text.ToUpper()) || x.Apellidos.ToUpper().Contains(txtBuscar.Text.ToUpper()) || x.DNI.ToString().Contains(txtBuscar.Text.ToUpper()));
                dgvLector.DataSource = null;
                dgvLector.DataSource = listaFiltrada;
                ocultarColumnas();
                e.Handled = true;
            }
        }
    }
}
