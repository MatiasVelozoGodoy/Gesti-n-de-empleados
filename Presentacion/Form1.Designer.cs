namespace Presentacion
{
    partial class Empresa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empresa));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelSubReportes = new System.Windows.Forms.Panel();
            this.btnProfesion = new System.Windows.Forms.Button();
            this.btnDesempleados = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.panelSubGestion = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panelFoto = new System.Windows.Forms.Panel();
            this.lblGestion = new System.Windows.Forms.Label();
            this.panelControl = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnMinizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.TimerDGV = new System.Windows.Forms.Timer(this.components);
            this.panelDgvLector = new System.Windows.Forms.Panel();
            this.dgvLector = new System.Windows.Forms.DataGridView();
            this.pbxIMGinicial = new System.Windows.Forms.PictureBox();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGestion = new System.Windows.Forms.Button();
            this.pbxIMG = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelSubReportes.SuspendLayout();
            this.panelSubGestion.SuspendLayout();
            this.panelFoto.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.panelDgvLector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIMGinicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(161)))), ((int)(((byte)(125)))));
            this.panelMenu.Controls.Add(this.panelSubReportes);
            this.panelMenu.Controls.Add(this.btnReportes);
            this.panelMenu.Controls.Add(this.panelSubGestion);
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Controls.Add(this.btnGestion);
            this.panelMenu.Controls.Add(this.panelFoto);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(195, 670);
            this.panelMenu.TabIndex = 1;
            // 
            // panelSubReportes
            // 
            this.panelSubReportes.Controls.Add(this.btnProfesion);
            this.panelSubReportes.Controls.Add(this.btnDesempleados);
            this.panelSubReportes.Controls.Add(this.btnInfo);
            this.panelSubReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubReportes.Location = new System.Drawing.Point(0, 414);
            this.panelSubReportes.Name = "panelSubReportes";
            this.panelSubReportes.Size = new System.Drawing.Size(195, 133);
            this.panelSubReportes.TabIndex = 14;
            // 
            // btnProfesion
            // 
            this.btnProfesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(181)))), ((int)(((byte)(145)))));
            this.btnProfesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfesion.FlatAppearance.BorderSize = 0;
            this.btnProfesion.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnProfesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.btnProfesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.btnProfesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesion.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.btnProfesion.Location = new System.Drawing.Point(0, 88);
            this.btnProfesion.Name = "btnProfesion";
            this.btnProfesion.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnProfesion.Size = new System.Drawing.Size(195, 44);
            this.btnProfesion.TabIndex = 18;
            this.btnProfesion.Text = "Mostrar por profesión";
            this.btnProfesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfesion.UseVisualStyleBackColor = false;
            this.btnProfesion.MouseEnter += new System.EventHandler(this.btnProfesion_MouseEnter);
            this.btnProfesion.MouseLeave += new System.EventHandler(this.btnProfesion_MouseLeave);
            // 
            // btnDesempleados
            // 
            this.btnDesempleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(181)))), ((int)(((byte)(145)))));
            this.btnDesempleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDesempleados.FlatAppearance.BorderSize = 0;
            this.btnDesempleados.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDesempleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.btnDesempleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.btnDesempleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesempleados.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesempleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.btnDesempleados.Location = new System.Drawing.Point(0, 44);
            this.btnDesempleados.Name = "btnDesempleados";
            this.btnDesempleados.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnDesempleados.Size = new System.Drawing.Size(195, 44);
            this.btnDesempleados.TabIndex = 17;
            this.btnDesempleados.Text = "Mostrar desempleados";
            this.btnDesempleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDesempleados.UseVisualStyleBackColor = false;
            this.btnDesempleados.MouseEnter += new System.EventHandler(this.btnDesempleados_MouseEnter);
            this.btnDesempleados.MouseLeave += new System.EventHandler(this.btnDesempleados_MouseLeave);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(181)))), ((int)(((byte)(145)))));
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.btnInfo.Location = new System.Drawing.Point(0, 0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnInfo.Size = new System.Drawing.Size(195, 44);
            this.btnInfo.TabIndex = 16;
            this.btnInfo.Text = "Mostra información";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.MouseEnter += new System.EventHandler(this.btnInfo_MouseEnter);
            this.btnInfo.MouseLeave += new System.EventHandler(this.btnInfo_MouseLeave);
            // 
            // panelSubGestion
            // 
            this.panelSubGestion.Controls.Add(this.btnEliminar);
            this.panelSubGestion.Controls.Add(this.btnModificar);
            this.panelSubGestion.Controls.Add(this.btnAgregar);
            this.panelSubGestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubGestion.Location = new System.Drawing.Point(0, 211);
            this.panelSubGestion.Name = "panelSubGestion";
            this.panelSubGestion.Size = new System.Drawing.Size(195, 133);
            this.panelSubGestion.TabIndex = 10;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(181)))), ((int)(((byte)(145)))));
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.btnEliminar.Location = new System.Drawing.Point(0, 88);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnEliminar.Size = new System.Drawing.Size(195, 44);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.MouseEnter += new System.EventHandler(this.btnEliminar_MouseEnter);
            this.btnEliminar.MouseLeave += new System.EventHandler(this.btnEliminar_MouseLeave);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(181)))), ((int)(((byte)(145)))));
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.btnModificar.Location = new System.Drawing.Point(0, 44);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnModificar.Size = new System.Drawing.Size(195, 44);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.MouseEnter += new System.EventHandler(this.btnModificar_MouseEnter);
            this.btnModificar.MouseLeave += new System.EventHandler(this.btnModificar_MouseLeave);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(181)))), ((int)(((byte)(145)))));
            this.btnAgregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.btnAgregar.Location = new System.Drawing.Point(0, 0);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnAgregar.Size = new System.Drawing.Size(195, 44);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.MouseEnter += new System.EventHandler(this.btnAgregar_MouseEnter);
            this.btnAgregar.MouseLeave += new System.EventHandler(this.btnAgregar_MouseLeave);
            // 
            // panelFoto
            // 
            this.panelFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.panelFoto.Controls.Add(this.lblGestion);
            this.panelFoto.Controls.Add(this.pbxIMG);
            this.panelFoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFoto.Location = new System.Drawing.Point(0, 0);
            this.panelFoto.Name = "panelFoto";
            this.panelFoto.Size = new System.Drawing.Size(195, 141);
            this.panelFoto.TabIndex = 0;
            // 
            // lblGestion
            // 
            this.lblGestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.lblGestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblGestion.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(177)))), ((int)(((byte)(176)))));
            this.lblGestion.Location = new System.Drawing.Point(0, 64);
            this.lblGestion.Name = "lblGestion";
            this.lblGestion.Size = new System.Drawing.Size(195, 69);
            this.lblGestion.TabIndex = 1;
            this.lblGestion.Text = "Gestión de usuarios";
            this.lblGestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.panelControl.Controls.Add(this.txtBuscar);
            this.panelControl.Controls.Add(this.btnMinizar);
            this.panelControl.Controls.Add(this.btnCerrar);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(195, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(727, 61);
            this.panelControl.TabIndex = 0;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(177)))), ((int)(((byte)(176)))));
            this.txtBuscar.Location = new System.Drawing.Point(42, 17);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(206, 27);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.Text = "Buscar..";
            this.txtBuscar.Enter += new System.EventHandler(this.txtBuscar_Enter);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            this.txtBuscar.Leave += new System.EventHandler(this.txtBuscar_Leave);
            // 
            // btnMinizar
            // 
            this.btnMinizar.FlatAppearance.BorderSize = 0;
            this.btnMinizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(177)))), ((int)(((byte)(176)))));
            this.btnMinizar.Location = new System.Drawing.Point(657, 1);
            this.btnMinizar.Name = "btnMinizar";
            this.btnMinizar.Size = new System.Drawing.Size(35, 35);
            this.btnMinizar.TabIndex = 1;
            this.btnMinizar.Text = "-";
            this.btnMinizar.UseVisualStyleBackColor = true;
            this.btnMinizar.Click += new System.EventHandler(this.btnMinizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(177)))), ((int)(((byte)(176)))));
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCerrar.Location = new System.Drawing.Point(691, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.btnCerrar.Size = new System.Drawing.Size(35, 35);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.Text = "X";
            this.btnCerrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Modern No. 20", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(177)))), ((int)(((byte)(176)))));
            this.lblBienvenido.Location = new System.Drawing.Point(370, 414);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(351, 65);
            this.lblBienvenido.TabIndex = 3;
            this.lblBienvenido.Text = "¡Bienvenido!";
            // 
            // TimerDGV
            // 
            this.TimerDGV.Interval = 2000;
            this.TimerDGV.Tick += new System.EventHandler(this.TimerDGV_Tick);
            // 
            // panelDgvLector
            // 
            this.panelDgvLector.Controls.Add(this.dgvLector);
            this.panelDgvLector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDgvLector.Location = new System.Drawing.Point(195, 61);
            this.panelDgvLector.Name = "panelDgvLector";
            this.panelDgvLector.Size = new System.Drawing.Size(727, 609);
            this.panelDgvLector.TabIndex = 4;
            this.panelDgvLector.Visible = false;
            // 
            // dgvLector
            // 
            this.dgvLector.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLector.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.dgvLector.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLector.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvLector.Location = new System.Drawing.Point(0, 0);
            this.dgvLector.Name = "dgvLector";
            this.dgvLector.RowHeadersVisible = false;
            this.dgvLector.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLector.Size = new System.Drawing.Size(727, 609);
            this.dgvLector.TabIndex = 0;
            // 
            // pbxIMGinicial
            // 
            this.pbxIMGinicial.Image = ((System.Drawing.Image)(resources.GetObject("pbxIMGinicial.Image")));
            this.pbxIMGinicial.Location = new System.Drawing.Point(412, 157);
            this.pbxIMGinicial.Name = "pbxIMGinicial";
            this.pbxIMGinicial.Size = new System.Drawing.Size(248, 223);
            this.pbxIMGinicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxIMGinicial.TabIndex = 2;
            this.pbxIMGinicial.TabStop = false;
            // 
            // btnReportes
            // 
            this.btnReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportes.FlatAppearance.BorderSize = 0;
            this.btnReportes.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.btnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportes.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.btnReportes.Image = ((System.Drawing.Image)(resources.GetObject("btnReportes.Image")));
            this.btnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReportes.Location = new System.Drawing.Point(0, 344);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReportes.Size = new System.Drawing.Size(195, 70);
            this.btnReportes.TabIndex = 13;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            this.btnReportes.MouseEnter += new System.EventHandler(this.btnReportes_MouseEnter);
            this.btnReportes.MouseLeave += new System.EventHandler(this.btnReportes_MouseLeave);
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Location = new System.Drawing.Point(0, 600);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(195, 70);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseEnter += new System.EventHandler(this.btnSalir_MouseEnter);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            // 
            // btnGestion
            // 
            this.btnGestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestion.FlatAppearance.BorderSize = 0;
            this.btnGestion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(60)))));
            this.btnGestion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.btnGestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestion.Font = new System.Drawing.Font("Georgia", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.btnGestion.Image = ((System.Drawing.Image)(resources.GetObject("btnGestion.Image")));
            this.btnGestion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGestion.Location = new System.Drawing.Point(0, 141);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGestion.Size = new System.Drawing.Size(195, 70);
            this.btnGestion.TabIndex = 1;
            this.btnGestion.Text = "Gestión";
            this.btnGestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnGestion.UseVisualStyleBackColor = true;
            this.btnGestion.Click += new System.EventHandler(this.btnGestion_Click);
            this.btnGestion.MouseEnter += new System.EventHandler(this.btnGestion_MouseEnter);
            this.btnGestion.MouseLeave += new System.EventHandler(this.btnGestion_MouseLeave);
            // 
            // pbxIMG
            // 
            this.pbxIMG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxIMG.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbxIMG.Image = ((System.Drawing.Image)(resources.GetObject("pbxIMG.Image")));
            this.pbxIMG.Location = new System.Drawing.Point(0, 0);
            this.pbxIMG.Name = "pbxIMG";
            this.pbxIMG.Size = new System.Drawing.Size(195, 64);
            this.pbxIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxIMG.TabIndex = 0;
            this.pbxIMG.TabStop = false;
            // 
            // Empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(77)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(922, 670);
            this.Controls.Add(this.panelDgvLector);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.pbxIMGinicial);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Empresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion";
            this.Load += new System.EventHandler(this.Empresa_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelSubReportes.ResumeLayout(false);
            this.panelSubGestion.ResumeLayout(false);
            this.panelFoto.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.panelDgvLector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIMGinicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIMG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelFoto;
        private System.Windows.Forms.Label lblGestion;
        private System.Windows.Forms.PictureBox pbxIMG;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinizar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnGestion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelSubGestion;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panelSubReportes;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnProfesion;
        private System.Windows.Forms.Button btnDesempleados;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.PictureBox pbxIMGinicial;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Timer TimerDGV;
        private System.Windows.Forms.Panel panelDgvLector;
        private System.Windows.Forms.DataGridView dgvLector;
    }
}

