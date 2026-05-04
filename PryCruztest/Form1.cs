using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryCruztest
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        
        private void lbliniciar_Click(object sender, EventArgs e)
        {
            var ventana = new frmcargadeproductos();
            ventana.ShowDialog();
        }
    }
}
