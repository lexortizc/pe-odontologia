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
    public partial class frmAgregarHistoria1 : Form
    {
        public frmAgregarHistoria1()
        {
            InitializeComponent();
        }

        #region DECLARACION DE VARIABLES
        string nombre;
        Conexion.SqlConexion con = new Conexion.SqlConexion();
        #endregion
        #region METODOS GENERADOS
        private void frmAgregarHistoria1_Load(object sender, EventArgs e)
        {
            mostrarPacientes();
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            frmAgregarHistoria3 h2 = new frmAgregarHistoria3();
            h2.Show();
        }
        private void abrirSiguiente(Form formSiguiente)
        {

        }

        private void dgvNombre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtNombrePaciente.Text = dgvNombre.Rows[dgvNombre.CurrentRow.Index].
                            Cells["Paciente"].Value.ToString();
        }


        private void btnBuscarNombre_Click(object sender, EventArgs e)
        {
            busqueda();
        }
        #endregion
        #region METODOS PERSONALIZADOS
        public void busqueda()
        {
            nombre = "SELECT concat(nombre, ' ', apellido) as Paciente FROM tblPaciente where concat(nombre, ' ', apellido) like '%" + txtNombrePaciente.Text + "%'; ";
            con.LlenarGrid(nombre, dgvNombre);
        }
        public void mostrarPacientes()
        {
            nombre = "SELECT concat(nombre, ' ', apellido) as Paciente FROM tblPaciente";
            con.LlenarGrid(nombre, dgvNombre);

        }
        #endregion






        

     
    }
}
