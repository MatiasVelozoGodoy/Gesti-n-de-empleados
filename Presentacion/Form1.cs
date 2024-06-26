﻿using Negocio;
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
using System.Runtime.InteropServices;

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
            toolTip.SetToolTip(txtBuscar, "Presione Enter para buscar entre nombres, apellidos o DNI");
            txtBuscar.KeyPress += txtBuscar_KeyPress;
        }
        #region Diseño
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

        //private void TimerDGV_Tick(object sender, EventArgs e)
        //{
        //    TimerDGV.Stop();
        //    panelDgvLector.Visible = true;
        //    CargarDataGridView();
        //}
        #endregion 
        private void Empresa_Load(object sender, EventArgs e)
        {
            //TimerDGV.Start();
        }
        public void ocultarColumnas()
        {
            dgvLector.Columns["Id"].Visible = false;
            dgvLector.Columns["Descripcion"].Visible = false;
        }
        public void CargarDataGridView()
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
        private Form formularioActivo = null;
        private void formularioHijo(Form formHijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelDgvLector.Controls.Add(formHijo);
            panelDgvLector.Tag = formHijo;
            formHijo.BringToFront();

            formHijo.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(Agregar_Modificar))
                {
                    MessageBox.Show("No puedes abrir otra instancia hasta terminarla o cerrarla");
                    return;
                }
            }
            formularioHijo(new Agregar_Modificar());

            CargarDataGridView();
        }
                private void dgvLector_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            panelDgvLector.Visible= false;  
            PersonaNegocio persona = new PersonaNegocio();
            lista = persona.listar();
            dgvLector.DataSource = lista;
            ocultarColumnas();
        }
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void panelControl_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
