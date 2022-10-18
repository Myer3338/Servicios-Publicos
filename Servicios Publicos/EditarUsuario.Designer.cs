
namespace Servicios_Publicos
{
    partial class EditarUsuario
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
            System.Windows.Forms.Label fotoLabelEditUsu;
            System.Windows.Forms.Label documentoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label rolLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label EliminarFotoEditUsu;
            System.Windows.Forms.Label idUsuarioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarUsuario));
            this.formEditUsuario = new System.Windows.Forms.Panel();
            this.buttCerrEditUsuario = new System.Windows.Forms.Button();
            this.labelEditarUsuario = new System.Windows.Forms.Label();
            this.dataSet1 = new Servicios_Publicos.DataSet1();
            this.fotoPictureBoxEditUsu = new System.Windows.Forms.PictureBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentoTextBoxEU = new System.Windows.Forms.TextBox();
            this.nombreTextBoxEU = new System.Windows.Forms.TextBox();
            this.usuarioTextBoxEU = new System.Windows.Forms.TextBox();
            this.rolComboBoxEU = new System.Windows.Forms.ComboBox();
            this.passwordTextBoxEU = new System.Windows.Forms.TextBox();
            this.cancelarEditUsua = new System.Windows.Forms.Button();
            this.btnguardarcambiosEditUsu = new System.Windows.Forms.Button();
            this.openFileImgEdit = new System.Windows.Forms.OpenFileDialog();
            this.usuariosTableAdapter = new Servicios_Publicos.DataSet1TableAdapters.UsuariosTableAdapter();
            this.tableAdapterManager = new Servicios_Publicos.DataSet1TableAdapters.TableAdapterManager();
            this.idUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            fotoLabelEditUsu = new System.Windows.Forms.Label();
            documentoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            rolLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            EliminarFotoEditUsu = new System.Windows.Forms.Label();
            idUsuarioLabel = new System.Windows.Forms.Label();
            this.formEditUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBoxEditUsu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fotoLabelEditUsu
            // 
            fotoLabelEditUsu.AutoSize = true;
            fotoLabelEditUsu.Cursor = System.Windows.Forms.Cursors.Hand;
            fotoLabelEditUsu.ForeColor = System.Drawing.Color.White;
            fotoLabelEditUsu.Location = new System.Drawing.Point(77, 265);
            fotoLabelEditUsu.Name = "fotoLabelEditUsu";
            fotoLabelEditUsu.Size = new System.Drawing.Size(28, 13);
            fotoLabelEditUsu.TabIndex = 4;
            fotoLabelEditUsu.Text = "Foto";
            fotoLabelEditUsu.Click += new System.EventHandler(this.fotoLabelEditUsu_Click);
            // 
            // documentoLabel
            // 
            documentoLabel.AutoSize = true;
            documentoLabel.ForeColor = System.Drawing.Color.White;
            documentoLabel.Location = new System.Drawing.Point(273, 138);
            documentoLabel.Name = "documentoLabel";
            documentoLabel.Size = new System.Drawing.Size(65, 13);
            documentoLabel.TabIndex = 6;
            documentoLabel.Text = "Documento:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.ForeColor = System.Drawing.Color.White;
            nombreLabel.Location = new System.Drawing.Point(273, 164);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 8;
            nombreLabel.Text = "Nombre:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.ForeColor = System.Drawing.Color.White;
            usuarioLabel.Location = new System.Drawing.Point(273, 190);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(46, 13);
            usuarioLabel.TabIndex = 10;
            usuarioLabel.Text = "Usuario:";
            // 
            // rolLabel
            // 
            rolLabel.AutoSize = true;
            rolLabel.ForeColor = System.Drawing.Color.White;
            rolLabel.Location = new System.Drawing.Point(273, 216);
            rolLabel.Name = "rolLabel";
            rolLabel.Size = new System.Drawing.Size(26, 13);
            rolLabel.TabIndex = 12;
            rolLabel.Text = "Rol:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.ForeColor = System.Drawing.Color.White;
            passwordLabel.Location = new System.Drawing.Point(273, 243);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 14;
            passwordLabel.Text = "Password:";
            // 
            // EliminarFotoEditUsu
            // 
            EliminarFotoEditUsu.AutoSize = true;
            EliminarFotoEditUsu.Cursor = System.Windows.Forms.Cursors.Hand;
            EliminarFotoEditUsu.ForeColor = System.Drawing.Color.White;
            EliminarFotoEditUsu.Location = new System.Drawing.Point(150, 265);
            EliminarFotoEditUsu.Name = "EliminarFotoEditUsu";
            EliminarFotoEditUsu.Size = new System.Drawing.Size(43, 13);
            EliminarFotoEditUsu.TabIndex = 20;
            EliminarFotoEditUsu.Text = "Eliminar";
            EliminarFotoEditUsu.Click += new System.EventHandler(this.EliminarFotoEditUsu_Click);
            // 
            // idUsuarioLabel
            // 
            idUsuarioLabel.AutoSize = true;
            idUsuarioLabel.Location = new System.Drawing.Point(12, 28);
            idUsuarioLabel.Name = "idUsuarioLabel";
            idUsuarioLabel.Size = new System.Drawing.Size(58, 13);
            idUsuarioLabel.TabIndex = 22;
            idUsuarioLabel.Text = "Id Usuario:";
            // 
            // formEditUsuario
            // 
            this.formEditUsuario.BackColor = System.Drawing.Color.RoyalBlue;
            this.formEditUsuario.Controls.Add(this.buttCerrEditUsuario);
            this.formEditUsuario.Controls.Add(this.labelEditarUsuario);
            this.formEditUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.formEditUsuario.Location = new System.Drawing.Point(0, 0);
            this.formEditUsuario.Name = "formEditUsuario";
            this.formEditUsuario.Size = new System.Drawing.Size(532, 39);
            this.formEditUsuario.TabIndex = 1;
            // 
            // buttCerrEditUsuario
            // 
            this.buttCerrEditUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttCerrEditUsuario.FlatAppearance.BorderSize = 0;
            this.buttCerrEditUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttCerrEditUsuario.Image = ((System.Drawing.Image)(resources.GetObject("buttCerrEditUsuario.Image")));
            this.buttCerrEditUsuario.Location = new System.Drawing.Point(490, 0);
            this.buttCerrEditUsuario.Name = "buttCerrEditUsuario";
            this.buttCerrEditUsuario.Size = new System.Drawing.Size(39, 39);
            this.buttCerrEditUsuario.TabIndex = 3;
            this.buttCerrEditUsuario.UseVisualStyleBackColor = true;
            this.buttCerrEditUsuario.Click += new System.EventHandler(this.buttCerrEditUsuario_Click);
            // 
            // labelEditarUsuario
            // 
            this.labelEditarUsuario.AutoSize = true;
            this.labelEditarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditarUsuario.ForeColor = System.Drawing.Color.White;
            this.labelEditarUsuario.Location = new System.Drawing.Point(12, 9);
            this.labelEditarUsuario.Name = "labelEditarUsuario";
            this.labelEditarUsuario.Size = new System.Drawing.Size(148, 25);
            this.labelEditarUsuario.TabIndex = 2;
            this.labelEditarUsuario.Text = "Editar Usuario";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fotoPictureBoxEditUsu
            // 
            this.fotoPictureBoxEditUsu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fotoPictureBoxEditUsu.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.usuariosBindingSource, "Foto", true));
            this.fotoPictureBoxEditUsu.Location = new System.Drawing.Point(70, 134);
            this.fotoPictureBoxEditUsu.Name = "fotoPictureBoxEditUsu";
            this.fotoPictureBoxEditUsu.Size = new System.Drawing.Size(123, 124);
            this.fotoPictureBoxEditUsu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.fotoPictureBoxEditUsu.TabIndex = 5;
            this.fotoPictureBoxEditUsu.TabStop = false;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.dataSet1;
            // 
            // documentoTextBoxEU
            // 
            this.documentoTextBoxEU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Documento", true));
            this.documentoTextBoxEU.Location = new System.Drawing.Point(344, 135);
            this.documentoTextBoxEU.Name = "documentoTextBoxEU";
            this.documentoTextBoxEU.Size = new System.Drawing.Size(121, 20);
            this.documentoTextBoxEU.TabIndex = 7;
            this.documentoTextBoxEU.TextChanged += new System.EventHandler(this.documentoTextBoxEU_TextChanged);
            this.documentoTextBoxEU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.documentoTextBoxEU_KeyPress);
            // 
            // nombreTextBoxEU
            // 
            this.nombreTextBoxEU.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextBoxEU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Nombre", true));
            this.nombreTextBoxEU.Location = new System.Drawing.Point(344, 161);
            this.nombreTextBoxEU.Name = "nombreTextBoxEU";
            this.nombreTextBoxEU.Size = new System.Drawing.Size(121, 20);
            this.nombreTextBoxEU.TabIndex = 9;
            this.nombreTextBoxEU.TextChanged += new System.EventHandler(this.nombreTextBoxEU_TextChanged);
            this.nombreTextBoxEU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreTextBoxEU_KeyPress);
            // 
            // usuarioTextBoxEU
            // 
            this.usuarioTextBoxEU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Usuario", true));
            this.usuarioTextBoxEU.Location = new System.Drawing.Point(344, 187);
            this.usuarioTextBoxEU.Name = "usuarioTextBoxEU";
            this.usuarioTextBoxEU.Size = new System.Drawing.Size(121, 20);
            this.usuarioTextBoxEU.TabIndex = 11;
            this.usuarioTextBoxEU.TextChanged += new System.EventHandler(this.usuarioTextBoxEU_TextChanged);
            // 
            // rolComboBoxEU
            // 
            this.rolComboBoxEU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Rol", true));
            this.rolComboBoxEU.FormattingEnabled = true;
            this.rolComboBoxEU.Items.AddRange(new object[] {
            "Administrador",
            "Facturador",
            "Digitador"});
            this.rolComboBoxEU.Location = new System.Drawing.Point(344, 213);
            this.rolComboBoxEU.Name = "rolComboBoxEU";
            this.rolComboBoxEU.Size = new System.Drawing.Size(121, 21);
            this.rolComboBoxEU.TabIndex = 13;
            this.rolComboBoxEU.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rolComboBoxEU_KeyPress);
            // 
            // passwordTextBoxEU
            // 
            this.passwordTextBoxEU.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Password", true));
            this.passwordTextBoxEU.Location = new System.Drawing.Point(344, 240);
            this.passwordTextBoxEU.Name = "passwordTextBoxEU";
            this.passwordTextBoxEU.Size = new System.Drawing.Size(121, 20);
            this.passwordTextBoxEU.TabIndex = 15;
            this.passwordTextBoxEU.TextChanged += new System.EventHandler(this.passwordTextBoxEU_TextChanged);
            // 
            // cancelarEditUsua
            // 
            this.cancelarEditUsua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelarEditUsua.FlatAppearance.BorderSize = 0;
            this.cancelarEditUsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelarEditUsua.ForeColor = System.Drawing.Color.White;
            this.cancelarEditUsua.Location = new System.Drawing.Point(278, 335);
            this.cancelarEditUsua.Name = "cancelarEditUsua";
            this.cancelarEditUsua.Size = new System.Drawing.Size(60, 27);
            this.cancelarEditUsua.TabIndex = 22;
            this.cancelarEditUsua.Text = "Cancelar";
            this.cancelarEditUsua.UseVisualStyleBackColor = true;
            this.cancelarEditUsua.Click += new System.EventHandler(this.cancelarEditUsua_Click);
            // 
            // btnguardarcambiosEditUsu
            // 
            this.btnguardarcambiosEditUsu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardarcambiosEditUsu.FlatAppearance.BorderSize = 0;
            this.btnguardarcambiosEditUsu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardarcambiosEditUsu.ForeColor = System.Drawing.Color.White;
            this.btnguardarcambiosEditUsu.Location = new System.Drawing.Point(168, 335);
            this.btnguardarcambiosEditUsu.Name = "btnguardarcambiosEditUsu";
            this.btnguardarcambiosEditUsu.Size = new System.Drawing.Size(60, 27);
            this.btnguardarcambiosEditUsu.TabIndex = 21;
            this.btnguardarcambiosEditUsu.Text = "Guardar";
            this.btnguardarcambiosEditUsu.UseVisualStyleBackColor = true;
            this.btnguardarcambiosEditUsu.Click += new System.EventHandler(this.btnguardarcambiosEditUsu_Click);
            // 
            // openFileImgEdit
            // 
            this.openFileImgEdit.FileName = "openFileDialog1";
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
            // idUsuarioTextBox
            // 
            this.idUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "IdUsuario", true));
            this.idUsuarioTextBox.Location = new System.Drawing.Point(76, 25);
            this.idUsuarioTextBox.Name = "idUsuarioTextBox";
            this.idUsuarioTextBox.Size = new System.Drawing.Size(121, 20);
            this.idUsuarioTextBox.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(idUsuarioLabel);
            this.panel1.Controls.Add(this.idUsuarioTextBox);
            this.panel1.Location = new System.Drawing.Point(278, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(17, 11);
            this.panel1.TabIndex = 24;
            // 
            // EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(532, 386);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancelarEditUsua);
            this.Controls.Add(this.btnguardarcambiosEditUsu);
            this.Controls.Add(EliminarFotoEditUsu);
            this.Controls.Add(fotoLabelEditUsu);
            this.Controls.Add(this.fotoPictureBoxEditUsu);
            this.Controls.Add(documentoLabel);
            this.Controls.Add(this.documentoTextBoxEU);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBoxEU);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(this.usuarioTextBoxEU);
            this.Controls.Add(rolLabel);
            this.Controls.Add(this.rolComboBoxEU);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBoxEU);
            this.Controls.Add(this.formEditUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarUsuario";
            this.Load += new System.EventHandler(this.EditarUsuario_Load);
            this.formEditUsuario.ResumeLayout(false);
            this.formEditUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBoxEditUsu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formEditUsuario;
        private System.Windows.Forms.Button buttCerrEditUsuario;
        private System.Windows.Forms.Label labelEditarUsuario;
        private DataSet1 dataSet1;
        private System.Windows.Forms.PictureBox fotoPictureBoxEditUsu;
        private System.Windows.Forms.TextBox documentoTextBoxEU;
        private System.Windows.Forms.TextBox nombreTextBoxEU;
        private System.Windows.Forms.TextBox usuarioTextBoxEU;
        private System.Windows.Forms.ComboBox rolComboBoxEU;
        private System.Windows.Forms.TextBox passwordTextBoxEU;
        private System.Windows.Forms.Button cancelarEditUsua;
        private System.Windows.Forms.Button btnguardarcambiosEditUsu;
        private System.Windows.Forms.OpenFileDialog openFileImgEdit;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private DataSet1TableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idUsuarioTextBox;
        private System.Windows.Forms.Panel panel1;
    }
}