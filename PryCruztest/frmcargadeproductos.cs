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
    public partial class frmcargadeproductos : Form
    {
        public frmcargadeproductos()
        {
            InitializeComponent();
        }

        private void frmcargadeproductos_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Por favor nombre del Producto.");
                return;
            }

            if (cmbBoxlista.Items.Contains(nombre))
            {
                MessageBox.Show("El producto \"" + nombre + "\" ya está en la lista.");
                return;
            }

            cmbBoxlista.Items.Add(nombre);
            txtNombre.Clear();
            txtNombre.Focus();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxlista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
