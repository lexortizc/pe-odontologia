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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal menu = new frmMenuPrincipal();
            menu.Show();
            this.Close();
        }

        private void Usuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }

        }

        private void Clave_Enter(object sender, EventArgs e)
        {
            if (txtClave.Text == "password")
            {
                txtClave.Text = "";
                txtClave.ForeColor = Color.Black;
            }

        }

        private void Usuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DimGray;
            }

        }

        private void Clave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text == "")
            {
                txtClave.Text = "password";
                txtClave.ForeColor = Color.DimGray;
            }

        }
    }
}
