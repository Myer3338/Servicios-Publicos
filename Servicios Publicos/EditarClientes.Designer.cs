
namespace Servicios_Publicos
{
    partial class EditarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarClientes));
            System.Windows.Forms.Label idClienteLabel;
            this.formEditCliente = new System.Windows.Forms.Panel();
            this.buttCerrEditCliente = new System.Windows.Forms.Button();
            this.formEditarCliente = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.consumoTextBox = new System.Windows.Forms.TextBox();
            this.pagoTotalTextBox = new System.Windows.Forms.TextBox();
            this.codigoQrPictureBox = new System.Windows.Forms.PictureBox();
            this.codigoBarraPictureBox = new System.Windows.Forms.PictureBox();
            this.noFacturaTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelarClienteEditar = new System.Windows.Forms.Button();
            this.btnGuardarClienteEditar = new System.Windows.Forms.Button();
            this.documentoTextBox = new System.Windows.Forms.TextBox();
            this.codPredioTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.comboBoxEditarCliente = new System.Windows.Forms.ComboBox();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Servicios_Publicos.DataSet1();
            this.clientesTableAdapter = new Servicios_Publicos.DataSet1TableAdapters.ClientesTableAdapter();
            this.tableAdapterManager = new Servicios_Publicos.DataSet1TableAdapters.TableAdapterManager();
            this.idClienteTextBox = new System.Windows.Forms.TextBox();
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
            idClienteLabel = new System.Windows.Forms.Label();
            this.formEditCliente.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoQrPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoBarraPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // documentoLabel
            // 
            documentoLabel.AutoSize = true;
            documentoLabel.ForeColor = System.Drawing.Color.White;
            documentoLabel.Location = new System.Drawing.Point(280, 132);
            documentoLabel.Name = "documentoLabel";
            documentoLabel.Size = new System.Drawing.Size(65, 13);
            documentoLabel.TabIndex = 24;
            documentoLabel.Text = "Documento:";
            // 
            // codPredioLabel
            // 
            codPredioLabel.AutoSize = true;
            codPredioLabel.ForeColor = System.Drawing.Color.White;
            codPredioLabel.Location = new System.Drawing.Point(280, 158);
            codPredioLabel.Name = "codPredioLabel";
            codPredioLabel.Size = new System.Drawing.Size(62, 13);
            codPredioLabel.TabIndex = 26;
            codPredioLabel.Text = "Cod Predio:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.ForeColor = System.Drawing.Color.White;
            nombreLabel.Location = new System.Drawing.Point(280, 184);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 28;
            nombreLabel.Text = "Nombre:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.ForeColor = System.Drawing.Color.White;
            direccionLabel.Location = new System.Drawing.Point(280, 210);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 30;
            direccionLabel.Text = "Direccion:";
            // 
            // estratoLabel
            // 
            estratoLabel.AutoSize = true;
            estratoLabel.ForeColor = System.Drawing.Color.White;
            estratoLabel.Location = new System.Drawing.Point(280, 236);
            estratoLabel.Name = "estratoLabel";
            estratoLabel.Size = new System.Drawing.Size(43, 13);
            estratoLabel.TabIndex = 32;
            estratoLabel.Text = "Estrato:";
            // 
            // consumoLabel
            // 
            consumoLabel.AutoSize = true;
            consumoLabel.ForeColor = System.Drawing.Color.White;
            consumoLabel.Location = new System.Drawing.Point(23, 32);
            consumoLabel.Name = "consumoLabel";
            consumoLabel.Size = new System.Drawing.Size(54, 13);
            consumoLabel.TabIndex = 34;
            consumoLabel.Text = "Consumo:";
            // 
            // pagoTotalLabel
            // 
            pagoTotalLabel.AutoSize = true;
            pagoTotalLabel.ForeColor = System.Drawing.Color.White;
            pagoTotalLabel.Location = new System.Drawing.Point(15, 58);
            pagoTotalLabel.Name = "pagoTotalLabel";
            pagoTotalLabel.Size = new System.Drawing.Size(62, 13);
            pagoTotalLabel.TabIndex = 36;
            pagoTotalLabel.Text = "Pago Total:";
            // 
            // codigoQrLabel
            // 
            codigoQrLabel.AutoSize = true;
            codigoQrLabel.ForeColor = System.Drawing.Color.White;
            codigoQrLabel.Location = new System.Drawing.Point(197, 6);
            codigoQrLabel.Name = "codigoQrLabel";
            codigoQrLabel.Size = new System.Drawing.Size(57, 13);
            codigoQrLabel.TabIndex = 38;
            codigoQrLabel.Text = "Codigo Qr:";
            // 
            // codigoBarraLabel
            // 
            codigoBarraLabel.AutoSize = true;
            codigoBarraLabel.ForeColor = System.Drawing.Color.White;
            codigoBarraLabel.Location = new System.Drawing.Point(197, 35);
            codigoBarraLabel.Name = "codigoBarraLabel";
            codigoBarraLabel.Size = new System.Drawing.Size(71, 13);
            codigoBarraLabel.TabIndex = 40;
            codigoBarraLabel.Text = "Codigo Barra:";
            // 
            // noFacturaLabel
            // 
            noFacturaLabel.AutoSize = true;
            noFacturaLabel.ForeColor = System.Drawing.Color.White;
            noFacturaLabel.Location = new System.Drawing.Point(197, 61);
            noFacturaLabel.Name = "noFacturaLabel";
            noFacturaLabel.Size = new System.Drawing.Size(63, 13);
            noFacturaLabel.TabIndex = 42;
            noFacturaLabel.Text = "No Factura:";
            // 
            // formEditCliente
            // 
            this.formEditCliente.BackColor = System.Drawing.Color.RoyalBlue;
            this.formEditCliente.Controls.Add(this.buttCerrEditCliente);
            this.formEditCliente.Controls.Add(this.formEditarCliente);
            this.formEditCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.formEditCliente.Location = new System.Drawing.Point(0, 0);
            this.formEditCliente.Name = "formEditCliente";
            this.formEditCliente.Size = new System.Drawing.Size(532, 39);
            this.formEditCliente.TabIndex = 1;
            // 
            // buttCerrEditCliente
            // 
            this.buttCerrEditCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttCerrEditCliente.FlatAppearance.BorderSize = 0;
            this.buttCerrEditCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttCerrEditCliente.Image = ((System.Drawing.Image)(resources.GetObject("buttCerrEditCliente.Image")));
            this.buttCerrEditCliente.Location = new System.Drawing.Point(490, 0);
            this.buttCerrEditCliente.Name = "buttCerrEditCliente";
            this.buttCerrEditCliente.Size = new System.Drawing.Size(39, 39);
            this.buttCerrEditCliente.TabIndex = 3;
            this.buttCerrEditCliente.UseVisualStyleBackColor = true;
            this.buttCerrEditCliente.Click += new System.EventHandler(this.buttCerrEditCliente_Click);
            // 
            // formEditarCliente
            // 
            this.formEditarCliente.AutoSize = true;
            this.formEditarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formEditarCliente.ForeColor = System.Drawing.Color.White;
            this.formEditarCliente.Location = new System.Drawing.Point(12, 9);
            this.formEditarCliente.Name = "formEditarCliente";
            this.formEditarCliente.Size = new System.Drawing.Size(142, 25);
            this.formEditarCliente.TabIndex = 2;
            this.formEditarCliente.Text = "Editar Cliente";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(idClienteLabel);
            this.panel1.Controls.Add(this.idClienteTextBox);
            this.panel1.Controls.Add(this.consumoTextBox);
            this.panel1.Controls.Add(this.pagoTotalTextBox);
            this.panel1.Controls.Add(pagoTotalLabel);
            this.panel1.Controls.Add(consumoLabel);
            this.panel1.Controls.Add(this.codigoQrPictureBox);
            this.panel1.Controls.Add(codigoQrLabel);
            this.panel1.Controls.Add(this.codigoBarraPictureBox);
            this.panel1.Controls.Add(codigoBarraLabel);
            this.panel1.Controls.Add(noFacturaLabel);
            this.panel1.Controls.Add(this.noFacturaTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(12, 10);
            this.panel1.TabIndex = 16;
            // 
            // consumoTextBox
            // 
            this.consumoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Consumo", true));
            this.consumoTextBox.Location = new System.Drawing.Point(83, 29);
            this.consumoTextBox.Name = "consumoTextBox";
            this.consumoTextBox.Size = new System.Drawing.Size(100, 20);
            this.consumoTextBox.TabIndex = 35;
            // 
            // pagoTotalTextBox
            // 
            this.pagoTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "PagoTotal", true));
            this.pagoTotalTextBox.Location = new System.Drawing.Point(83, 55);
            this.pagoTotalTextBox.Name = "pagoTotalTextBox";
            this.pagoTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.pagoTotalTextBox.TabIndex = 37;
            // 
            // codigoQrPictureBox
            // 
            this.codigoQrPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.clientesBindingSource, "CodigoQr", true));
            this.codigoQrPictureBox.Location = new System.Drawing.Point(274, 6);
            this.codigoQrPictureBox.Name = "codigoQrPictureBox";
            this.codigoQrPictureBox.Size = new System.Drawing.Size(100, 20);
            this.codigoQrPictureBox.TabIndex = 39;
            this.codigoQrPictureBox.TabStop = false;
            // 
            // codigoBarraPictureBox
            // 
            this.codigoBarraPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.clientesBindingSource, "CodigoBarra", true));
            this.codigoBarraPictureBox.Location = new System.Drawing.Point(274, 35);
            this.codigoBarraPictureBox.Name = "codigoBarraPictureBox";
            this.codigoBarraPictureBox.Size = new System.Drawing.Size(100, 17);
            this.codigoBarraPictureBox.TabIndex = 41;
            this.codigoBarraPictureBox.TabStop = false;
            // 
            // noFacturaTextBox
            // 
            this.noFacturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "NoFactura", true));
            this.noFacturaTextBox.Location = new System.Drawing.Point(274, 58);
            this.noFacturaTextBox.Name = "noFacturaTextBox";
            this.noFacturaTextBox.Size = new System.Drawing.Size(100, 20);
            this.noFacturaTextBox.TabIndex = 43;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 176);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelarClienteEditar
            // 
            this.btnCancelarClienteEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarClienteEditar.FlatAppearance.BorderSize = 0;
            this.btnCancelarClienteEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarClienteEditar.ForeColor = System.Drawing.Color.White;
            this.btnCancelarClienteEditar.Location = new System.Drawing.Point(300, 337);
            this.btnCancelarClienteEditar.Name = "btnCancelarClienteEditar";
            this.btnCancelarClienteEditar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarClienteEditar.TabIndex = 21;
            this.btnCancelarClienteEditar.Text = "Cancelar";
            this.btnCancelarClienteEditar.UseVisualStyleBackColor = true;
            this.btnCancelarClienteEditar.Click += new System.EventHandler(this.btnCancelarClienteEditar_Click);
            // 
            // btnGuardarClienteEditar
            // 
            this.btnGuardarClienteEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarClienteEditar.FlatAppearance.BorderSize = 0;
            this.btnGuardarClienteEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarClienteEditar.ForeColor = System.Drawing.Color.White;
            this.btnGuardarClienteEditar.Location = new System.Drawing.Point(158, 337);
            this.btnGuardarClienteEditar.Name = "btnGuardarClienteEditar";
            this.btnGuardarClienteEditar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarClienteEditar.TabIndex = 20;
            this.btnGuardarClienteEditar.Text = "Agregar";
            this.btnGuardarClienteEditar.UseVisualStyleBackColor = true;
            this.btnGuardarClienteEditar.Click += new System.EventHandler(this.btnGuardarClienteEditar_Click);
            // 
            // documentoTextBox
            // 
            this.documentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Documento", true));
            this.documentoTextBox.Location = new System.Drawing.Point(357, 129);
            this.documentoTextBox.Name = "documentoTextBox";
            this.documentoTextBox.Size = new System.Drawing.Size(100, 20);
            this.documentoTextBox.TabIndex = 25;
            this.documentoTextBox.TextChanged += new System.EventHandler(this.documentoTextBox_TextChanged);
            this.documentoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.documentoTextBox_KeyPress);
            // 
            // codPredioTextBox
            // 
            this.codPredioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "CodPredio", true));
            this.codPredioTextBox.Location = new System.Drawing.Point(357, 155);
            this.codPredioTextBox.Name = "codPredioTextBox";
            this.codPredioTextBox.Size = new System.Drawing.Size(100, 20);
            this.codPredioTextBox.TabIndex = 27;
            this.codPredioTextBox.TextChanged += new System.EventHandler(this.codPredioTextBox_TextChanged);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(357, 181);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 29;
            this.nombreTextBox.TextChanged += new System.EventHandler(this.nombreTextBox_TextChanged);
            this.nombreTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombreTextBox_KeyPress);
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(357, 207);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(100, 20);
            this.direccionTextBox.TabIndex = 31;
            this.direccionTextBox.TextChanged += new System.EventHandler(this.direccionTextBox_TextChanged);
            // 
            // comboBoxEditarCliente
            // 
            this.comboBoxEditarCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Estrato", true));
            this.comboBoxEditarCliente.FormattingEnabled = true;
            this.comboBoxEditarCliente.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxEditarCliente.Location = new System.Drawing.Point(357, 233);
            this.comboBoxEditarCliente.Name = "comboBoxEditarCliente";
            this.comboBoxEditarCliente.Size = new System.Drawing.Size(100, 21);
            this.comboBoxEditarCliente.TabIndex = 33;
            this.comboBoxEditarCliente.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditarCliente_SelectedIndexChanged);
            this.comboBoxEditarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxEditarCliente_KeyPress);
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
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Servicios_Publicos.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuariosTableAdapter = null;
            // 
            // idClienteLabel
            // 
            idClienteLabel.AutoSize = true;
            idClienteLabel.ForeColor = System.Drawing.Color.White;
            idClienteLabel.Location = new System.Drawing.Point(23, 9);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(54, 13);
            idClienteLabel.TabIndex = 43;
            idClienteLabel.Text = "Id Cliente:";
            // 
            // idClienteTextBox
            // 
            this.idClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "IdCliente", true));
            this.idClienteTextBox.Location = new System.Drawing.Point(83, 6);
            this.idClienteTextBox.Name = "idClienteTextBox";
            this.idClienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.idClienteTextBox.TabIndex = 44;
            // 
            // EditarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(532, 386);
            this.Controls.Add(this.comboBoxEditarCliente);
            this.Controls.Add(documentoLabel);
            this.Controls.Add(this.documentoTextBox);
            this.Controls.Add(codPredioLabel);
            this.Controls.Add(this.codPredioTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(estratoLabel);
            this.Controls.Add(this.btnCancelarClienteEditar);
            this.Controls.Add(this.btnGuardarClienteEditar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.formEditCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditarClientes";
            this.Load += new System.EventHandler(this.EditarClientes_Load);
            this.formEditCliente.ResumeLayout(false);
            this.formEditCliente.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codigoQrPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoBarraPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel formEditCliente;
        private System.Windows.Forms.Button buttCerrEditCliente;
        private System.Windows.Forms.Label formEditarCliente;
        private DataSet1 dataSet1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCancelarClienteEditar;
        private System.Windows.Forms.Button btnGuardarClienteEditar;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DataSet1TableAdapters.ClientesTableAdapter clientesTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox consumoTextBox;
        private System.Windows.Forms.TextBox pagoTotalTextBox;
        private System.Windows.Forms.PictureBox codigoQrPictureBox;
        private System.Windows.Forms.PictureBox codigoBarraPictureBox;
        private System.Windows.Forms.TextBox noFacturaTextBox;
        private System.Windows.Forms.TextBox documentoTextBox;
        private System.Windows.Forms.TextBox codPredioTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.ComboBox comboBoxEditarCliente;
        private System.Windows.Forms.TextBox idClienteTextBox;
    }
}