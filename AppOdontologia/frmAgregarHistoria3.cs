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
    public partial class frmAgregarHistoria3 : Form
    {
        
        #region DECLARACION DE VARIABLES
        Conexion.SqlConexion con = new Conexion.SqlConexion();
        historia h = new historia();
        string query;
        #endregion
        #region METODOS GENERADOS
        private void gbxSecuencia_Enter(object sender, EventArgs e)
        { }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
            gbxSecuencia.Visible = false;
        }
        public frmAgregarHistoria3()
        {
            InitializeComponent();

        }
        private void frmAgregarHistoria3_Load(object sender, EventArgs e)
        {
            gbxSecuencia.Visible = false;
            h.diagnostico = txtDiagnostico.Text;
            h.estado = txtEstado.Text;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            insertar();
            MessageBox.Show("Registros insertados correctamente");
        }

        private void txtAspecto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dtpFecha.Value = DateTime.Now;
        }
        private void btnSecuencia_Click(object sender, EventArgs e)
        {
            gbxSecuencia.Show();

        }
        #endregion
        #region METODOS PERSONALIZADOS
        void limpiar() {
            txtDescripcion.Clear();
            dtpFecha.Value = DateTime.Now;
        }
        public void insertar() {
            query = "insert into tblHistoria (fecha, motivoConsulta, enfermedad, diagnostico, estado, idPaciente) values ('"+h.fecha+"','"+h.motivo+"','"+h.enfermedad+"','"+h.diagnostico+"','"+h.estado+"','"+ h.idpaciente.ToString() + "');";
            con.Ejecutar(query);
        }
        #endregion

        
    }

    }
