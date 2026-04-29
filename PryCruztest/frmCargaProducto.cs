using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryManasseroTest
{
    public partial class frmCargaProducto : Form
    {
        public frmCargaProducto()
        {
            InitializeComponent();
        }

        private void frmCargaProducto_Load(object sender, EventArgs e)
        {

        }


        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese su nombre", "Gestión de productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);           
                txtNombre.Focus();
            }

            else
            {
                cmbProducto.Items.Add((string)txtNombre.Text);
                cmbProductoRegistrado.Items.Add((string)txtNombre.Text);
                MessageBox.Show("Producto registrado con éxito", "Gestión de productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } 

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
           
            if (cmbProducto.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un producto", "Gestión de productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cmbProducto.Focus();
            }

            if (txtNombre.Text != "" && cmbProducto.SelectedIndex != -1)
            {
                grpOpciones.Visible = true;
            }
            lbRegistroIG.Text =  
                " - Nombre: " + txtNombre.Text + " - Producto: " + cmbProducto.Text;

            pPrincipal.Visible = false;
            grpOpciones.Visible = true;

            this.Size = new Size(400, 386);
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (rdbRepuesto.Checked || rdbEquipo.Checked)
            {
                string adicionales = "";

                if (cbInstalación.Checked == true) adicionales += "Instalación ";
                if (cbEnvío.Checked) adicionales += "Envío ";
                if (cbGarantía.Checked) adicionales += "Garantía ";

                MessageBox.Show("Carga completa\nAdicionales: " + adicionales);
            }
            else
            {
                MessageBox.Show("Seleccione un tipo", "Gestión de productos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void btnRegistrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))

            {
                cmbProducto.Items.Add((string)txtNombre.Text);
                cmbProductoRegistrado.Items.Add(txtNombre.Text);
                MessageBox.Show("Nombre de producto registrado con éxito","Gestión de productos", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

                txtNombre.Text = "";
                txtNombre.Focus();
            }
        }

        private void rdbGarantía_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbInstalación_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void grpOpciones_Enter(object sender, EventArgs e)
        {

        }
    }
}
