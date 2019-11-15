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
    public partial class frmHistorial : Form
    {
        public frmHistorial()
        {
            InitializeComponent();
        }

        #region DECLARACION DE VARIABLES 
        string buscarN,obtenerId;
        historial hi = new historial();
        Conexion.SqlConexion con = new Conexion.SqlConexion();
        int id;
        #endregion 

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            busquedaNombre();
        }

        public void busquedaNombre()
        {
            buscarN = "SELECT concat(nombre, ' ', apellido) as Paciente FROM tblPaciente where concat(nombre, ' ', apellido) like '%" + txtBuscar.Text + "%'; ";
            con.LlenarGrid(buscarN, dgvHistorial);
        }
        private void frmHistorial_Load(object sender, EventArgs e)
        {

        }
        public void idPaciente()
        {
            obtenerId = ("SELECT idPaciente FROM tblPaciente where concat(nombre, ' ', apellido) like '%" + txtBuscar.Text + "%'; ");
            con.Ejecutar(obtenerId);
            id = int.Parse(obtenerId);
        }
        public void mostrarPacientes()
        {
            buscarN = "SELECT concat(nombre, ' ', apellido) as Paciente FROM tblPaciente";
            con.LlenarGrid(buscarN, dgvHistorial);

        }
    }
}
