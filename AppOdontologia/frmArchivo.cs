using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppOdontologia
{
    public partial class frmArchivo : Form
    {
        public frmArchivo()
        {
            InitializeComponent();
        }

        
        #region  DECLARACION DE VARIABLES
        Conexion.SqlConexion con = new Conexion.SqlConexion();
        String query, querya, queryb;
        string paciente;
        #endregion

        #region  METODOS PERSONALIZADOS
        public void mostrarPacientes()
        {
            querya = "SELECT concat(nombre, ' ', apellido) as Paciente, edad as Edad, sexo as Sexo, fechaNacimiento as Fecha_Nacimiento, direccion as Direccion, telefono as Telefono FROM tblPaciente";
            con.LlenarGrid(querya, dgvListaPaciente);
        }
        public void busqueda()
        {
            queryb = "SELECT concat(nombre, ' ', apellido) as Paciente, edad as Edad, sexo as Sexo, fechaNacimiento as Fecha_Nacimiento, direccion as Direccion, telefono as Telefono FROM tblPaciente where concat(nombre, ' ', apellido) like '%" + txtBucar.Text + "%'; ";
            con.LlenarGrid(queryb, dgvListaPaciente);
        }
        #endregion

        #region METODOS GENERADOS
        private void frmArchivo_Load(object sender, EventArgs e)
        {
            mostrarPacientes();
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            busqueda();
        }
        private void dgvListaPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditarPaciente editar = new frmEditarPaciente();
                editar.Show();
           }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvListaPaciente_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListaPaciente.RowCount > 0)
            {

                txtBucar.Text = dgvListaPaciente.Rows[dgvListaPaciente.CurrentRow.Index].
                                Cells["Paciente"].Value.ToString();

            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvListaPaciente.RowCount > 0)
            {
                if (MessageBox.Show("Desea eliminar el registro?  " + txtBucar.Text, "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    query = "DELETE FROM tblPaciente WHERE concat(nombre, ' ', apellido) = '" + txtBucar.Text + "';";
                    con.Ejecutar(query);
                    mostrarPacientes();
                    MessageBox.Show("Registro eliminado correctamente ", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    txtBucar.Clear();
                    mostrarPacientes();
                }
            }
        }
        #endregion





       
    }
}
