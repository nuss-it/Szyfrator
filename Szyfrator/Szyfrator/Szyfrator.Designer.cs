namespace Szyfrator
{
    partial class Szyfrator
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtin = new System.Windows.Forms.TextBox();
            this.txtout = new System.Windows.Forms.TextBox();
            this.btnKoduj = new System.Windows.Forms.Button();
            this.btnDekoduj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtin
            // 
            this.txtin.Location = new System.Drawing.Point(12, 12);
            this.txtin.Name = "txtin";
            this.txtin.Size = new System.Drawing.Size(341, 20);
            this.txtin.TabIndex = 0;
            // 
            // txtout
            // 
            this.txtout.Location = new System.Drawing.Point(12, 91);
            this.txtout.Name = "txtout";
            this.txtout.Size = new System.Drawing.Size(341, 20);
            this.txtout.TabIndex = 1;
            this.txtout.TextChanged += new System.EventHandler(this.txtout_TextChanged);
            // 
            // btnKoduj
            // 
            this.btnKoduj.Location = new System.Drawing.Point(12, 49);
            this.btnKoduj.Name = "btnKoduj";
            this.btnKoduj.Size = new System.Drawing.Size(126, 23);
            this.btnKoduj.TabIndex = 2;
            this.btnKoduj.Text = "Koduj";
            this.btnKoduj.UseVisualStyleBackColor = true;
            // 
            // btnDekoduj
            // 
            this.btnDekoduj.Location = new System.Drawing.Point(227, 49);
            this.btnDekoduj.Name = "btnDekoduj";
            this.btnDekoduj.Size = new System.Drawing.Size(126, 23);
            this.btnDekoduj.TabIndex = 3;
            this.btnDekoduj.Text = "Dekoduj";
            this.btnDekoduj.UseVisualStyleBackColor = true;
            // 
            // Szyfrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 129);
            this.Controls.Add(this.btnDekoduj);
            this.Controls.Add(this.btnKoduj);
            this.Controls.Add(this.txtout);
            this.Controls.Add(this.txtin);
            this.Name = "Szyfrator";
            this.Text = "Szyfrator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtin;
        private System.Windows.Forms.TextBox txtout;
        private System.Windows.Forms.Button btnKoduj;
        private System.Windows.Forms.Button btnDekoduj;
    }
}

