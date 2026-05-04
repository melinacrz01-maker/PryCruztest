using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Por favor nombre del Producto.", "Producto Registrado",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtNombre.Focus();
            }
            else
            {
                cmbListaProducto.Items.Add(txtNombre.Text);
                cmbProducte.Items.Add(txtNombre.Text);
                MessageBox.Show("Nombre registrado correctamente.");
                txtNombre.Text ="";
                txtNombre.Focus();
            }
        }
                
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbBoxlista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void grbDatos_Enter(object sender, EventArgs e)
        {

        }

        private void cmbProducte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            grbDatos.Visible = false;
            grbProductos.Visible = true;
        }

        private void grbProductos_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            int costoequipo = 1000000;
            int Costorespuesto = 350000;
            double costoinstalacion = 0.15;
            double costoenvio = 0.05;
            double costogarantia = 0.20;

            double costobase = 0;

            string producto="";

            if (cmbProducte.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                producto = cmbProducte.SelectedItem.ToString();

                string tipo = "(no seleccionado)";

                if (rdbRemoto.Checked)
                {

                    tipo = "Remoto";
                    costobase = Costorespuesto;

                }
                else if (rdbEquipo.Checked)
                {
                    tipo = "Equipo";
                    costobase = costoequipo;

                }

                string adicional = "";

                if (chkinstalacion.Checked)
                {
                    adicional += "Instalación, ";
                    costobase = costobase + (costobase * costoinstalacion);
                }

                if (chkEnvio.Checked)
                {
                    adicional += "Envío ";
                    costobase = costobase + (costobase * costoenvio);
                }

                if (chkGarantia.Checked)
                {
                    adicional += "Garantía, ";
                    costobase = costobase + (costobase * costogarantia);
                }

                if (adicional == "") adicional = "(ninguno)";
                else adicional = adicional.TrimEnd(',', ' ');

                string mensaje = "Datos cargados:\n\n"
                               + "Producto: " + producto + "\n"
                               + "Tipo: " + tipo + "\n"
                               + "Adicional: " + adicional + "\n"
                               + "Costo Total: " + costobase;

                MessageBox.Show(mensaje, "Producto Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

        }

        private void rdbRemoto_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
