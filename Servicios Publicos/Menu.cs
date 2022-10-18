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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();          
            this.mostrarRol.Text = Utils.RolActual;
            if (Utils.RolActual == "Facturador")
            {
                this.BtnUsuarios.Enabled = false;
                this.BtnClientes.Enabled = false;
                this.BtnProcesar.Enabled = false;
                this.BtnCalcular.Enabled = true;
                this.BtnReportes.Enabled = true;
            }
            else if (Utils.RolActual == "Digitador")
            {
                this.BtnUsuarios.Enabled = false;
                this.BtnClientes.Enabled = true;
                this.BtnProcesar.Enabled = true;
                this.BtnCalcular.Enabled = false;
                this.BtnReportes.Enabled = false;
            }
            else
            {
                this.BtnUsuarios.Visible = true;
                this.BtnUsuarios.Enabled = true;
                this.BtnClientes.Enabled = true;
                this.BtnProcesar.Enabled = true;
                this.BtnCalcular.Enabled = true;
                this.BtnReportes.Enabled = true;
            }  
        }

        private void AbrirFormularioUsuario(object Usuario)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form Us = Usuario as Form;
            Us.TopLevel = false;
            Us.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(Us);
            this.panelContenedor.Tag = Us;
            Us.Show();
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioUsuario(new Usuario());
        }

        private void AbrirFormularioClientes(object Clientes)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form Cts = Clientes as Form;
            Cts.TopLevel = false;
            Cts.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(Cts);
            this.panelContenedor.Tag = Cts;
            Cts.Show();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            AbrirFormularioClientes(new Clientes());
        }

        private void AbrirFormularioProcesarFactura(object ProcesarFactura)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form Pcs = ProcesarFactura as Form;
            Pcs.TopLevel = false;
            Pcs.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(Pcs);
            this.panelContenedor.Tag = Pcs;
            Pcs.Show();
        }

        private void BtnProcesar_Click(object sender, EventArgs e)
        {
            AbrirFormularioProcesarFactura(new ProcesarFactura());
        }

        private void AbrirformularioCalcular( object Calcular)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form Cal = Calcular as Form;
            Cal.TopLevel = false;
            Cal.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(Cal);
            this.panelContenedor.Tag = Cal;
            Cal.Show();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            AbrirformularioCalcular(new Calcular());
        }

        private void AbrirFormularioReportes(object Reportes)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form Rep = Reportes as Form;
            Rep.TopLevel = false;
            Rep.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(Rep);
            this.panelContenedor.Tag = Rep;
            Rep.Show();
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormularioReportes(new Reportes());
        }

        private void AbrirFormularioFactura(object Factura)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form Fact = Factura as Form;
            Fact.TopLevel = false;
            Fact.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(Fact);
            this.panelContenedor.Tag = Fact;
            Fact.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormularioFactura(new Factura());
        }

        private void AbrirFormularioAcerca(object Acerca)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form Ac = Acerca as Form;
            Ac.TopLevel = false;
            Ac.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(Ac);
            this.panelContenedor.Tag = Ac;
            Ac.Show();
        }

        private void BtnAcerca_Click(object sender, EventArgs e)
        {
            AbrirFormularioAcerca(new Acerca());
        }      

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.BtnRestaurar.Visible = false;
            this.BtnMaximizar.Visible = true;
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.BtnRestaurar.Visible = true;
            this.BtnMaximizar.Visible = false;
        }

        private void BtnCerra_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Salir de la sesión?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Form frm in Application.OpenForms.Cast<Form>().ToList())
                {
                    frm.Close();
                }
            }
        }

        private void Menu_KeyDown(object sender, KeyEventArgs e)
        {
            // NOTA: En el formulario en la propiedad Keypreview = true
            // Evitar salir con la tecla f4
            if (e.Alt && e.KeyCode == Keys.F4)
            {
                e.Handled = true;
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.TodosRegistros(this.dataSet1.Usuarios);
            AbrirFormularioInicio(new Inicio());
        }

        private void AbrirFormularioInicio(Object Inicio)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            Form In = Inicio as Form;
            In.TopLevel = false;
            In.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(In);
            this.panelContenedor.Tag = In;
            In.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.panelMenu.Width == 159)
            {
                this.panelMenu.Width = 57;
                this.pictureBox1.Visible = false;
            }
            else
            {
                this.panelMenu.Width = 159;
                this.pictureBox1.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormularioInicio(new Inicio());
        }

        private void cerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Cerrar Sesión?", "Información", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (Form frm in Application.OpenForms.Cast<Form>().ToList())
                {
                    frm.Close();
                }
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                //Login login = new Login();
                //login.ShowDialog();
                //this.Close();
            }
        }

        
    }
}
