using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicios_Publicos
{
    public partial class AgregarClientes : Form
    {
        public AgregarClientes()
        {
            InitializeComponent();
            validarCamposAgregarCliente();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.clientesBindingSource.EndEdit();
        }

        private void AgregarClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Clientes' Puede moverla o quitarla según sea necesario.
            //this.clientesTableAdapter.TodosRegistros(this.dataSet1.Clientes);
            validarCamposAgregarCliente();
        }

        private void cerrarAgregarCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarAgregCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxAgregarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            validarCamposAgregarCliente();
        }

        private void documentoTextBoxClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;

                return;
            }
        }

        private void nombreTextBoxClientes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;

                return;
            }
        }

        private void botonAgregarCliente(object sender, KeyPressEventArgs e)
        {
            btnAgregarCliente.Enabled = true;
        }

        public void validarCamposAgregarCliente()
        {
            Console.WriteLine("se ejecuta validacion");
            if (!(string.IsNullOrEmpty((string)this.clientesTableAdapter.ValidarDocumentoClientes(this.documentoTextBoxClientes.Text))))
            {
                MessageBox.Show("El numero del documento ya existe", "Notificacion");
                string.IsNullOrEmpty(this.documentoTextBoxClientes.Text);
                this.documentoTextBoxClientes.Focus();
                btnAgregarCliente.Enabled = false;
            }
            else
            {
                if (string.IsNullOrEmpty(this.documentoTextBoxClientes.Text))
                {
                    btnAgregarCliente.Enabled = false;
                }
                else
                {
                    if (string.IsNullOrEmpty(this.codPredioTextBoxClientes.Text))
                    {
                        btnAgregarCliente.Enabled = false; ;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(this.nombreTextBoxClientes.Text))
                        {
                            btnAgregarCliente.Enabled = false;
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(this.direccionTextBoxClientes.Text))
                            {
                                btnAgregarCliente.Enabled = false;
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(this.comboBoxAgregarCliente.Text))
                                {
                                    btnAgregarCliente.Enabled = false;
                                }
                                else
                                {
                                    btnAgregarCliente.Enabled = true;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                validarCamposAgregarCliente();
                this.clientesTableAdapter.InsertarCliente(this.documentoTextBoxClientes.Text, this.codPredioTextBoxClientes.Text,
                this.nombreTextBoxClientes.Text, this.direccionTextBoxClientes.Text, this.comboBoxAgregarCliente.Text);

                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("El registro no se puede guardar en la base de datos", "Notificación");
            }
        }

        private void documentoTextBoxClientes_TextChanged(object sender, EventArgs e)
        {
            validarCamposAgregarCliente();
        }

        private void codPredioTextBoxClientes_TextChanged(object sender, EventArgs e)
        {
            validarCamposAgregarCliente();
        }

        private void nombreTextBoxClientes_TextChanged(object sender, EventArgs e)
        {
            validarCamposAgregarCliente();
        }

        private void direccionTextBoxClientes_TextChanged(object sender, EventArgs e)
        {
            validarCamposAgregarCliente();
        }

        private void comboBoxAgregarCliente_TextChanged(object sender, EventArgs e)
        {
            validarCamposAgregarCliente();
        }
    }
}
