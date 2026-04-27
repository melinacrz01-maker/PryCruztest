namespace PryCruztest
{
    partial class frmcargadeproductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmcargadeproductos));
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblLista = new System.Windows.Forms.Label();
            this.cmbListaProducto = new System.Windows.Forms.ComboBox();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.grbProductos = new System.Windows.Forms.GroupBox();
            this.rdbRemoto = new System.Windows.Forms.RadioButton();
            this.rdbEquipo = new System.Windows.Forms.RadioButton();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblAdicional = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbProducte = new System.Windows.Forms.ComboBox();
            this.lblProductos = new System.Windows.Forms.Label();
            this.grbDatos = new System.Windows.Forms.GroupBox();
            this.btnfinalizar = new System.Windows.Forms.Button();
            this.grbProductos.SuspendLayout();
            this.grbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblNombre.Location = new System.Drawing.Point(6, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(61, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(73, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(146, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(239, 23);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(113, 27);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblLista.Location = new System.Drawing.Point(24, 79);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(41, 16);
            this.lblLista.TabIndex = 3;
            this.lblLista.Text = "Lista:";
            // 
            // cmbListaProducto
            // 
            this.cmbListaProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListaProducto.FormattingEnabled = true;
            this.cmbListaProducto.Location = new System.Drawing.Point(73, 74);
            this.cmbListaProducto.Name = "cmbListaProducto";
            this.cmbListaProducto.Size = new System.Drawing.Size(146, 21);
            this.cmbListaProducto.TabIndex = 4;
            this.cmbListaProducto.SelectedIndexChanged += new System.EventHandler(this.cmbBoxlista_SelectedIndexChanged);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSiguiente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(239, 70);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(113, 27);
            this.btnSiguiente.TabIndex = 5;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // grbProductos
            // 
            this.grbProductos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.grbProductos.BackgroundImage = global::PryCruztest.Properties.Resources.light_blue_background_gradient_wall_design_vector;
            this.grbProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grbProductos.Controls.Add(this.btnfinalizar);
            this.grbProductos.Controls.Add(this.rdbRemoto);
            this.grbProductos.Controls.Add(this.rdbEquipo);
            this.grbProductos.Controls.Add(this.checkBox3);
            this.grbProductos.Controls.Add(this.checkBox2);
            this.grbProductos.Controls.Add(this.checkBox1);
            this.grbProductos.Controls.Add(this.lblAdicional);
            this.grbProductos.Controls.Add(this.lblTipo);
            this.grbProductos.Controls.Add(this.cmbProducte);
            this.grbProductos.Controls.Add(this.lblProductos);
            this.grbProductos.Location = new System.Drawing.Point(12, 148);
            this.grbProductos.Name = "grbProductos";
            this.grbProductos.Size = new System.Drawing.Size(368, 253);
            this.grbProductos.TabIndex = 6;
            this.grbProductos.TabStop = false;
            this.grbProductos.Text = "Carga de Productos";
            this.grbProductos.Visible = false;
            this.grbProductos.Enter += new System.EventHandler(this.grbProductos_Enter);
            // 
            // rdbRemoto
            // 
            this.rdbRemoto.AutoSize = true;
            this.rdbRemoto.BackColor = System.Drawing.Color.Transparent;
            this.rdbRemoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbRemoto.Location = new System.Drawing.Point(185, 85);
            this.rdbRemoto.Name = "rdbRemoto";
            this.rdbRemoto.Size = new System.Drawing.Size(75, 19);
            this.rdbRemoto.TabIndex = 16;
            this.rdbRemoto.TabStop = true;
            this.rdbRemoto.Text = "Remoto";
            this.rdbRemoto.UseVisualStyleBackColor = false;
            // 
            // rdbEquipo
            // 
            this.rdbEquipo.AutoSize = true;
            this.rdbEquipo.BackColor = System.Drawing.Color.Transparent;
            this.rdbEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbEquipo.Location = new System.Drawing.Point(92, 83);
            this.rdbEquipo.Name = "rdbEquipo";
            this.rdbEquipo.Size = new System.Drawing.Size(70, 19);
            this.rdbEquipo.TabIndex = 15;
            this.rdbEquipo.TabStop = true;
            this.rdbEquipo.Text = "Equipo";
            this.rdbEquipo.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackColor = System.Drawing.Color.Transparent;
            this.checkBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(92, 175);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(81, 20);
            this.checkBox3.TabIndex = 13;
            this.checkBox3.Text = "Garantia";
            this.checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.Transparent;
            this.checkBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(92, 149);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(61, 20);
            this.checkBox2.TabIndex = 12;
            this.checkBox2.Text = "Envio";
            this.checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.checkBox1.Location = new System.Drawing.Point(92, 123);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(97, 20);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Inatalación";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // lblAdicional
            // 
            this.lblAdicional.AutoSize = true;
            this.lblAdicional.BackColor = System.Drawing.Color.Transparent;
            this.lblAdicional.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdicional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblAdicional.Location = new System.Drawing.Point(6, 125);
            this.lblAdicional.Name = "lblAdicional";
            this.lblAdicional.Size = new System.Drawing.Size(72, 18);
            this.lblAdicional.TabIndex = 10;
            this.lblAdicional.Text = "Adicional";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.Transparent;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblTipo.Location = new System.Drawing.Point(26, 85);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 16);
            this.lblTipo.TabIndex = 7;
            this.lblTipo.Text = "Tipo";
            // 
            // cmbProducte
            // 
            this.cmbProducte.FormattingEnabled = true;
            this.cmbProducte.Location = new System.Drawing.Point(92, 40);
            this.cmbProducte.Name = "cmbProducte";
            this.cmbProducte.Size = new System.Drawing.Size(168, 21);
            this.cmbProducte.TabIndex = 1;
            this.cmbProducte.SelectedIndexChanged += new System.EventHandler(this.cmbProducte_SelectedIndexChanged);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.BackColor = System.Drawing.Color.Transparent;
            this.lblProductos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductos.Location = new System.Drawing.Point(8, 45);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(70, 16);
            this.lblProductos.TabIndex = 0;
            this.lblProductos.Text = "Productos";
            // 
            // grbDatos
            // 
            this.grbDatos.BackColor = System.Drawing.Color.MintCream;
            this.grbDatos.Controls.Add(this.lblNombre);
            this.grbDatos.Controls.Add(this.btnRegistrar);
            this.grbDatos.Controls.Add(this.btnSiguiente);
            this.grbDatos.Controls.Add(this.txtNombre);
            this.grbDatos.Controls.Add(this.cmbListaProducto);
            this.grbDatos.Controls.Add(this.lblLista);
            this.grbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDatos.Location = new System.Drawing.Point(12, 24);
            this.grbDatos.Name = "grbDatos";
            this.grbDatos.Size = new System.Drawing.Size(368, 118);
            this.grbDatos.TabIndex = 15;
            this.grbDatos.TabStop = false;
            this.grbDatos.Text = "Datos";
            this.grbDatos.Enter += new System.EventHandler(this.grbDatos_Enter);
            // 
            // btnfinalizar
            // 
            this.btnfinalizar.BackColor = System.Drawing.SystemColors.Window;
            this.btnfinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfinalizar.Location = new System.Drawing.Point(211, 205);
            this.btnfinalizar.Name = "btnfinalizar";
            this.btnfinalizar.Size = new System.Drawing.Size(117, 28);
            this.btnfinalizar.TabIndex = 17;
            this.btnfinalizar.Text = "Finalizar";
            this.btnfinalizar.UseVisualStyleBackColor = false;
            // 
            // frmcargadeproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(433, 425);
            this.Controls.Add(this.grbProductos);
            this.Controls.Add(this.grbDatos);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmcargadeproductos";
            this.Text = "Frmcargadeproductos";
            this.Load += new System.EventHandler(this.frmcargadeproductos_Load);
            this.grbProductos.ResumeLayout(false);
            this.grbProductos.PerformLayout();
            this.grbDatos.ResumeLayout(false);
            this.grbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.ComboBox cmbListaProducto;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.GroupBox grbProductos;
        private System.Windows.Forms.ComboBox cmbProducte;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblAdicional;
        private System.Windows.Forms.GroupBox grbDatos;
        private System.Windows.Forms.RadioButton rdbRemoto;
        private System.Windows.Forms.RadioButton rdbEquipo;
        private System.Windows.Forms.Button btnfinalizar;
    }
}