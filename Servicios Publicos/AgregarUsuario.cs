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
    public partial class AgregarUsuario : Form
    {        
        public AgregarUsuario()
        {
            InitializeComponent();
            validarCamposAgregarUsuario();
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //this.Validate();
            //this.usuariosBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.dataSet1);

        }        

        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            //boleano = false;
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Usuarios' Puede moverla o quitarla según sea necesario.
            //this.usuariosTableAdapter.TodosRegistros(this.dataSet1.Usuarios);
            //this.usuariosTableAdapter.BuscarporDocumento(this.dataSet1.Usuarios, Utils.DocUsuario);
            //boleano = true;
            validarCamposAgregarUsuario();
        }

        private void buttCerrAgrUsu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rolComboBoxAU_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            validarCamposAgregarUsuario();
        }

        private void fotoLabel_Click(object sender, EventArgs e)
        {
            this.openFileImg.Filter = "Imagenes| *.jpg; *.jpeg; *.png;.gif; *.tif";

            if (this.openFileImg.ShowDialog()==System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }else
            {
                this.fotoPictureBoxAU.Image = Image.FromFile(this.openFileImg.FileName);
            }
            validarCamposAgregarUsuario();
        }

        private void ElimFotAgrUsu_Click(object sender, EventArgs e)
        {
            this.fotoPictureBoxAU.Image = null;
            validarCamposAgregarUsuario();
        }

        private void btnCancelarUsu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void documentoTextBoxAU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                
                return;
            }
        }

        private void nombreTextBoxAU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;

                return;
            }
        }
        
        private void botonAgregarUsuario(object sender, KeyPressEventArgs e)
        {
            btnAgregarUsu.Enabled = true;
        }

        public void validarCamposAgregarUsuario()
        {           
            Console.WriteLine("se ejecuta validacion");
            if (!(string.IsNullOrEmpty((string)this.usuariosTableAdapter.ValidarDocumento(this.documentoTextBoxAU.Text))))
            {
                MessageBox.Show("El numero del documento ya existe", "Notificacion");
                string.IsNullOrEmpty(this.documentoTextBoxAU.Text);
                this.documentoTextBoxAU.Focus();
                btnAgregarUsu.Enabled = false;
            }
            else
            {
                if (this.fotoPictureBoxAU.Image == null)
                {
                    btnAgregarUsu.Enabled = false;
                }
                else if (string.IsNullOrEmpty(this.documentoTextBoxAU.Text))
                {
                    btnAgregarUsu.Enabled = false;
                }
                else if (string.IsNullOrEmpty(this.nombreTextBoxAU.Text))
                {
                    btnAgregarUsu.Enabled = false;
                }
                else if (string.IsNullOrEmpty(this.usuarioTextBoxAU.Text))
                {
                    btnAgregarUsu.Enabled = false;
                }
                else if (string.IsNullOrEmpty(this.rolComboBoxAU.Text))
                {
                    btnAgregarUsu.Enabled = false;
                }
                else if (string.IsNullOrEmpty(this.passwordTextBoxAU.Text))
                {
                    btnAgregarUsu.Enabled = false;
                }
                else
                {
                    btnAgregarUsu.Enabled = true;                    
                }
            }
        }      

        private void btnAgregarUsuAU_Click(object sender, EventArgs e)
        {
            try
            {
                validarCamposAgregarUsuario();
                this.passwordTextBoxAU.Text = Utils.Encriptar(this.passwordTextBoxAU.Text);
                this.usuariosTableAdapter.InsertarUsuarios(Utils.imageToByteArray(this.fotoPictureBoxAU.Image),
                    this.documentoTextBoxAU.Text, this.nombreTextBoxAU.Text, this.usuarioTextBoxAU.Text, this.rolComboBoxAU.Text,
                    this.passwordTextBoxAU.Text);

                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("El registro no se puede guardar en la base de datos", "Notificación");                
            }
        }

        private void documentoTextBoxAU_TextChanged(object sender, EventArgs e)
        {
            validarCamposAgregarUsuario();
        }

        private void nombreTextBoxAU_TextChanged(object sender, EventArgs e)
        {
            validarCamposAgregarUsuario();
        }

        private void usuarioTextBoxAU_TextChanged(object sender, EventArgs e)
        {
            validarCamposAgregarUsuario();
        }

        private void passwordTextBoxAU_TextChanged(object sender, EventArgs e)
        {
            validarCamposAgregarUsuario();
        }
    }
}
