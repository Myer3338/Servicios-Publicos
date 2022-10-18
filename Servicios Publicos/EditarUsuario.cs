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
    public partial class EditarUsuario : Form
    {
        Boolean boleano = false;
        public EditarUsuario()
        {
            InitializeComponent();
        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            boleano = false;
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Usuarios' Puede moverla o quitarla según sea necesario.
            // this.usuariosTableAdapter.TodosRegistros(this.dataSet1.Usuarios);
            this.usuariosTableAdapter.BuscarporDocumento(this.dataSet1.Usuarios, Utils.DocUsuario);
            Console.WriteLine(this.fotoPictureBoxEditUsu.Image);
            // this.fotoPictureBoxEditUsu.Image = Utils.Convertir_Bytes_Imagen(Utils.Convertir_Imagen_Bytes(this.fotoPictureBoxEditUsu.Image));
            this.passwordTextBoxEU.Text = Utils.Desencriptar(this.passwordTextBoxEU.Text);
            boleano = true;
            validarCamposEditarUsuario();
        }

        private void buttCerrEditUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rolComboBoxEU_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            validarCamposEditarUsuario();
        }

        private void fotoLabelEditUsu_Click(object sender, EventArgs e)
        {
            this.openFileImgEdit.Filter = "Imagenes| *.jpg; *.jpeg; *.png;.gif; *.tif";

            if (this.openFileImgEdit.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            else
            {
                this.fotoPictureBoxEditUsu.Image = Image.FromFile(this.openFileImgEdit.FileName);
            }
            validarCamposEditarUsuario();
        }

        private void EliminarFotoEditUsu_Click(object sender, EventArgs e)
        {
            this.fotoPictureBoxEditUsu.Image = null;
            validarCamposEditarUsuario();
        }

        private void cancelarEditUsua_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void documentoTextBoxEU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void nombreTextBoxEU_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar > 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void validarCamposEditarUsuario()
        {
            if (boleano == false)
            {
                return;
            }
            Console.WriteLine("se ejecuta validacion");
            string doc = (string)this.usuariosTableAdapter.ValidarDocumentoEditar(this.documentoTextBoxEU.Text, Convert.ToInt32(this.idUsuarioTextBox.Text));
            if (string.IsNullOrEmpty(this.documentoTextBoxEU.Text))
            {
                MessageBox.Show("El numero del documento no puede estar vacio", "Notificacion");
                this.documentoTextBoxEU.Focus();
                btnguardarcambiosEditUsu.Enabled = false;
            }
            else if (!(string.IsNullOrEmpty(doc)))
            {
                MessageBox.Show("El numero del documento ya existe", "Notificacion");
                this.documentoTextBoxEU.Focus();
                btnguardarcambiosEditUsu.Enabled = false;
            }
            else
            {
                if (this.fotoPictureBoxEditUsu.Image == null)
                {
                    btnguardarcambiosEditUsu.Enabled = false;
                }
                else if (string.IsNullOrEmpty(this.documentoTextBoxEU.Text))
                {
                    btnguardarcambiosEditUsu.Enabled = false;
                }
                else if (string.IsNullOrEmpty(this.nombreTextBoxEU.Text))
                {
                    btnguardarcambiosEditUsu.Enabled = false;
                }
                else if (string.IsNullOrEmpty(this.usuarioTextBoxEU.Text))
                {
                    btnguardarcambiosEditUsu.Enabled = false;
                }
                else if (string.IsNullOrEmpty(this.rolComboBoxEU.Text))
                {
                    btnguardarcambiosEditUsu.Enabled = false;
                }
                else if (string.IsNullOrEmpty(this.passwordTextBoxEU.Text))
                {
                    btnguardarcambiosEditUsu.Enabled = false;
                }
                else
                {
                    btnguardarcambiosEditUsu.Enabled = true;
                }
            }

        }

        private void btnguardarcambiosEditUsu_Click(object sender, EventArgs e)
        {
            try
            {
                validarCamposEditarUsuario();
                this.passwordTextBoxEU.Text = Utils.Encriptar(this.passwordTextBoxEU.Text);
                this.usuariosTableAdapter.ActualizarUsuarios(Utils.Convertir_Imagen_Bytes(this.fotoPictureBoxEditUsu.Image), 
                    this.documentoTextBoxEU.Text, this.nombreTextBoxEU.Text, this.usuarioTextBoxEU.Text, this.rolComboBoxEU.Text, 
                    this.passwordTextBoxEU.Text, Convert.ToInt32(this.idUsuarioTextBox.Text));

                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("El registro no se puede guardar en la base de datos", "Notificación");
            }
        }

        private void documentoTextBoxEU_TextChanged(object sender, EventArgs e)
        {
            validarCamposEditarUsuario();
        }

        private void nombreTextBoxEU_TextChanged(object sender, EventArgs e)
        {
            validarCamposEditarUsuario();
        }

        private void usuarioTextBoxEU_TextChanged(object sender, EventArgs e)
        {
            validarCamposEditarUsuario();
        }

        private void passwordTextBoxEU_TextChanged(object sender, EventArgs e)
        {
            validarCamposEditarUsuario();
        }
    }
}
