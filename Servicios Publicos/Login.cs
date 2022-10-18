using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicios_Publicos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection coneccion = new SqlConnection("server = DESKTOP-4T5HREL ; database = sistemas ; INTEGRATED SECURITY = true");

        private void butnEntrar_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //this.Visible = false; /*este lo pone invisible al undir el boton entrar*/
            //Menu m = new Menu();
            //m.ShowDialog(); /*No  lo deja abrir otra ventana esde el login hasta que cierra la ventana de menu*/
            ///*m.Show(); este me deja abrir muchas ventanas iguales */

            //coneccion.Open();
            //SqlCommand comando = new SqlCommand("SELECT USUARIO, CONTRASENA FROM PERSONALOGIN WHERE USUARIO = @vusuario AND CONTRASENA = @vcontrasena", coneccion);
            //comando.Parameters.AddWithValue("@vusuario", textUsuario.Text);
            //comando.Parameters.AddWithValue("@vcontrasena", textContraseña.Text);

            //SqlDataReader lector = comando.ExecuteReader();

            //if (lector.Read())
            //{
            //    coneccion.Close();
            //    Menu mn = new Menu();
            //    mn.ShowDialog(); /*No  lo deja abrir otra ventana esde el login hasta que cierra la ventana de menu*/
            //    /*m.Show(); este me deja abrir muchas ventanas iguales */
            //}

            if (string.IsNullOrEmpty(this.textUsuario.Text))
            {
                MessageBox.Show("Por faver digite el usuario", "Notificación");
                this.textUsuario.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(this.textContraseña.Text))
                {
                    MessageBox.Show("Por faver digite la contraseña", "Notificación");
                    this.textContraseña.Focus();
                }
                else
                {
                    Utils.RolActual = (string)this.usuariosTableAdapter.BuscarRol(this.textUsuario.Text, Utils.Encriptar(this.textContraseña.Text));
                    if (string.IsNullOrEmpty(Utils.RolActual))
                    {
                        MessageBox.Show("suario o contraseña incorrecta", "Notificación");
                        this.textUsuario.Focus();
                    }
                    else
                    {
                        Utils.UsuarioActual = (string) this.usuariosTableAdapter.BuscarUsuario(this.textUsuario.Text, Utils.Encriptar(this.textContraseña.Text));
                        Menu menu = new Menu();
                        menu.ShowDialog();
                    }
                }
            }

        }

        private void pictureclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textUsuario_Click(object sender, EventArgs e)
        {
            if (this.textUsuario.Text =="Usuario")
            {
                this.textUsuario.Text = "";
            }
        }

        private void textUsuario_Leave(object sender, EventArgs e)
        {
            if (this.textUsuario.Text=="")
            {
                this.textUsuario.Text = "Usuario";
            }
        }

        private void textContraseña_Click(object sender, EventArgs e)
        {
            if (this.textContraseña.Text == "Contraseña")
            {               
                this.textContraseña.Text = "";
                this.textContraseña.UseSystemPasswordChar = true;

            }
        }

        private void textContraseña_Leave(object sender, EventArgs e)
        {
            if (this.textUsuario.Text == "")
            {
                this.textUsuario.Text = "Contraseña";
                this.textContraseña.UseSystemPasswordChar = false;
            }
        }

        private void usuariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuariosBindingSource.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.dataSet1);

        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.TodosRegistros(this.dataSet1.Usuarios);

        }
    }
}
