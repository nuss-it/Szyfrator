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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // txtin
            // 
            this.txtin.Location = new System.Drawing.Point(12, 71);
            this.txtin.Name = "txtin";
            this.txtin.Size = new System.Drawing.Size(341, 20);
            this.txtin.TabIndex = 2;
            // 
            // txtout
            // 
            this.txtout.Location = new System.Drawing.Point(12, 136);
            this.txtout.Name = "txtout";
            this.txtout.Size = new System.Drawing.Size(341, 20);
            this.txtout.TabIndex = 5;
            // 
            // btnKoduj
            // 
            this.btnKoduj.Location = new System.Drawing.Point(12, 97);
            this.btnKoduj.Name = "btnKoduj";
            this.btnKoduj.Size = new System.Drawing.Size(126, 23);
            this.btnKoduj.TabIndex = 3;
            this.btnKoduj.Text = "Koduj";
            this.btnKoduj.UseVisualStyleBackColor = true;
            this.btnKoduj.Click += new System.EventHandler(this.btnKoduj_Click);
            // 
            // btnDekoduj
            // 
            this.btnDekoduj.Location = new System.Drawing.Point(227, 97);
            this.btnDekoduj.Name = "btnDekoduj";
            this.btnDekoduj.Size = new System.Drawing.Size(126, 23);
            this.btnDekoduj.TabIndex = 4;
            this.btnDekoduj.Text = "Dekoduj";
            this.btnDekoduj.UseVisualStyleBackColor = true;
            this.btnDekoduj.Click += new System.EventHandler(this.btnDekoduj_Click);
            // 
            // klucz
            // 
            this.klucz.Location = new System.Drawing.Point(12, 26);
            this.klucz.Name = "klucz";
            this.klucz.Size = new System.Drawing.Size(340, 20);
            this.klucz.TabIndex = 1;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Zapisz szyfr do pliku";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(227, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Otwórz szyfr z pliku";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // save
            // 
            this.save.DefaultExt = "txt";
            this.save.FileName = "dane.txt";
            this.save.Filter = "\"Pliki TXT|*.txt|Wszystkie pliki|*.*\"";
            this.save.Title = "Zapis hashy";
            // 
            // Szyfrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 214);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog save;
    }
}

