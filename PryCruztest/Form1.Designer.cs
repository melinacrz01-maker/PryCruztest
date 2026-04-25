namespace PryCruztest
{
    partial class Frminicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frminicio));
            this.lbliniciar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbliniciar
            // 
            this.lbliniciar.AutoSize = true;
            this.lbliniciar.BackColor = System.Drawing.Color.LightCyan;
            this.lbliniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbliniciar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbliniciar.Location = new System.Drawing.Point(120, 198);
            this.lbliniciar.Name = "lbliniciar";
            this.lbliniciar.Size = new System.Drawing.Size(76, 20);
            this.lbliniciar.TabIndex = 0;
            this.lbliniciar.Text = "INICIAR";
            this.lbliniciar.Click += new System.EventHandler(this.lbliniciar_Click);
            // 
            // Frminicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PryCruztest.Properties.Resources.c75e54b49c78217df0c8f5898a76cea7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(310, 247);
            this.Controls.Add(this.lbliniciar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frminicio";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbliniciar;
    }
}

