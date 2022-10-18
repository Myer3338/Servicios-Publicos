
namespace Servicios_Publicos
{
    partial class ProcesarFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcesarFactura));
            this.panelAgUsuario = new System.Windows.Forms.Panel();
            this.formAgregarUsuario = new System.Windows.Forms.Label();
            this.dataSet1 = new Servicios_Publicos.DataSet1();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new Servicios_Publicos.DataSet1TableAdapters.ClientesTableAdapter();
            this.tableAdapterManager = new Servicios_Publicos.DataSet1TableAdapters.TableAdapterManager();
            this.idClienteTextBox = new System.Windows.Forms.TextBox();
            this.documentoTextBox = new System.Windows.Forms.TextBox();
            this.codPredioTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.estratoTextBox = new System.Windows.Forms.TextBox();
            this.consumoTextBox = new System.Windows.Forms.TextBox();
            this.pagoTotalTextBox = new System.Windows.Forms.TextBox();
            this.codigoQrPictureBox = new System.Windows.Forms.PictureBox();
            this.codigoBarraPictureBox = new System.Windows.Forms.PictureBox();
            this.noFacturaTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clientesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnCancelarClienteEditar = new System.Windows.Forms.Button();
            this.btnGuardarClienteEditar = new System.Windows.Forms.Button();
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
            this.panelAgUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoQrPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoBarraPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingNavigator)).BeginInit();
            this.clientesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idClienteLabel
            // 
            idClienteLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            idClienteLabel.AutoSize = true;
            idClienteLabel.ForeColor = System.Drawing.Color.White;
            idClienteLabel.Location = new System.Drawing.Point(79, 178);
            idClienteLabel.Name = "idClienteLabel";
            idClienteLabel.Size = new System.Drawing.Size(54, 13);
            idClienteLabel.TabIndex = 3;
            idClienteLabel.Text = "Id Cliente:";
            // 
            // documentoLabel
            // 
            documentoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            documentoLabel.AutoSize = true;
            documentoLabel.ForeColor = System.Drawing.Color.White;
            documentoLabel.Location = new System.Drawing.Point(276, 178);
            documentoLabel.Name = "documentoLabel";
            documentoLabel.Size = new System.Drawing.Size(65, 13);
            documentoLabel.TabIndex = 5;
            documentoLabel.Text = "Documento:";
            // 
            // codPredioLabel
            // 
            codPredioLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            codPredioLabel.AutoSize = true;
            codPredioLabel.ForeColor = System.Drawing.Color.White;
            codPredioLabel.Location = new System.Drawing.Point(79, 213);
            codPredioLabel.Name = "codPredioLabel";
            codPredioLabel.Size = new System.Drawing.Size(62, 13);
            codPredioLabel.TabIndex = 7;
            codPredioLabel.Text = "Cod Predio:";
            // 
            // nombreLabel
            // 
            nombreLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            nombreLabel.AutoSize = true;
            nombreLabel.ForeColor = System.Drawing.Color.White;
            nombreLabel.Location = new System.Drawing.Point(276, 213);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 9;
            nombreLabel.Text = "Nombre:";
            // 
            // direccionLabel
            // 
            direccionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            direccionLabel.AutoSize = true;
            direccionLabel.ForeColor = System.Drawing.Color.White;
            direccionLabel.Location = new System.Drawing.Point(79, 249);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 11;
            direccionLabel.Text = "Direccion:";
            // 
            // estratoLabel
            // 
            estratoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            estratoLabel.AutoSize = true;
            estratoLabel.ForeColor = System.Drawing.Color.White;
            estratoLabel.Location = new System.Drawing.Point(276, 249);
            estratoLabel.Name = "estratoLabel";
            estratoLabel.Size = new System.Drawing.Size(43, 13);
            estratoLabel.TabIndex = 13;
            estratoLabel.Text = "Estrato:";
            // 
            // consumoLabel
            // 
            consumoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            consumoLabel.AutoSize = true;
            consumoLabel.ForeColor = System.Drawing.Color.White;
            consumoLabel.Location = new System.Drawing.Point(79, 284);
            consumoLabel.Name = "consumoLabel";
            consumoLabel.Size = new System.Drawing.Size(54, 13);
            consumoLabel.TabIndex = 15;
            consumoLabel.Text = "Consumo:";
            // 
            // pagoTotalLabel
            // 
            pagoTotalLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            pagoTotalLabel.AutoSize = true;
            pagoTotalLabel.ForeColor = System.Drawing.Color.White;
            pagoTotalLabel.Location = new System.Drawing.Point(276, 287);
            pagoTotalLabel.Name = "pagoTotalLabel";
            pagoTotalLabel.Size = new System.Drawing.Size(62, 13);
            pagoTotalLabel.TabIndex = 17;
            pagoTotalLabel.Text = "Pago Total:";
            // 
            // codigoQrLabel
            // 
            codigoQrLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            codigoQrLabel.AutoSize = true;
            codigoQrLabel.ForeColor = System.Drawing.Color.White;
            codigoQrLabel.Location = new System.Drawing.Point(32, 86);
            codigoQrLabel.Name = "codigoQrLabel";
            codigoQrLabel.Size = new System.Drawing.Size(57, 13);
            codigoQrLabel.TabIndex = 19;
            codigoQrLabel.Text = "Codigo Qr:";
            // 
            // codigoBarraLabel
            // 
            codigoBarraLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            codigoBarraLabel.AutoSize = true;
            codigoBarraLabel.ForeColor = System.Drawing.Color.White;
            codigoBarraLabel.Location = new System.Drawing.Point(251, 86);
            codigoBarraLabel.Name = "codigoBarraLabel";
            codigoBarraLabel.Size = new System.Drawing.Size(71, 13);
            codigoBarraLabel.TabIndex = 21;
            codigoBarraLabel.Text = "Codigo Barra:";
            // 
            // noFacturaLabel
            // 
            noFacturaLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            noFacturaLabel.AutoSize = true;
            noFacturaLabel.ForeColor = System.Drawing.Color.White;
            noFacturaLabel.Location = new System.Drawing.Point(276, 323);
            noFacturaLabel.Name = "noFacturaLabel";
            noFacturaLabel.Size = new System.Drawing.Size(63, 13);
            noFacturaLabel.TabIndex = 23;
            noFacturaLabel.Text = "No Factura:";
            // 
            // panelAgUsuario
            // 
            this.panelAgUsuario.BackColor = System.Drawing.Color.RoyalBlue;
            this.panelAgUsuario.Controls.Add(this.formAgregarUsuario);
            this.panelAgUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAgUsuario.Location = new System.Drawing.Point(0, 0);
            this.panelAgUsuario.Name = "panelAgUsuario";
            this.panelAgUsuario.Size = new System.Drawing.Size(532, 39);
            this.panelAgUsuario.TabIndex = 2;
            // 
            // formAgregarUsuario
            // 
            this.formAgregarUsuario.AutoSize = true;
            this.formAgregarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formAgregarUsuario.ForeColor = System.Drawing.Color.White;
            this.formAgregarUsuario.Location = new System.Drawing.Point(12, 7);
            this.formAgregarUsuario.Name = "formAgregarUsuario";
            this.formAgregarUsuario.Size = new System.Drawing.Size(177, 25);
            this.formAgregarUsuario.TabIndex = 1;
            this.formAgregarUsuario.Text = "Procesar Factura";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.dataSet1;
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
            // idClienteTextBox
            // 
            this.idClienteTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.idClienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "IdCliente", true));
            this.idClienteTextBox.Location = new System.Drawing.Point(156, 175);
            this.idClienteTextBox.Name = "idClienteTextBox";
            this.idClienteTextBox.Size = new System.Drawing.Size(100, 20);
            this.idClienteTextBox.TabIndex = 4;
            // 
            // documentoTextBox
            // 
            this.documentoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.documentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Documento", true));
            this.documentoTextBox.Location = new System.Drawing.Point(353, 175);
            this.documentoTextBox.Name = "documentoTextBox";
            this.documentoTextBox.Size = new System.Drawing.Size(100, 20);
            this.documentoTextBox.TabIndex = 6;
            // 
            // codPredioTextBox
            // 
            this.codPredioTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.codPredioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "CodPredio", true));
            this.codPredioTextBox.Location = new System.Drawing.Point(156, 210);
            this.codPredioTextBox.Name = "codPredioTextBox";
            this.codPredioTextBox.Size = new System.Drawing.Size(100, 20);
            this.codPredioTextBox.TabIndex = 8;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(353, 210);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 10;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(156, 246);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(100, 20);
            this.direccionTextBox.TabIndex = 12;
            // 
            // estratoTextBox
            // 
            this.estratoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.estratoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Estrato", true));
            this.estratoTextBox.Location = new System.Drawing.Point(353, 246);
            this.estratoTextBox.Name = "estratoTextBox";
            this.estratoTextBox.Size = new System.Drawing.Size(100, 20);
            this.estratoTextBox.TabIndex = 14;
            // 
            // consumoTextBox
            // 
            this.consumoTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.consumoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Consumo", true));
            this.consumoTextBox.Location = new System.Drawing.Point(156, 281);
            this.consumoTextBox.Name = "consumoTextBox";
            this.consumoTextBox.Size = new System.Drawing.Size(100, 20);
            this.consumoTextBox.TabIndex = 16;
            // 
            // pagoTotalTextBox
            // 
            this.pagoTotalTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pagoTotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "PagoTotal", true));
            this.pagoTotalTextBox.Location = new System.Drawing.Point(353, 284);
            this.pagoTotalTextBox.Name = "pagoTotalTextBox";
            this.pagoTotalTextBox.Size = new System.Drawing.Size(100, 20);
            this.pagoTotalTextBox.TabIndex = 18;
            // 
            // codigoQrPictureBox
            // 
            this.codigoQrPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.codigoQrPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.codigoQrPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.clientesBindingSource, "CodigoQr", true));
            this.codigoQrPictureBox.Location = new System.Drawing.Point(109, 86);
            this.codigoQrPictureBox.Name = "codigoQrPictureBox";
            this.codigoQrPictureBox.Size = new System.Drawing.Size(100, 70);
            this.codigoQrPictureBox.TabIndex = 20;
            this.codigoQrPictureBox.TabStop = false;
            // 
            // codigoBarraPictureBox
            // 
            this.codigoBarraPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.codigoBarraPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.codigoBarraPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.clientesBindingSource, "CodigoBarra", true));
            this.codigoBarraPictureBox.Location = new System.Drawing.Point(328, 86);
            this.codigoBarraPictureBox.Name = "codigoBarraPictureBox";
            this.codigoBarraPictureBox.Size = new System.Drawing.Size(172, 70);
            this.codigoBarraPictureBox.TabIndex = 22;
            this.codigoBarraPictureBox.TabStop = false;
            // 
            // noFacturaTextBox
            // 
            this.noFacturaTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.noFacturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "NoFactura", true));
            this.noFacturaTextBox.Location = new System.Drawing.Point(353, 320);
            this.noFacturaTextBox.Name = "noFacturaTextBox";
            this.noFacturaTextBox.Size = new System.Drawing.Size(100, 20);
            this.noFacturaTextBox.TabIndex = 24;
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // clientesBindingNavigator
            // 
            this.clientesBindingNavigator.AddNewItem = null;
            this.clientesBindingNavigator.BindingSource = this.clientesBindingSource;
            this.clientesBindingNavigator.CountItem = null;
            this.clientesBindingNavigator.DeleteItem = null;
            this.clientesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorSeparator1,
            this.toolStripButton1});
            this.clientesBindingNavigator.Location = new System.Drawing.Point(0, 39);
            this.clientesBindingNavigator.MoveFirstItem = null;
            this.clientesBindingNavigator.MoveLastItem = null;
            this.clientesBindingNavigator.MoveNextItem = null;
            this.clientesBindingNavigator.MovePreviousItem = null;
            this.clientesBindingNavigator.Name = "clientesBindingNavigator";
            this.clientesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientesBindingNavigator.Size = new System.Drawing.Size(532, 25);
            this.clientesBindingNavigator.TabIndex = 3;
            this.clientesBindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "BtnPrpcesarEditar";
            // 
            // btnCancelarClienteEditar
            // 
            this.btnCancelarClienteEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelarClienteEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarClienteEditar.FlatAppearance.BorderSize = 0;
            this.btnCancelarClienteEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarClienteEditar.ForeColor = System.Drawing.Color.White;
            this.btnCancelarClienteEditar.Location = new System.Drawing.Point(276, 351);
            this.btnCancelarClienteEditar.Name = "btnCancelarClienteEditar";
            this.btnCancelarClienteEditar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarClienteEditar.TabIndex = 26;
            this.btnCancelarClienteEditar.Text = "Cancelar";
            this.btnCancelarClienteEditar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarClienteEditar
            // 
            this.btnGuardarClienteEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardarClienteEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarClienteEditar.FlatAppearance.BorderSize = 0;
            this.btnGuardarClienteEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarClienteEditar.ForeColor = System.Drawing.Color.White;
            this.btnGuardarClienteEditar.Location = new System.Drawing.Point(134, 351);
            this.btnGuardarClienteEditar.Name = "btnGuardarClienteEditar";
            this.btnGuardarClienteEditar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarClienteEditar.TabIndex = 25;
            this.btnGuardarClienteEditar.Text = "Agregar";
            this.btnGuardarClienteEditar.UseVisualStyleBackColor = true;
            // 
            // ProcesarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(532, 386);
            this.Controls.Add(this.btnCancelarClienteEditar);
            this.Controls.Add(this.btnGuardarClienteEditar);
            this.Controls.Add(idClienteLabel);
            this.Controls.Add(this.idClienteTextBox);
            this.Controls.Add(documentoLabel);
            this.Controls.Add(this.documentoTextBox);
            this.Controls.Add(codPredioLabel);
            this.Controls.Add(this.codPredioTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(estratoLabel);
            this.Controls.Add(this.estratoTextBox);
            this.Controls.Add(consumoLabel);
            this.Controls.Add(this.consumoTextBox);
            this.Controls.Add(pagoTotalLabel);
            this.Controls.Add(this.pagoTotalTextBox);
            this.Controls.Add(codigoQrLabel);
            this.Controls.Add(this.codigoQrPictureBox);
            this.Controls.Add(codigoBarraLabel);
            this.Controls.Add(this.codigoBarraPictureBox);
            this.Controls.Add(noFacturaLabel);
            this.Controls.Add(this.noFacturaTextBox);
            this.Controls.Add(this.clientesBindingNavigator);
            this.Controls.Add(this.panelAgUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProcesarFactura";
            this.Text = "ProcesarFactura";
            this.Load += new System.EventHandler(this.ProcesarFactura_Load);
            this.panelAgUsuario.ResumeLayout(false);
            this.panelAgUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoQrPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.codigoBarraPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingNavigator)).EndInit();
            this.clientesBindingNavigator.ResumeLayout(false);
            this.clientesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAgUsuario;
        private System.Windows.Forms.Label formAgregarUsuario;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private DataSet1TableAdapters.ClientesTableAdapter clientesTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idClienteTextBox;
        private System.Windows.Forms.TextBox documentoTextBox;
        private System.Windows.Forms.TextBox codPredioTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox estratoTextBox;
        private System.Windows.Forms.TextBox consumoTextBox;
        private System.Windows.Forms.TextBox pagoTotalTextBox;
        private System.Windows.Forms.PictureBox codigoQrPictureBox;
        private System.Windows.Forms.PictureBox codigoBarraPictureBox;
        private System.Windows.Forms.TextBox noFacturaTextBox;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.BindingNavigator clientesBindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button btnCancelarClienteEditar;
        private System.Windows.Forms.Button btnGuardarClienteEditar;
    }
}