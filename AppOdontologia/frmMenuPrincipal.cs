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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            iniciarMenu();

        }

        #region VARIABLES GLOBALES
        private Form frmActivo = null;
        #endregion

        #region METODOS PERSONALIZADOS
        private void iniciarMenu()
        {
            panelPaciente.Visible = false;
            panelHistoria.Visible = false;
            panelReporte.Visible = false;
        }

        private void controlarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        public void abrirForm(Form frmNuevo)
        {
            if(frmActivo != null)
            {
                frmActivo.Close();
            }
            frmActivo = frmNuevo;
            frmNuevo.TopLevel = false;
            frmNuevo.FormBorderStyle = FormBorderStyle.None;
            frmNuevo.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(frmNuevo);
            panelContenido.Tag = frmNuevo;
            frmNuevo.BringToFront();
            frmNuevo.Show(); 
        }
        #endregion

        #region METODOS AUTOGENERADOS

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private void BtnPaciente_Click(object sender, EventArgs e)
        {
            controlarSubMenu(panelPaciente);
        }

        private void BtnHistoria_Click(object sender, EventArgs e)
        {
            controlarSubMenu(panelHistoria);
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            controlarSubMenu(panelReporte);
        }

        private void BtnAgregarPaciente_Click(object sender, EventArgs e)
        {
            abrirForm(new frmAgregarPaciente());
        }

        private void BtnArchivo_Click(object sender, EventArgs e)
        {
            abrirForm(new frmArchivo());
        }

        private void BtnAgregarHistoria_Click(object sender, EventArgs e)
        {
            abrirForm(new frmAgregarHistoria2());
        }

        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            abrirForm(new frmHistorial());
        }

        private void BtnCrearReporte_Click(object sender, EventArgs e)
        {
            abrirForm(new frmReporte());
        }

        private void BtnCredito_Click(object sender, EventArgs e)
        {
            abrirForm(new frmCreditos());
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //frmLogin login = new frmLogin();
            //login.ShowDialog();
            this.Close();
        }
    }
}