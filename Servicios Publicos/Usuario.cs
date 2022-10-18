using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Servicios_Publicos
{
    public partial class Usuario : Form
    {
        public Usuario()
        {
            InitializeComponent();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.TodosRegistros(this.dataSet1.Usuarios);
        }

        private void btnCerrarUsu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButIngresar_Click(object sender, EventArgs e)
        {
            AgregarUsuario agregarUsuario = new AgregarUsuario();
            agregarUsuario.ShowDialog();
            this.usuariosTableAdapter.TodosRegistros(this.dataSet1.Usuarios);
        }

        private void usuariosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                Utils.DocUsuario = (usuariosDataGridView.Rows[n].Cells[2].Value.ToString());
            }
        }

        private void toolStripButEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Utils.DocUsuario))
            {
                MessageBox.Show("Por favor seleccione el registro a editar", "Notificacion");
            }else
            {
                EditarUsuario editarUsuario = new EditarUsuario();
                editarUsuario.ShowDialog();
                this.usuariosTableAdapter.TodosRegistros(this.dataSet1.Usuarios);
            }
            Utils.DocUsuario = string.Empty;
        }

        private void toolStripButEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Utils.DocUsuario))
            {
                MessageBox.Show("Por favor seleccione el registro a eliminar", "Notificacion");
            }else if (MessageBox.Show("¿Desea eliminar el registro?", "Eliminar registro", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                this.usuariosTableAdapter.EliminarUsuarioByDocumento(Utils.DocUsuario);

                MessageBox.Show("El registro se ha eliminado con exito", "Notificación");
            }
            Utils.DocUsuario = string.Empty;
            this.usuariosTableAdapter.TodosRegistros(this.dataSet1.Usuarios);

        }

        private void toolStripButImprimir_Click(object sender, EventArgs e)
        {
            //Cursor.Current = Cursor.WaitCursor;
            //creo una instancia del reporte
            CrystalReportServiciosPublicosUsuarios reporteUsuarios = new CrystalReportServiciosPublicosUsuarios();

            //llenamos el tabla adapter
            this.usuariosTableAdapter.TodosRegistros(this.dataSet1.Usuarios);

            //asignamos los datos al reporte a traves del metodo setdatasource()
            reporteUsuarios.SetDataSource(this.dataSet1);

            //Cursor.Current = Cursor.Default;

            //asignamos el reporte al crystal report
            Reportes rp = new Reportes();
            rp.crystalReportViewer1.ReportSource = reporteUsuarios;
            rp.ShowDialog();
            rp.Close();
        }

        private void toolStripTextBusquedaUsuario_TextChanged(object sender, EventArgs e)
        {
            this.usuariosTableAdapter.BusquedaIndexada(this.dataSet1.Usuarios, this.toolStripTextBusquedaUsuario.Text, this.toolStripTextBusquedaUsuario.Text,
                this.toolStripTextBusquedaUsuario.Text, this.toolStripTextBusquedaUsuario.Text);
        }
    }
}
