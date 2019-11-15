using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppOdontologia.Conexion;
using AppOdontologia.Clases;

namespace AppOdontologia
{
    public partial class frmAgregarHistoria2 : Form
    {
        #region Variables Globales
        string consulta;
        SqlConexion con = new SqlConexion();
        List<string> detalles = new List<string>();
        List<DetalleDiente> lsDetalleDiente = new List<DetalleDiente>();

        #endregion

        public frmAgregarHistoria2()
        {
            InitializeComponent();
            //Actualizar fecha
            lblFecha.Text = DateTime.Now.ToShortDateString().ToString();
            // LLenar ComboBoxs
            llenarComboDientes();
            llenarComboDetalles();
        }

        private void frmAgregarHistoria2_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarDetalle();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            /*frmAgregarHistoria2 frmHistoria2 = new frmAgregarHistoria2()
            frmAgregarHistoria3 frmHistoria3 = new frmAgregarHistoria3()
            if (frmActivo != null)
            {
                frmHistoria2.Close();
            }
            frmActivo = frmNuevo;
            frmNuevo.TopLevel = false;
            frmNuevo.FormBorderStyle = FormBorderStyle.None;
            frmNuevo.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(frmNuevo);
            panelContenido.Tag = frmNuevo;
            frmNuevo.BringToFront();
            frmNuevo.Show();*/

            frmMenuPrincipal menu = new frmMenuPrincipal();
            //menu.abrirForm(new frmAgregarHistoria3(lsDetalleDiente));
            menu.abrirForm(new frmAgregarHistoria1());
            //MessageBox.Show("Yeah!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region METODOS PERSONALIZADOS
        public void llenarComboDientes()
        {
            consulta = null;
            consulta = "SELECT idDiente, nombre FROM tblDiente;";
            con.LlenarCombo(consulta, "idDiente", "nombre", cmbDiente);
        }
            public void llenarComboDetalles()
        {
            cmbDetalle.Items.Clear();
            cmbDetalle.Items.Add("Seleccione");
            cmbDetalle.Items.Add("Diente ausente");
            cmbDetalle.Items.Add("Diente a extraer");
            cmbDetalle.Items.Add("Caries");
            cmbDetalle.Items.Add("Obturación");
            cmbDetalle.Items.Add("Corona");
            cmbDetalle.Items.Add("Tramo");
            cmbDetalle.SelectedIndex = 0;
        }

        public void agregarDetalle()
        {
            if (cmbDetalle.SelectedIndex != 0)
            {
                //Llenando el objeto DetalleDiente
                DetalleDiente detalleDiente = new DetalleDiente();
                detalleDiente.detalle = cmbDetalle.SelectedItem.ToString();
                detalleDiente.idDiente = Int32.Parse(cmbDiente.SelectedValue.ToString());
                //Llenando la lista DetalleDiente
                lsDetalleDiente.Add(detalleDiente);
                detalles.Clear();

                foreach (var item in lsDetalleDiente)
                {
                    detalles.Add("D" + item.idDiente + ": " + item.detalle);
                }

                listDetalleDiente.DataSource = null;
                listDetalleDiente.DataSource = detalles;
            }

        }
        #endregion
    }
}
