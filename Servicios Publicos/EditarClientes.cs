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
    public partial class EditarClientes : Form
    {
        Boolean boleano = false;
        public EditarClientes()
        {
            InitializeComponent();
        }

        private void EditarClientes_Load(object sender, EventArgs e)
        {
            boleano = false;
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Clientes' Puede moverla o quitarla según sea necesario.
            //this.clientesTableAdapter.TodosRegistros(this.dataSet1.Clientes);
            this.clientesTableAdapter.BuscarporDocumento(this.dataSet1.Clientes,Utils.DocCliente);
            boleano = true;
            validarCamposEditarCliente();
        }
        
        private void buttCerrEditCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnCancelarClienteEditar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxEditarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            validarCamposEditarCliente();
        }

        private void documentoTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void nombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void validarCamposEditarCliente()
        {
            if (boleano == false)
            {
                return;
            }
            Console.WriteLine("se ejecuta validacion");
            string doc = (string)this.clientesTableAdapter.ValidarDocumentoEditarCliente(this.documentoTextBox.Text, Convert.ToInt32(this.idClienteTextBox.Text));
            if (string.IsNullOrEmpty(this.documentoTextBox.Text))
            {
                MessageBox.Show("El numero del documento no puede estar vacio", "Notificacion");
                this.documentoTextBox.Focus();
                btnGuardarClienteEditar.Enabled = false;
            }
            //else if (!(string.IsNullOrEmpty(doc)))
            //{
            //    MessageBox.Show("El numero del documento ya existe", "Notificacion");
            //    this.documentoTextBox.Focus();
            //    btnGuardarClienteEditar.Enabled = false;
            //}
            else
            {
               if (string.IsNullOrEmpty(this.documentoTextBox.Text))
                {
                    btnGuardarClienteEditar.Enabled = false;
                }
                else if (string.IsNullOrEmpty(this.codPredioTextBox.Text))
                {
                    btnGuardarClienteEditar.Enabled = false;
                }
                else if (string.IsNullOrEmpty(this.nombreTextBox.Text))
                {
                    btnGuardarClienteEditar.Enabled = false;
                }
                else if (string.IsNullOrEmpty(this.direccionTextBox.Text))
                {
                    btnGuardarClienteEditar.Enabled = false;
                }
                else if (string.IsNullOrEmpty(this.comboBoxEditarCliente.Text))
                {
                    btnGuardarClienteEditar.Enabled = false;
                }
                else
                {
                    btnGuardarClienteEditar.Enabled = true;
                }
            }
        }

        private void btnGuardarClienteEditar_Click(object sender, EventArgs e)
        {
            try
            {
                validarCamposEditarCliente();
                this.clientesTableAdapter.ActualizarCliente(this.documentoTextBox.Text,this.codPredioTextBox.Text,this.nombreTextBox.Text,
                    this.direccionTextBox.Text,this.comboBoxEditarCliente.Text,Convert.ToInt32(this.idClienteTextBox.Text));

                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("El registro no se puede guardar en la base de datos", "Notificación");
                
            }
        }

        private void documentoTextBox_TextChanged(object sender, EventArgs e)
        {
            validarCamposEditarCliente();
        }

        private void codPredioTextBox_TextChanged(object sender, EventArgs e)
        {
            validarCamposEditarCliente();
        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {
            validarCamposEditarCliente();
        }

        private void direccionTextBox_TextChanged(object sender, EventArgs e)
        {
            validarCamposEditarCliente();
        }

        private void comboBoxEditarCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            validarCamposEditarCliente();
        }
    }
}
