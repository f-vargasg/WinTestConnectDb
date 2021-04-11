
namespace WinTestConnectDb
{
    partial class FrmPrincTestDb
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TestConnBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TestConnBut
            // 
            this.TestConnBut.Location = new System.Drawing.Point(255, 101);
            this.TestConnBut.Name = "TestConnBut";
            this.TestConnBut.Size = new System.Drawing.Size(261, 70);
            this.TestConnBut.TabIndex = 0;
            this.TestConnBut.Text = "Test ConnectDb";
            this.TestConnBut.UseVisualStyleBackColor = true;
            this.TestConnBut.Click += new System.EventHandler(this.TestConnBut_Click);
            // 
            // FrmPrincTestDb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 426);
            this.Controls.Add(this.TestConnBut);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmPrincTestDb";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TestConnBut;
    }
}

