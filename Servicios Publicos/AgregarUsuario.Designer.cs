
namespace Servicios_Publicos
{
    partial class AgregarUsuario
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
            System.Windows.Forms.Label ElimFotAgrUsu;
            System.Windows.Forms.Label idUsuarioLabel;
            System.Windows.Forms.Label fotoLabel;
            System.Windows.Forms.Label documentoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label rolLabel;
            System.Windows.Forms.Label passwordLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarUsuario));
            this.panelAgUsuario = new System.Windows.Forms.Panel();
            this.formAgregarUsuario = new System.Windows.Forms.Label();
            this.buttCerrAgrUsu = new System.Windows.Forms.Button();
            this.btnAgregarUsu = new System.Windows.Forms.Button();
            this.btnCancelarUsu = new System.Windows.Forms.Button();
            this.panelIdAgrUsu = new System.Windows.Forms.Panel();
            this.idUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Servicios_Publicos.DataSet1();
            this.usuariosTableAdapter = new Servicios_Publicos.DataSet1TableAdapters.UsuariosTableAdapter();
            this.tableAdapterManager = new Servicios_Publicos.DataSet1TableAdapters.TableAdapterManager();
            this.documentoTextBoxAU = new System.Windows.Forms.TextBox();
            this.nombreTextBoxAU = new System.Windows.Forms.TextBox();
            this.usuarioTextBoxAU = new System.Windows.Forms.TextBox();
            this.rolComboBoxAU = new System.Windows.Forms.ComboBox();
            this.passwordTextBoxAU = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.fotoPictureBoxAU = new System.Windows.Forms.PictureBox();
            this.openFileImg = new System.Windows.Forms.OpenFileDialog();
            ElimFotAgrUsu = new System.Windows.Forms.Label();
            idUsuarioLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            documentoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            rolLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            this.panelAgUsuario.SuspendLayout();
            this.panelIdAgrUsu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBoxAU)).BeginInit();
            this.SuspendLayout();
            // 
            // ElimFotAgrUsu
            // 
            ElimFotAgrUsu.AutoSize = true;
            ElimFotAgrUsu.Cursor = System.Windows.Forms.Cursors.Hand;
            ElimFotAgrUsu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            ElimFotAgrUsu.ForeColor = System.Drawing.Color.White;
            ElimFotAgrUsu.Location = new System.Drawing.Point(167, 252);
            ElimFotAgrUsu.Name = "ElimFotAgrUsu";
            ElimFotAgrUsu.Size = new System.Drawing.Size(43, 13);
            ElimFotAgrUsu.TabIndex = 19;
            ElimFotAgrUsu.Text = "Eliminar";
            ElimFotAgrUsu.Click += new System.EventHandler(this.ElimFotAgrUsu_Click);
            // 
            // idUsuarioLabel
            // 
            idUsuarioLabel.AutoSize = true;
            idUsuarioLabel.ForeColor = System.Drawing.Color.White;
            idUsuarioLabel.Location = new System.Drawing.Point(8, 15);
            idUsuarioLabel.Name = "idUsuarioLabel";
            idUsuarioLabel.Size = new System.Drawing.Size(58, 13);
            idUsuarioLabel.TabIndex = 21;
            idUsuarioLabel.Text = "Id Usuario:";
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            fotoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            fotoLabel.ForeColor = System.Drawing.Color.White;
            fotoLabel.Location = new System.Drawing.Point(65, 252);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(70, 13);
            fotoLabel.TabIndex = 23;
            fotoLabel.Text = "Adjuntar Foto";
            fotoLabel.Click += new System.EventHandler(this.fotoLabel_Click);
            // 
            // documentoLabel
            // 
            documentoLabel.AutoSize = true;
            documentoLabel.ForeColor = System.Drawing.Color.White;
            documentoLabel.Location = new System.Drawing.Point(276, 127);
            documentoLabel.Name = "documentoLabel";
            documentoLabel.Size = new System.Drawing.Size(65, 13);
            documentoLabel.TabIndex = 25;
            documentoLabel.Text = "Documento:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.ForeColor = System.Drawing.Color.White;
            nombreLabel.Location = new System.Drawing.Point(276, 153);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 27;
            nombreLabel.Text = "Nombre:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.ForeColor = System.Drawing.Color.White;
            usuarioLabel.Location = new System.Drawing.Point(276, 179);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(46, 13);
            usuarioLabel.TabIndex = 29;
            usuarioLabel.Text = "Usuario:";
            // 
            // rolLabel
            // 
            rolLabel.AutoSize = true;
            rolLabel.ForeColor = System.Drawing.Color.White;
            rolLabel.Location = new System.Drawing.Point(276, 205);
            rolLabel.Name = "rolLabel";
            rolLabel.Size = new System.Drawing.Size(26, 13);
            rolLabel.TabIndex = 31;
            rolLabel.Text = "Rol:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.ForeColor = System.Drawing.Color.White;
            passwordLabel.Location = new System.Drawing.Point(276, 232);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 33;
            passwordLabel.Text = "Password:";
            // 
            // panelAgUsuario
            // 
            this.panelAgUsuario.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelAgUsuario.Controls.Add(this.formAgregarUsuario);
            this.panelAgUsuario.Controls.Add(this.buttCerrAgrUsu);
            this.panelAgUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAgUsuario.Location = new System.Drawing.Point(0, 0);
            this.panelAgUsuario.Name = "panelAgUsuario";
            this.panelAgUsuario.Size = new System.Drawing.Size(532, 39);
            this.panelAgUsuario.TabIndex = 1;
            // 
            // formAgregarUsuario
            // 
            this.formAgregarUsuario.AutoSize = true;
            this.formAgregarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formAgregarUsuario.ForeColor = System.Drawing.Color.White;
            this.formAgregarUsuario.Location = new System.Drawing.Point(12, 7);
            this.formAgregarUsuario.Name = "formAgregarUsuario";
            this.formAgregarUsuario.Size = new System.Drawing.Size(169, 25);
            this.formAgregarUsuario.TabIndex = 1;
            this.formAgregarUsuario.Text = "Agregar Usuario";
            // 
            // buttCerrAgrUsu
            // 
            this.buttCerrAgrUsu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttCerrAgrUsu.FlatAppearance.BorderSize = 0;
            this.buttCerrAgrUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttCerrAgrUsu.Image = ((System.Drawing.Image)(resources.GetObject("buttCerrAgrUsu.Image")));
            this.buttCerrAgrUsu.Location = new System.Drawing.Point(493, 0);
            this.buttCerrAgrUsu.Name = "buttCerrAgrUsu";
            this.buttCerrAgrUsu.Size = new System.Drawing.Size(39, 39);
            this.buttCerrAgrUsu.TabIndex = 2;
            this.buttCerrAgrUsu.UseVisualStyleBackColor = true;
            this.buttCerrAgrUsu.Click += new System.EventHandler(this.buttCerrAgrUsu_Click);
            // 
            // btnAgregarUsu
            // 
            this.btnAgregarUsu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarUsu.FlatAppearance.BorderSize = 0;
            this.btnAgregarUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarUsu.ForeColor = System.Drawing.Color.White;
            this.btnAgregarUsu.Location = new System.Drawing.Point(179, 342);
            this.btnAgregarUsu.Name = "btnAgregarUsu";
            this.btnAgregarUsu.Size = new System.Drawing.Size(60, 27);
            this.btnAgregarUsu.TabIndex = 17;
            this.btnAgregarUsu.Text = "Agregar";
            this.btnAgregarUsu.UseVisualStyleBackColor = true;
            this.btnAgregarUsu.Click += new System.EventHandler(this.btnAgregarUsuAU_Click);
            // 
            // btnCancelarUsu
            // 
            this.btnCancelarUsu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarUsu.FlatAppearance.BorderSize = 0;
            this.btnCancelarUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarUsu.ForeColor = System.Drawing.Color.White;
            this.btnCancelarUsu.Location = new System.Drawing.Point(294, 342);
            this.btnCancelarUsu.Name = "btnCancelarUsu";
            this.btnCancelarUsu.Size = new System.Drawing.Size(60, 27);
            this.btnCancelarUsu.TabIndex = 18;
            this.btnCancelarUsu.Text = "Cancelar";
            this.btnCancelarUsu.UseVisualStyleBackColor = true;
            this.btnCancelarUsu.Click += new System.EventHandler(this.btnCancelarUsu_Click);
            // 
            // panelIdAgrUsu
            // 
            this.panelIdAgrUsu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panelIdAgrUsu.Controls.Add(idUsuarioLabel);
            this.panelIdAgrUsu.Controls.Add(this.idUsuarioTextBox);
            this.panelIdAgrUsu.Location = new System.Drawing.Point(53, 304);
            this.panelIdAgrUsu.Name = "panelIdAgrUsu";
            this.panelIdAgrUsu.Size = new System.Drawing.Size(10, 10);
            this.panelIdAgrUsu.TabIndex = 20;
            // 
            // idUsuarioTextBox
            // 
            this.idUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "IdUsuario", true));
            this.idUsuarioTextBox.Location = new System.Drawing.Point(79, 12);
            this.idUsuarioTextBox.Name = "idUsuarioTextBox";
            this.idUsuarioTextBox.Size = new System.Drawing.Size(121, 20);
            this.idUsuarioTextBox.TabIndex = 22;
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
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Servicios_Publicos.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = this.usuariosTableAdapter;
            // 
            // documentoTextBoxAU
            // 
            this.documentoTextBoxAU.Location = new System.Drawing.Point(347, 124);
            this.documentoTextBoxAU.Name = "documentoTextBoxAU";
            this.documentoTextBoxAU.Size = new System.Drawing.Size(121, 20);
            this.documentoTextBoxAU.TabIndex = 26;
            this.documentoTextBoxAU.TextChanged += new System.EventHandler(this.documentoTextBoxAU_TextChanged);
            this.documentoTextBoxAU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.documentoTextBoxAU_KeyPress);
            // 
            // nombreTextBoxAU
            // 
            this.nombreTextBoxAU.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextBoxAU.Location = new System.Drawing.Point(347, 150);
            this.nombreTextBoxAU.Name = "nombreTextBoxAU";
            this.nombreTextBoxAU.Size = new System.Drawing.Size(121, 20);
            this.nombreTextBoxAU.TabIndex = 28;
            this.nombreTextBoxAU.TextChanged += new System.EventHandler(this.nombreTextBoxAU_TextChanged);
            this.nombreTextBoxAU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreTextBoxAU_KeyPress);
            // 
            // usuarioTextBoxAU
            // 
            this.usuarioTextBoxAU.Location = new System.Drawing.Point(347, 176);
            this.usuarioTextBoxAU.Name = "usuarioTextBoxAU";
            this.usuarioTextBoxAU.Size = new System.Drawing.Size(121, 20);
            this.usuarioTextBoxAU.TabIndex = 30;
            this.usuarioTextBoxAU.TextChanged += new System.EventHandler(this.usuarioTextBoxAU_TextChanged);
            // 
            // rolComboBoxAU
            // 
            this.rolComboBoxAU.FormattingEnabled = true;
            this.rolComboBoxAU.Items.AddRange(new object[] {
            "Administrador",
            "Facturador",
            "Digitador"});
            this.rolComboBoxAU.Location = new System.Drawing.Point(347, 202);
            this.rolComboBoxAU.Name = "rolComboBoxAU";
            this.rolComboBoxAU.Size = new System.Drawing.Size(121, 21);
            this.rolComboBoxAU.TabIndex = 32;
            this.rolComboBoxAU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rolComboBoxAU_KeyPress);
            // 
            // passwordTextBoxAU
            // 
            this.passwordTextBoxAU.Location = new System.Drawing.Point(347, 229);
            this.passwordTextBoxAU.Name = "passwordTextBoxAU";
            this.passwordTextBoxAU.PasswordChar = '*';
            this.passwordTextBoxAU.Size = new System.Drawing.Size(121, 20);
            this.passwordTextBoxAU.TabIndex = 34;
            this.passwordTextBoxAU.TextChanged += new System.EventHandler(this.passwordTextBoxAU_TextChanged);
            // 
            // fotoPictureBoxAU
            // 
            this.fotoPictureBoxAU.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fotoPictureBoxAU.Location = new System.Drawing.Point(66, 121);
            this.fotoPictureBoxAU.Name = "fotoPictureBoxAU";
            this.fotoPictureBoxAU.Size = new System.Drawing.Size(137, 128);
            this.fotoPictureBoxAU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoPictureBoxAU.TabIndex = 24;
            this.fotoPictureBoxAU.TabStop = false;
            // 
            // openFileImg
            // 
            this.openFileImg.FileName = "openFileDialog1";
            // 
            // AgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(532, 386);
            this.Controls.Add(fotoLabel);
            this.Controls.Add(this.fotoPictureBoxAU);
            this.Controls.Add(documentoLabel);
            this.Controls.Add(this.documentoTextBoxAU);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBoxAU);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(this.usuarioTextBoxAU);
            this.Controls.Add(rolLabel);
            this.Controls.Add(this.rolComboBoxAU);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBoxAU);
            this.Controls.Add(this.panelIdAgrUsu);
            this.Controls.Add(ElimFotAgrUsu);
            this.Controls.Add(this.btnCancelarUsu);
            this.Controls.Add(this.btnAgregarUsu);
            this.Controls.Add(this.panelAgUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarUsuario";
            this.Load += new System.EventHandler(this.AgregarUsuario_Load);
            this.panelAgUsuario.ResumeLayout(false);
            this.panelAgUsuario.PerformLayout();
            this.panelIdAgrUsu.ResumeLayout(false);
            this.panelIdAgrUsu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBoxAU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAgUsuario;
        private System.Windows.Forms.Label formAgregarUsuario;
        private System.Windows.Forms.Button buttCerrAgrUsu;
        private System.Windows.Forms.Button btnAgregarUsu;
        private System.Windows.Forms.Button btnCancelarUsu;
        private System.Windows.Forms.Panel panelIdAgrUsu;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private DataSet1TableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idUsuarioTextBox;
        private System.Windows.Forms.PictureBox fotoPictureBoxAU;
        private System.Windows.Forms.TextBox documentoTextBoxAU;
        private System.Windows.Forms.TextBox nombreTextBoxAU;
        private System.Windows.Forms.TextBox usuarioTextBoxAU;
        private System.Windows.Forms.ComboBox rolComboBoxAU;
        private System.Windows.Forms.TextBox passwordTextBoxAU;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.OpenFileDialog openFileImg;
    }
}