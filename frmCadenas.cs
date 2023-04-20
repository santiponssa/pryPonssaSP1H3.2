using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPonssaSP1H3._2
{
    public partial class frmCadenas : Form
    {
        public frmCadenas()
        {
            InitializeComponent();
        }
        public string varTextoA;
        private void txtTextoA_TextChanged(object sender, EventArgs e)
        {  
            //Contar la cantidad de caracteres
            varTextoA = txtTextoA.Text;
            lblCantidadA.Text = varTextoA.Length.ToString();
        }

        private void txtTextoB_TextChanged(object sender, EventArgs e)
        {   
            varTextoA
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            txtTextoB.Visible = true;
        }
    }
}
