using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_simple
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            
            txtBoxUsuario.Clear();
            txtBoxClave.Clear();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if(txtBoxUsuario.Text == "user" && txtBoxClave.Text == "admin")
            {
                FrmInicio frmInicio = new FrmInicio();
                this.Hide();
                frmInicio.Show();
                
            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos");
                txtBoxUsuario.Clear();
                txtBoxClave.Clear();
            }
        }
    } 
}
