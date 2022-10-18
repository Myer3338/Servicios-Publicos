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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.TodosRegistros(this.dataSet1.Clientes);
        }

        private void btnCerrarClientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAgregarClientes_Click(object sender, EventArgs e)
        {
            AgregarClientes agregarClientes = new AgregarClientes();
            agregarClientes.ShowDialog();
            this.clientesTableAdapter.TodosRegistros(this.dataSet1.Clientes);
        }

        private void clientesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if (n != -1)
            {
                Utils.DocCliente = (clientesDataGridView.Rows[n].Cells[1].Value.ToString());
            }
        }

        private void ButtonEditarClientes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Utils.DocCliente))
            {
                MessageBox.Show("Por favor seleccione el registro a editar", "Notificacion");
            }
            else
            {
                EditarClientes editarClientes = new EditarClientes();
                editarClientes.ShowDialog();
                this.clientesTableAdapter.TodosRegistros(this.dataSet1.Clientes);
            }
            Utils.DocCliente = string.Empty;
        }

        private void ButtonEliminarClientes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Utils.DocCliente))
            {
                MessageBox.Show("Por favor seleccione el registro a eliminar", "Notificacion");
            }
            else if (MessageBox.Show("¿Desea eliminar el registro?", "Eliminar registro",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                this.clientesTableAdapter.EliminarClientes(Utils.DocCliente);
                MessageBox.Show("El registro se ha eliminado con exito", "Notificación");
            }
            Utils.DocCliente = string.Empty;
            this.clientesTableAdapter.TodosRegistros(this.dataSet1.Clientes);
        }        

        private void ButtonReporteClientes_Click(object sender, EventArgs e)
        {
            //Cursor.Current = Cursor.WaitCursor;
            //creo una instancia del reporte

            CrystalReportServiciosPublicosClientes reporteClientes = new CrystalReportServiciosPublicosClientes();

            //llenamos el tabla adapter
            this.clientesTableAdapter.TodosRegistros(this.dataSet1.Clientes);

            //asignamos los datos al reporte a traves del metodo setdatasource()
            reporteClientes.SetDataSource(this.dataSet1);

            //Cursor.Current = Cursor.Default;

            //asignamos el reporte al crystal report
            Reportes rp = new Reportes();
            rp.crystalReportViewer1.ReportSource = reporteClientes;
            rp.ShowDialog();
            rp.Close();
        }

        private void TextBoxBusquedaClientes_TextChanged(object sender, EventArgs e)
        {
            this.clientesTableAdapter.BusquedaIndexada(this.dataSet1.Clientes, this.TextBoxBusquedaClientes.Text,
                this.TextBoxBusquedaClientes.Text, this.TextBoxBusquedaClientes.Text, this.TextBoxBusquedaClientes.Text,
                this.TextBoxBusquedaClientes.Text, this.TextBoxBusquedaClientes.Text);
        }
    }
}
