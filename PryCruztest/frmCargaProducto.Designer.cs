namespace pryManasseroTest
{
    partial class frmCargaProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargaProducto));
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.lbRegistroIG = new System.Windows.Forms.Label();
            this.grpOpciones = new System.Windows.Forms.GroupBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.grpAdiconal = new System.Windows.Forms.GroupBox();
            this.cbEnvío = new System.Windows.Forms.CheckBox();
            this.cbInstalación = new System.Windows.Forms.CheckBox();
            this.cbGarantía = new System.Windows.Forms.CheckBox();
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.rdbEquipo = new System.Windows.Forms.RadioButton();
            this.rdbRepuesto = new System.Windows.Forms.RadioButton();
            this.cmbProductoRegistrado = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.pPrincipal.SuspendLayout();
            this.grpOpciones.SuspendLayout();
            this.grpAdiconal.SuspendLayout();
            this.grpTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Navy;
            this.lblNombre.Location = new System.Drawing.Point(15, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Navy;
            this.btnRegistrar.Location = new System.Drawing.Point(261, 13);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            this.btnRegistrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnRegistrar_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(79, 15);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(169, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // cmbProducto
            // 
            this.cmbProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(143, 62);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(121, 21);
            this.cmbProducto.TabIndex = 2;
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(15, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Lista de productos";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.Navy;
            this.btnSiguiente.Location = new System.Drawing.Point(270, 58);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(87, 25);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // pPrincipal
            // 
            this.pPrincipal.Controls.Add(this.lbRegistroIG);
            this.pPrincipal.Controls.Add(this.btnSiguiente);
            this.pPrincipal.Controls.Add(this.cmbProducto);
            this.pPrincipal.Controls.Add(this.btnRegistrar);
            this.pPrincipal.Controls.Add(this.lblNombre);
            this.pPrincipal.Controls.Add(this.label1);
            this.pPrincipal.Controls.Add(this.txtNombre);
            this.pPrincipal.ForeColor = System.Drawing.Color.Navy;
            this.pPrincipal.Location = new System.Drawing.Point(15, 27);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(363, 108);
            this.pPrincipal.TabIndex = 6;
            this.pPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbRegistroIG
            // 
            this.lbRegistroIG.AutoSize = true;
            this.lbRegistroIG.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistroIG.Location = new System.Drawing.Point(19, 159);
            this.lbRegistroIG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRegistroIG.Name = "lbRegistroIG";
            this.lbRegistroIG.Size = new System.Drawing.Size(13, 17);
            this.lbRegistroIG.TabIndex = 6;
            this.lbRegistroIG.Text = "-";
            // 
            // grpOpciones
            // 
            this.grpOpciones.BackColor = System.Drawing.Color.DarkGray;
            this.grpOpciones.Controls.Add(this.btnFinalizar);
            this.grpOpciones.Controls.Add(this.grpAdiconal);
            this.grpOpciones.Controls.Add(this.grpTipo);
            this.grpOpciones.Controls.Add(this.cmbProductoRegistrado);
            this.grpOpciones.Controls.Add(this.lblProducto);
            this.grpOpciones.ForeColor = System.Drawing.Color.Navy;
            this.grpOpciones.Location = new System.Drawing.Point(15, 27);
            this.grpOpciones.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpOpciones.Name = "grpOpciones";
            this.grpOpciones.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpOpciones.Size = new System.Drawing.Size(361, 300);
            this.grpOpciones.TabIndex = 0;
            this.grpOpciones.TabStop = false;
            this.grpOpciones.Text = "-";
            this.grpOpciones.Visible = false;
            this.grpOpciones.Enter += new System.EventHandler(this.grpOpciones_Enter);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.Location = new System.Drawing.Point(236, 267);
            this.btnFinalizar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(81, 22);
            this.btnFinalizar.TabIndex = 11;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // grpAdiconal
            // 
            this.grpAdiconal.BackColor = System.Drawing.Color.White;
            this.grpAdiconal.Controls.Add(this.cbEnvío);
            this.grpAdiconal.Controls.Add(this.cbInstalación);
            this.grpAdiconal.Controls.Add(this.cbGarantía);
            this.grpAdiconal.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAdiconal.Location = new System.Drawing.Point(56, 164);
            this.grpAdiconal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAdiconal.Name = "grpAdiconal";
            this.grpAdiconal.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAdiconal.Size = new System.Drawing.Size(261, 91);
            this.grpAdiconal.TabIndex = 10;
            this.grpAdiconal.TabStop = false;
            this.grpAdiconal.Text = "Adicional";
            // 
            // cbEnvío
            // 
            this.cbEnvío.AutoSize = true;
            this.cbEnvío.BackColor = System.Drawing.Color.White;
            this.cbEnvío.Location = new System.Drawing.Point(13, 54);
            this.cbEnvío.Name = "cbEnvío";
            this.cbEnvío.Size = new System.Drawing.Size(61, 21);
            this.cbEnvío.TabIndex = 11;
            this.cbEnvío.Text = "Envío";
            this.cbEnvío.UseVisualStyleBackColor = false;
            // 
            // cbInstalación
            // 
            this.cbInstalación.AutoSize = true;
            this.cbInstalación.BackColor = System.Drawing.Color.White;
            this.cbInstalación.Location = new System.Drawing.Point(13, 27);
            this.cbInstalación.Name = "cbInstalación";
            this.cbInstalación.Size = new System.Drawing.Size(94, 21);
            this.cbInstalación.TabIndex = 10;
            this.cbInstalación.Text = "Instalación";
            this.cbInstalación.UseVisualStyleBackColor = false;
            this.cbInstalación.CheckedChanged += new System.EventHandler(this.cbInstalación_CheckedChanged);
            // 
            // cbGarantía
            // 
            this.cbGarantía.AutoSize = true;
            this.cbGarantía.BackColor = System.Drawing.Color.White;
            this.cbGarantía.ForeColor = System.Drawing.Color.Navy;
            this.cbGarantía.Location = new System.Drawing.Point(137, 27);
            this.cbGarantía.Name = "cbGarantía";
            this.cbGarantía.Size = new System.Drawing.Size(79, 21);
            this.cbGarantía.TabIndex = 9;
            this.cbGarantía.Text = "Garantía";
            this.cbGarantía.UseVisualStyleBackColor = false;
            // 
            // grpTipo
            // 
            this.grpTipo.BackColor = System.Drawing.Color.White;
            this.grpTipo.Controls.Add(this.rdbEquipo);
            this.grpTipo.Controls.Add(this.rdbRepuesto);
            this.grpTipo.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTipo.Location = new System.Drawing.Point(56, 80);
            this.grpTipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpTipo.Size = new System.Drawing.Size(257, 65);
            this.grpTipo.TabIndex = 9;
            this.grpTipo.TabStop = false;
            this.grpTipo.Text = "Tipo";
            // 
            // rdbEquipo
            // 
            this.rdbEquipo.AutoSize = true;
            this.rdbEquipo.BackColor = System.Drawing.Color.White;
            this.rdbEquipo.Location = new System.Drawing.Point(137, 27);
            this.rdbEquipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbEquipo.Name = "rdbEquipo";
            this.rdbEquipo.Size = new System.Drawing.Size(69, 21);
            this.rdbEquipo.TabIndex = 2;
            this.rdbEquipo.TabStop = true;
            this.rdbEquipo.Text = "Equipo";
            this.rdbEquipo.UseVisualStyleBackColor = false;
            // 
            // rdbRepuesto
            // 
            this.rdbRepuesto.AutoSize = true;
            this.rdbRepuesto.BackColor = System.Drawing.Color.White;
            this.rdbRepuesto.Location = new System.Drawing.Point(33, 27);
            this.rdbRepuesto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdbRepuesto.Name = "rdbRepuesto";
            this.rdbRepuesto.Size = new System.Drawing.Size(83, 21);
            this.rdbRepuesto.TabIndex = 7;
            this.rdbRepuesto.TabStop = true;
            this.rdbRepuesto.Text = "Repuesto";
            this.rdbRepuesto.UseVisualStyleBackColor = false;
            // 
            // cmbProductoRegistrado
            // 
            this.cmbProductoRegistrado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductoRegistrado.FormattingEnabled = true;
            this.cmbProductoRegistrado.Location = new System.Drawing.Point(148, 32);
            this.cmbProductoRegistrado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbProductoRegistrado.Name = "cmbProductoRegistrado";
            this.cmbProductoRegistrado.Size = new System.Drawing.Size(95, 21);
            this.cmbProductoRegistrado.TabIndex = 6;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.BackColor = System.Drawing.Color.White;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.ForeColor = System.Drawing.Color.Navy;
            this.lblProducto.Location = new System.Drawing.Point(53, 34);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(64, 17);
            this.lblProducto.TabIndex = 0;
            this.lblProducto.Text = "Producto";
            // 
            // frmCargaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(392, 339);
            this.Controls.Add(this.grpOpciones);
            this.Controls.Add(this.pPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCargaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carga de Productos";
            this.Load += new System.EventHandler(this.frmCargaProducto_Load);
            this.pPrincipal.ResumeLayout(false);
            this.pPrincipal.PerformLayout();
            this.grpOpciones.ResumeLayout(false);
            this.grpOpciones.PerformLayout();
            this.grpAdiconal.ResumeLayout(false);
            this.grpAdiconal.PerformLayout();
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.GroupBox grpOpciones;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.RadioButton rdbRepuesto;
        private System.Windows.Forms.ComboBox cmbProductoRegistrado;
        private System.Windows.Forms.GroupBox grpAdiconal;
        private System.Windows.Forms.RadioButton rdbEquipo;
        private System.Windows.Forms.Label lbRegistroIG;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.CheckBox cbGarantía;
        private System.Windows.Forms.CheckBox cbEnvío;
        private System.Windows.Forms.CheckBox cbInstalación;
    }
}