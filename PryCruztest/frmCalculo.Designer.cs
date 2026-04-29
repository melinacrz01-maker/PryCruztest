namespace pryManasseroTest
{
    partial class frmCalculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculo));
            this.lblConsignas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblConsignas
            // 
            this.lblConsignas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsignas.Location = new System.Drawing.Point(8, 6);
            this.lblConsignas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblConsignas.Name = "lblConsignas";
            this.lblConsignas.Size = new System.Drawing.Size(517, 281);
            this.lblConsignas.TabIndex = 0;
            this.lblConsignas.Text = resources.GetString("lblConsignas.Text");
            this.lblConsignas.Click += new System.EventHandler(this.lblConsignas_Click);
            // 
            // frmCalculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.lblConsignas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmCalculo";
            this.Text = "frmCalculo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblConsignas;
    }
}