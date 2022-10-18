
namespace Servicios_Publicos
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.mostrarRol = new System.Windows.Forms.Label();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Servicios_Publicos.DataSet1();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.Minimizar = new System.Windows.Forms.ToolTip(this.components);
            this.Maximizar = new System.Windows.Forms.ToolTip(this.components);
            this.Cerrar = new System.Windows.Forms.ToolTip(this.components);
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.Restaurar = new System.Windows.Forms.ToolTip(this.components);
            this.usuariosTableAdapter = new Servicios_Publicos.DataSet1TableAdapters.UsuariosTableAdapter();
            this.BtnCerra = new System.Windows.Forms.Button();
            this.BtnMinimizar = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BtnMaximizar = new System.Windows.Forms.Button();
            this.BtnRestaurar = new System.Windows.Forms.Button();
            this.cerrarSesion = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnAcerca = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnUsuarios = new System.Windows.Forms.Button();
            this.BtnProcesar = new System.Windows.Forms.Button();
            this.BtnReportes = new System.Windows.Forms.Button();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.mostrarRol);
            this.panelMenu.Controls.Add(this.cerrarSesion);
            this.panelMenu.Controls.Add(this.pictureBox2);
            this.panelMenu.Controls.Add(this.BtnAcerca);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.BtnUsuarios);
            this.panelMenu.Controls.Add(this.BtnProcesar);
            this.panelMenu.Controls.Add(this.BtnReportes);
            this.panelMenu.Controls.Add(this.BtnCalcular);
            this.panelMenu.Controls.Add(this.BtnClientes);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(159, 425);
            this.panelMenu.TabIndex = 0;
            // 
            // mostrarRol
            // 
            this.mostrarRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mostrarRol.AutoSize = true;
            this.mostrarRol.Enabled = false;
            this.mostrarRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mostrarRol.ForeColor = System.Drawing.Color.White;
            this.mostrarRol.Location = new System.Drawing.Point(59, 394);
            this.mostrarRol.Name = "mostrarRol";
            this.mostrarRol.Size = new System.Drawing.Size(23, 13);
            this.mostrarRol.TabIndex = 8;
            this.mostrarRol.Text = "Rol";
            this.mostrarRol.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.SlateBlue;
            this.panelBarraTitulo.Controls.Add(this.BtnCerra);
            this.panelBarraTitulo.Controls.Add(this.BtnMinimizar);
            this.panelBarraTitulo.Controls.Add(this.pictureBox3);
            this.panelBarraTitulo.Controls.Add(this.BtnMaximizar);
            this.panelBarraTitulo.Controls.Add(this.BtnRestaurar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(159, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(533, 39);
            this.panelBarraTitulo.TabIndex = 9;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(159, 39);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(533, 386);
            this.panelContenedor.TabIndex = 13;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // BtnCerra
            // 
            this.BtnCerra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCerra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerra.FlatAppearance.BorderSize = 0;
            this.BtnCerra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.BtnCerra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerra.ForeColor = System.Drawing.Color.White;
            this.BtnCerra.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerra.Image")));
            this.BtnCerra.Location = new System.Drawing.Point(497, 0);
            this.BtnCerra.Name = "BtnCerra";
            this.BtnCerra.Size = new System.Drawing.Size(34, 34);
            this.BtnCerra.TabIndex = 12;
            this.BtnCerra.UseVisualStyleBackColor = false;
            this.BtnCerra.Click += new System.EventHandler(this.BtnCerra_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimizar.Enabled = false;
            this.BtnMinimizar.FlatAppearance.BorderSize = 0;
            this.BtnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.ForeColor = System.Drawing.Color.White;
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.Location = new System.Drawing.Point(419, 0);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(34, 34);
            this.BtnMinimizar.TabIndex = 10;
            this.BtnMinimizar.UseVisualStyleBackColor = false;
            this.BtnMinimizar.Visible = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(6, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMaximizar.Enabled = false;
            this.BtnMaximizar.FlatAppearance.BorderSize = 0;
            this.BtnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximizar.ForeColor = System.Drawing.Color.White;
            this.BtnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMaximizar.Image")));
            this.BtnMaximizar.Location = new System.Drawing.Point(459, 0);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(34, 34);
            this.BtnMaximizar.TabIndex = 11;
            this.BtnMaximizar.UseVisualStyleBackColor = false;
            this.BtnMaximizar.Visible = false;
            this.BtnMaximizar.Click += new System.EventHandler(this.BtnMaximizar_Click);
            // 
            // BtnRestaurar
            // 
            this.BtnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRestaurar.Enabled = false;
            this.BtnRestaurar.FlatAppearance.BorderSize = 0;
            this.BtnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.BtnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRestaurar.ForeColor = System.Drawing.Color.White;
            this.BtnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("BtnRestaurar.Image")));
            this.BtnRestaurar.Location = new System.Drawing.Point(459, 0);
            this.BtnRestaurar.Name = "BtnRestaurar";
            this.BtnRestaurar.Size = new System.Drawing.Size(34, 34);
            this.BtnRestaurar.TabIndex = 11;
            this.BtnRestaurar.UseVisualStyleBackColor = false;
            this.BtnRestaurar.Visible = false;
            this.BtnRestaurar.Click += new System.EventHandler(this.BtnRestaurar_Click);
            // 
            // cerrarSesion
            // 
            this.cerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrarSesion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.cerrarSesion.FlatAppearance.BorderSize = 0;
            this.cerrarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.cerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarSesion.ForeColor = System.Drawing.Color.White;
            this.cerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("cerrarSesion.Image")));
            this.cerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cerrarSesion.Location = new System.Drawing.Point(0, 341);
            this.cerrarSesion.Name = "cerrarSesion";
            this.cerrarSesion.Size = new System.Drawing.Size(159, 25);
            this.cerrarSesion.TabIndex = 7;
            this.cerrarSesion.Text = "         Cerrar Sesión";
            this.cerrarSesion.UseVisualStyleBackColor = false;
            this.cerrarSesion.Click += new System.EventHandler(this.cerrarSesion_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox2.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 369);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 48);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // BtnAcerca
            // 
            this.BtnAcerca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAcerca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAcerca.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnAcerca.FlatAppearance.BorderSize = 0;
            this.BtnAcerca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.BtnAcerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAcerca.ForeColor = System.Drawing.Color.White;
            this.BtnAcerca.Image = ((System.Drawing.Image)(resources.GetObject("BtnAcerca.Image")));
            this.BtnAcerca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAcerca.Location = new System.Drawing.Point(0, 308);
            this.BtnAcerca.Name = "BtnAcerca";
            this.BtnAcerca.Size = new System.Drawing.Size(159, 25);
            this.BtnAcerca.TabIndex = 6;
            this.BtnAcerca.Text = "Acerca";
            this.BtnAcerca.UseVisualStyleBackColor = false;
            this.BtnAcerca.Click += new System.EventHandler(this.BtnAcerca_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RoyalBlue;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnUsuarios.FlatAppearance.BorderSize = 0;
            this.BtnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuarios.ForeColor = System.Drawing.Color.White;
            this.BtnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("BtnUsuarios.Image")));
            this.BtnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsuarios.Location = new System.Drawing.Point(0, 88);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Size = new System.Drawing.Size(159, 25);
            this.BtnUsuarios.TabIndex = 1;
            this.BtnUsuarios.Text = "Usuarios";
            this.BtnUsuarios.UseVisualStyleBackColor = false;
            this.BtnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // BtnProcesar
            // 
            this.BtnProcesar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProcesar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnProcesar.FlatAppearance.BorderSize = 0;
            this.BtnProcesar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.BtnProcesar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProcesar.ForeColor = System.Drawing.Color.White;
            this.BtnProcesar.Image = ((System.Drawing.Image)(resources.GetObject("BtnProcesar.Image")));
            this.BtnProcesar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProcesar.Location = new System.Drawing.Point(0, 152);
            this.BtnProcesar.Name = "BtnProcesar";
            this.BtnProcesar.Size = new System.Drawing.Size(159, 25);
            this.BtnProcesar.TabIndex = 3;
            this.BtnProcesar.Text = "Procesar";
            this.BtnProcesar.UseVisualStyleBackColor = false;
            this.BtnProcesar.Click += new System.EventHandler(this.BtnProcesar_Click);
            // 
            // BtnReportes
            // 
            this.BtnReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReportes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnReportes.FlatAppearance.BorderSize = 0;
            this.BtnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReportes.ForeColor = System.Drawing.Color.White;
            this.BtnReportes.Image = ((System.Drawing.Image)(resources.GetObject("BtnReportes.Image")));
            this.BtnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReportes.Location = new System.Drawing.Point(0, 216);
            this.BtnReportes.Name = "BtnReportes";
            this.BtnReportes.Size = new System.Drawing.Size(159, 25);
            this.BtnReportes.TabIndex = 5;
            this.BtnReportes.Text = "Reportes";
            this.BtnReportes.UseVisualStyleBackColor = false;
            this.BtnReportes.Click += new System.EventHandler(this.BtnReportes_Click);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnCalcular.FlatAppearance.BorderSize = 0;
            this.BtnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.BtnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCalcular.ForeColor = System.Drawing.Color.White;
            this.BtnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("BtnCalcular.Image")));
            this.BtnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCalcular.Location = new System.Drawing.Point(0, 184);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(159, 25);
            this.BtnCalcular.TabIndex = 4;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = false;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // BtnClientes
            // 
            this.BtnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClientes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.BtnClientes.FlatAppearance.BorderSize = 0;
            this.BtnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.ForeColor = System.Drawing.Color.White;
            this.BtnClientes.Image = ((System.Drawing.Image)(resources.GetObject("BtnClientes.Image")));
            this.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.Location = new System.Drawing.Point(0, 120);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Size = new System.Drawing.Size(159, 25);
            this.BtnClientes.TabIndex = 2;
            this.BtnClientes.Text = "Clientes";
            this.BtnClientes.UseVisualStyleBackColor = false;
            this.BtnClientes.Click += new System.EventHandler(this.BtnClientes_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Plum;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "Facturas";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 425);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelBarraTitulo);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button BtnAcerca;
        private System.Windows.Forms.Button BtnReportes;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.Button BtnProcesar;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Button BtnUsuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button BtnRestaurar;
        private System.Windows.Forms.Button BtnMaximizar;
        private System.Windows.Forms.Button BtnCerra;
        private System.Windows.Forms.Button BtnMinimizar;
        private System.Windows.Forms.ToolTip Minimizar;
        private System.Windows.Forms.ToolTip Maximizar;
        private System.Windows.Forms.ToolTip Cerrar;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.ToolTip Restaurar;
        private System.Windows.Forms.Button cerrarSesion;
        private System.Windows.Forms.Label mostrarRol;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private DataSet1TableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}