
namespace Servicios_Publicos
{
    partial class AgregarClientes
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
            System.Windows.Forms.Label idClienteLabel;
            System.Windows.Forms.Label documentoLabel;
            System.Windows.Forms.Label codPredioLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label estratoLabel;
            System.Windows.Forms.Label consumoLabel;
            System.Windows.Forms.Label pagoTotalLabel;
            System.Windows.Forms.Label codigoQrLabel;
            System.Windows.Forms.Label codigoBarraLabel;
            System.Windows.Forms.Label noFacturaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarClientes));
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Servicios_Publicos.DataSet1();
            this.pictureAgregarCliente = new System.Windows.Forms.PictureBox();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnCancelarAgregCliente = new System.Windows.Forms.Button();
            this.encabezadoAgregarCliente = new System.Windows.Forms.Panel();
            this.cerrarAgregarCliente = new System.Windows.Forms.Button();
            this.labelAgregarCliente = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idClienteTextBox = new System.Windows.Forms.TextBox();
            this.codigoQrPictureBoxCliente = new System.Windows.Forms.PictureBox();
            this.pagoTotalTextBoxCliente = new System.Windows.Forms.TextBox();
            this.consumoTextBoxCliente = new System.Windows.Forms.TextBox();
            this.codigoBarraPictureBoxCliente = new System.Windows.Forms.PictureBox();
            this.noFacturaTextBoxCliente = new System.Windows.Forms.TextBox();
            this.tableAdapterManager1 = new Servicios_Publicos.DataSet1TableAdapters.TableAdapterManager();
            this.clientesTableAdapter = new Servicios_Publicos.DataSet1TableAdapters.ClientesTableAdapter();
            this.documentoTextBoxClientes = new System.Windows.Forms.TextBox();
            this.codPredioTextBoxClientes = new System.Windows.Forms.TextBox();
            this.nombreTextBoxClientes = new System.Windows.Forms.TextBox();
            this.direccionTextBoxClientes = new System.Windows.Forms.TextBox();
            this.comboBoxAgregarCliente = new System.Windows.Forms.ComboBox();
            idClienteLabel = new System.Windows.Forms.Label();
            documentoLabel = new System.Windows.Forms.Label();
            codPredioLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            estratoLabel = new System.Windows.Forms.Label();
            consumoLabel = new System.Windows.Forms.Label();
            pagoTotalLabel = new System.Windows.Forms.Label();
            codigoQrLabel = new System.Windows.Forms.Label();
            codigoBarraLabel = new System.Windows.Forms.Label();
            noFacturaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAgregarCliente)).BeginInit();
            this.encabezadoAgregarCliente.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoQrPictureBoxCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoBarraPictureBoxCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.ForeColor = System.Drawing.Color.White;
            idClienteLabel.Location = new System.Drawing.Point(11, 6);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(54, 13);
            idClienteLabel.TabIndex = 21;
            idClienteLabel.Text = "Id Cliente:";
            // 
            // documentoLabel
            // 
            documentoLabel.AutoSize = true;
            documentoLabel.ForeColor = System.Drawing.Color.White;
            documentoLabel.Location = new System.Drawing.Point(277, 140);
            documentoLabel.Name = "documentoLabel";
            documentoLabel.Size = new System.Drawing.Size(65, 13);
            documentoLabel.TabIndex = 23;
            documentoLabel.Text = "Documento:";
            // 
            // codPredioLabel
            // 
            codPredioLabel.AutoSize = true;
            codPredioLabel.ForeColor = System.Drawing.Color.White;
            codPredioLabel.Location = new System.Drawing.Point(277, 166);
            codPredioLabel.Name = "codPredioLabel";
            codPredioLabel.Size = new System.Drawing.Size(62, 13);
            codPredioLabel.TabIndex = 25;
            codPredioLabel.Text = "Cod Predio:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.ForeColor = System.Drawing.Color.White;
            nombreLabel.Location = new System.Drawing.Point(277, 192);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 27;
            nombreLabel.Text = "Nombre:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.ForeColor = System.Drawing.Color.White;
            direccionLabel.Location = new System.Drawing.Point(277, 218);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 29;
            direccionLabel.Text = "Direccion:";
            // 
            // estratoLabel
            // 
            estratoLabel.AutoSize = true;
            estratoLabel.ForeColor = System.Drawing.Color.White;
            estratoLabel.Location = new System.Drawing.Point(277, 244);
            estratoLabel.Name = "estratoLabel";
            estratoLabel.Size = new System.Drawing.Size(43, 13);
            estratoLabel.TabIndex = 31;
            estratoLabel.Text = "Estrato:";
            // 
            // consumoLabel
            // 
            consumoLabel.AutoSize = true;
            consumoLabel.ForeColor = System.Drawing.Color.White;
            consumoLabel.Location = new System.Drawing.Point(11, 30);
            consumoLabel.Name = "consumoLabel";
            consumoLabel.Size = new System.Drawing.Size(54, 13);
            consumoLabel.TabIndex = 33;
            consumoLabel.Text = "Consumo:";
            // 
            // pagoTotalLabel
            // 
            pagoTotalLabel.AutoSize = true;
            pagoTotalLabel.ForeColor = System.Drawing.Color.White;
            pagoTotalLabel.Location = new System.Drawing.Point(203, 72);
            pagoTotalLabel.Name = "pagoTotalLabel";
            pagoTotalLabel.Size = new System.Drawing.Size(62, 13);
            pagoTotalLabel.TabIndex = 35;
            pagoTotalLabel.Text = "Pago Total:";
            // 
            // codigoQrLabel
            // 
            codigoQrLabel.AutoSize = true;
            codigoQrLabel.ForeColor = System.Drawing.Color.White;
            codigoQrLabel.Location = new System.Drawing.Point(11, 53);
            codigoQrLabel.Name = "codigoQrLabel";
            codigoQrLabel.Size = new System.Drawing.Size(57, 13);
            codigoQrLabel.TabIndex = 37;
            codigoQrLabel.Text = "Codigo Qr:";
            // 
            // codigoBarraLabel
            // 
            codigoBarraLabel.AutoSize = true;
            codigoBarraLabel.ForeColor = System.Drawing.Color.White;
            codigoBarraLabel.Location = new System.Drawing.Point(203, 9);
            codigoBarraLabel.Name = "codigoBarraLabel";
            codigoBarraLabel.Size = new System.Drawing.Size(71, 13);
            codigoBarraLabel.TabIndex = 39;
            codigoBarraLabel.Text = "Codigo Barra:";
            // 
            // noFacturaLabel
            // 
            noFacturaLabel.AutoSize = true;
            noFacturaLabel.ForeColor = System.Drawing.Color.White;
            noFacturaLabel.Location = new System.Drawing.Point(203, 44);
            noFacturaLabel.Name = "noFacturaLabel";
            noFacturaLabel.Size = new System.Drawing.Size(63, 13);
            noFacturaLabel.TabIndex = 41;
            noFacturaLabel.Text = "No Factura:";
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureAgregarCliente
            // 
            this.pictureAgregarCliente.Image = ((System.Drawing.Image)(resources.GetObject("pictureAgregarCliente.Image")));
            this.pictureAgregarCliente.Location = new System.Drawing.Point(56, 109);
            this.pictureAgregarCliente.Name = "pictureAgregarCliente";
            this.pictureAgregarCliente.Size = new System.Drawing.Size(168, 176);
            this.pictureAgregarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAgregarCliente.TabIndex = 14;
            this.pictureAgregarCliente.TabStop = false;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCliente.FlatAppearance.BorderSize = 0;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.ForeColor = System.Drawing.Color.White;
            this.btnAgregarCliente.Location = new System.Drawing.Point(169, 331);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCliente.TabIndex = 15;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // btnCancelarAgregCliente
            // 
            this.btnCancelarAgregCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarAgregCliente.FlatAppearance.BorderSize = 0;
            this.btnCancelarAgregCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarAgregCliente.ForeColor = System.Drawing.Color.White;
            this.btnCancelarAgregCliente.Location = new System.Drawing.Point(277, 331);
            this.btnCancelarAgregCliente.Name = "btnCancelarAgregCliente";
            this.btnCancelarAgregCliente.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarAgregCliente.TabIndex = 16;
            this.btnCancelarAgregCliente.Text = "Cancelar";
            this.btnCancelarAgregCliente.UseVisualStyleBackColor = true;
            this.btnCancelarAgregCliente.Click += new System.EventHandler(this.btnCancelarAgregCliente_Click);
            // 
            // encabezadoAgregarCliente
            // 
            this.encabezadoAgregarCliente.BackColor = System.Drawing.Color.RoyalBlue;
            this.encabezadoAgregarCliente.Controls.Add(this.cerrarAgregarCliente);
            this.encabezadoAgregarCliente.Controls.Add(this.labelAgregarCliente);
            this.encabezadoAgregarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.encabezadoAgregarCliente.Location = new System.Drawing.Point(0, 0);
            this.encabezadoAgregarCliente.Name = "encabezadoAgregarCliente";
            this.encabezadoAgregarCliente.Size = new System.Drawing.Size(532, 39);
            this.encabezadoAgregarCliente.TabIndex = 17;
            // 
            // cerrarAgregarCliente
            // 
            this.cerrarAgregarCliente.FlatAppearance.BorderSize = 0;
            this.cerrarAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cerrarAgregarCliente.Image = ((System.Drawing.Image)(resources.GetObject("cerrarAgregarCliente.Image")));
            this.cerrarAgregarCliente.Location = new System.Drawing.Point(489, 0);
            this.cerrarAgregarCliente.Name = "cerrarAgregarCliente";
            this.cerrarAgregarCliente.Size = new System.Drawing.Size(40, 39);
            this.cerrarAgregarCliente.TabIndex = 1;
            this.cerrarAgregarCliente.UseVisualStyleBackColor = true;
            this.cerrarAgregarCliente.Click += new System.EventHandler(this.cerrarAgregarCliente_Click);
            // 
            // labelAgregarCliente
            // 
            this.labelAgregarCliente.AutoSize = true;
            this.labelAgregarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgregarCliente.ForeColor = System.Drawing.Color.White;
            this.labelAgregarCliente.Location = new System.Drawing.Point(12, 9);
            this.labelAgregarCliente.Name = "labelAgregarCliente";
            this.labelAgregarCliente.Size = new System.Drawing.Size(163, 25);
            this.labelAgregarCliente.TabIndex = 0;
            this.labelAgregarCliente.Text = "Agregar Cliente";
            this.labelAgregarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(idClienteLabel);
            this.panel1.Controls.Add(this.idClienteTextBox);
            this.panel1.Controls.Add(consumoLabel);
            this.panel1.Controls.Add(this.codigoQrPictureBoxCliente);
            this.panel1.Controls.Add(codigoQrLabel);
            this.panel1.Controls.Add(this.pagoTotalTextBoxCliente);
            this.panel1.Controls.Add(pagoTotalLabel);
            this.panel1.Controls.Add(this.consumoTextBoxCliente);
            this.panel1.Controls.Add(this.codigoBarraPictureBoxCliente);
            this.panel1.Controls.Add(this.noFacturaTextBoxCliente);
            this.panel1.Controls.Add(codigoBarraLabel);
            this.panel1.Controls.Add(noFacturaLabel);
            this.panel1.Location = new System.Drawing.Point(12, 291);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 10);
            this.panel1.TabIndex = 21;
            // 
            // idClienteTextBox
            // 
            this.idClienteTextBox.Location = new System.Drawing.Point(88, 3);
            this.idClienteTextBox.Name = "idClienteTextBox";
            this.idClienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.idClienteTextBox.TabIndex = 22;
            // 
            // codigoQrPictureBoxCliente
            // 
            this.codigoQrPictureBoxCliente.Location = new System.Drawing.Point(88, 53);
            this.codigoQrPictureBoxCliente.Name = "codigoQrPictureBoxCliente";
            this.codigoQrPictureBoxCliente.Size = new System.Drawing.Size(100, 25);
            this.codigoQrPictureBoxCliente.TabIndex = 38;
            this.codigoQrPictureBoxCliente.TabStop = false;
            // 
            // pagoTotalTextBoxCliente
            // 
            this.pagoTotalTextBoxCliente.Location = new System.Drawing.Point(280, 69);
            this.pagoTotalTextBoxCliente.Name = "pagoTotalTextBoxCliente";
            this.pagoTotalTextBoxCliente.Size = new System.Drawing.Size(100, 20);
            this.pagoTotalTextBoxCliente.TabIndex = 36;
            this.pagoTotalTextBoxCliente.Text = "0";
            // 
            // consumoTextBoxCliente
            // 
            this.consumoTextBoxCliente.Location = new System.Drawing.Point(88, 27);
            this.consumoTextBoxCliente.Name = "consumoTextBoxCliente";
            this.consumoTextBoxCliente.Size = new System.Drawing.Size(100, 20);
            this.consumoTextBoxCliente.TabIndex = 34;
            // 
            // codigoBarraPictureBoxCliente
            // 
            this.codigoBarraPictureBoxCliente.Location = new System.Drawing.Point(280, 9);
            this.codigoBarraPictureBoxCliente.Name = "codigoBarraPictureBoxCliente";
            this.codigoBarraPictureBoxCliente.Size = new System.Drawing.Size(100, 25);
            this.codigoBarraPictureBoxCliente.TabIndex = 40;
            this.codigoBarraPictureBoxCliente.TabStop = false;
            // 
            // noFacturaTextBoxCliente
            // 
            this.noFacturaTextBoxCliente.Location = new System.Drawing.Point(280, 41);
            this.noFacturaTextBoxCliente.Name = "noFacturaTextBoxCliente";
            this.noFacturaTextBoxCliente.Size = new System.Drawing.Size(100, 20);
            this.noFacturaTextBoxCliente.TabIndex = 42;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.ClientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager1.UpdateOrder = Servicios_Publicos.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UsuariosTableAdapter = null;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // documentoTextBoxClientes
            // 
            this.documentoTextBoxClientes.Location = new System.Drawing.Point(354, 137);
            this.documentoTextBoxClientes.Name = "documentoTextBoxClientes";
            this.documentoTextBoxClientes.Size = new System.Drawing.Size(100, 20);
            this.documentoTextBoxClientes.TabIndex = 24;
            this.documentoTextBoxClientes.TextChanged += new System.EventHandler(this.documentoTextBoxClientes_TextChanged);
            this.documentoTextBoxClientes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.documentoTextBoxClientes_KeyPress);
            // 
            // codPredioTextBoxClientes
            // 
            this.codPredioTextBoxClientes.Location = new System.Drawing.Point(354, 163);
            this.codPredioTextBoxClientes.Name = "codPredioTextBoxClientes";
            this.codPredioTextBoxClientes.Size = new System.Drawing.Size(100, 20);
            this.codPredioTextBoxClientes.TabIndex = 26;
            this.codPredioTextBoxClientes.TextChanged += new System.EventHandler(this.codPredioTextBoxClientes_TextChanged);
            // 
            // nombreTextBoxClientes
            // 
            this.nombreTextBoxClientes.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextBoxClientes.Location = new System.Drawing.Point(354, 189);
            this.nombreTextBoxClientes.Name = "nombreTextBoxClientes";
            this.nombreTextBoxClientes.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBoxClientes.TabIndex = 28;
            this.nombreTextBoxClientes.TextChanged += new System.EventHandler(this.nombreTextBoxClientes_TextChanged);
            this.nombreTextBoxClientes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreTextBoxClientes_KeyPress);
            // 
            // direccionTextBoxClientes
            // 
            this.direccionTextBoxClientes.Location = new System.Drawing.Point(354, 215);
            this.direccionTextBoxClientes.Name = "direccionTextBoxClientes";
            this.direccionTextBoxClientes.Size = new System.Drawing.Size(100, 20);
            this.direccionTextBoxClientes.TabIndex = 30;
            this.direccionTextBoxClientes.TextChanged += new System.EventHandler(this.direccionTextBoxClientes_TextChanged);
            // 
            // comboBoxAgregarCliente
            // 
            this.comboBoxAgregarCliente.FormattingEnabled = true;
            this.comboBoxAgregarCliente.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxAgregarCliente.Location = new System.Drawing.Point(354, 241);
            this.comboBoxAgregarCliente.Name = "comboBoxAgregarCliente";
            this.comboBoxAgregarCliente.Size = new System.Drawing.Size(100, 21);
            this.comboBoxAgregarCliente.TabIndex = 32;
            this.comboBoxAgregarCliente.TextChanged += new System.EventHandler(this.comboBoxAgregarCliente_TextChanged);
            this.comboBoxAgregarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxAgregarCliente_KeyPress);
            // 
            // AgregarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(532, 386);
            this.Controls.Add(this.comboBoxAgregarCliente);
            this.Controls.Add(documentoLabel);
            this.Controls.Add(this.documentoTextBoxClientes);
            this.Controls.Add(codPredioLabel);
            this.Controls.Add(this.codPredioTextBoxClientes);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBoxClientes);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBoxClientes);
            this.Controls.Add(estratoLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.encabezadoAgregarCliente);
            this.Controls.Add(this.btnCancelarAgregCliente);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.pictureAgregarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AgregarClientes";
            this.Load += new System.EventHandler(this.AgregarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAgregarCliente)).EndInit();
            this.encabezadoAgregarCliente.ResumeLayout(false);
            this.encabezadoAgregarCliente.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoQrPictureBoxCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoBarraPictureBoxCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private System.Windows.Forms.PictureBox pictureAgregarCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnCancelarAgregCliente;
        private System.Windows.Forms.Panel encabezadoAgregarCliente;
        private System.Windows.Forms.Label labelAgregarCliente;
        private System.Windows.Forms.Button cerrarAgregarCliente;
        private System.Windows.Forms.Panel panel1;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private DataSet1TableAdapters.ClientesTableAdapter clientesTableAdapter;
        private System.Windows.Forms.TextBox idClienteTextBox;
        private System.Windows.Forms.PictureBox codigoQrPictureBoxCliente;
        private System.Windows.Forms.TextBox pagoTotalTextBoxCliente;
        private System.Windows.Forms.TextBox consumoTextBoxCliente;
        private System.Windows.Forms.PictureBox codigoBarraPictureBoxCliente;
        private System.Windows.Forms.TextBox noFacturaTextBoxCliente;
        private System.Windows.Forms.TextBox documentoTextBoxClientes;
        private System.Windows.Forms.TextBox codPredioTextBoxClientes;
        private System.Windows.Forms.TextBox nombreTextBoxClientes;
        private System.Windows.Forms.TextBox direccionTextBoxClientes;
        private System.Windows.Forms.ComboBox comboBoxAgregarCliente;
    }
}