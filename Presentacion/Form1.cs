using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Empresa : Form
    {
        public Empresa()
        {
            InitializeComponent();
            personalizado();
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

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            txtBuscar.Text = "Buscar..";
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
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


    }
}
