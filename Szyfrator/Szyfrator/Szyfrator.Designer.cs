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
            this.klucz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtin
            // 
            this.txtin.Location = new System.Drawing.Point(12, 63);
            this.txtin.Name = "txtin";
            this.txtin.Size = new System.Drawing.Size(341, 20);
            this.txtin.TabIndex = 0;
            // 
            // txtout
            // 
            this.txtout.Location = new System.Drawing.Point(11, 118);
            this.txtout.Name = "txtout";
            this.txtout.Size = new System.Drawing.Size(341, 20);
            this.txtout.TabIndex = 1;
            // 
            // btnKoduj
            // 
            this.btnKoduj.Location = new System.Drawing.Point(12, 89);
            this.btnKoduj.Name = "btnKoduj";
            this.btnKoduj.Size = new System.Drawing.Size(126, 23);
            this.btnKoduj.TabIndex = 2;
            this.btnKoduj.Text = "Koduj";
            this.btnKoduj.UseVisualStyleBackColor = true;
            this.btnKoduj.Click += new System.EventHandler(this.btnKoduj_Click);
            // 
            // btnDekoduj
            // 
            this.btnDekoduj.Location = new System.Drawing.Point(227, 89);
            this.btnDekoduj.Name = "btnDekoduj";
            this.btnDekoduj.Size = new System.Drawing.Size(126, 23);
            this.btnDekoduj.TabIndex = 3;
            this.btnDekoduj.Text = "Dekoduj";
            this.btnDekoduj.UseVisualStyleBackColor = true;
            this.btnDekoduj.Click += new System.EventHandler(this.btnDekoduj_Click);
            // 
            // klucz
            // 
            this.klucz.Location = new System.Drawing.Point(12, 26);
            this.klucz.Name = "klucz";
            this.klucz.Size = new System.Drawing.Size(340, 20);
            this.klucz.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Klucz szyfrujący";
            // 
            // Szyfrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 148);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.klucz);
            this.Controls.Add(this.btnDekoduj);
            this.Controls.Add(this.btnKoduj);
            this.Controls.Add(this.txtout);
            this.Controls.Add(this.txtin);
            this.Name = "Szyfrator";
            this.Text = "Szyfrator";
            this.Load += new System.EventHandler(this.Szyfrator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtin;
        private System.Windows.Forms.TextBox txtout;
        private System.Windows.Forms.Button btnKoduj;
        private System.Windows.Forms.Button btnDekoduj;
        private System.Windows.Forms.TextBox klucz;
        private System.Windows.Forms.Label label1;
    }
}

