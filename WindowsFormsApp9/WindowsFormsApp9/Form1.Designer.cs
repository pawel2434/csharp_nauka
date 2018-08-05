namespace WindowsFormsApp9
{
    partial class Form1
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
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.b0 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.bod = new System.Windows.Forms.Button();
            this.bdod = new System.Windows.Forms.Button();
            this.bdzie = new System.Windows.Forms.Button();
            this.bmno = new System.Windows.Forms.Button();
            this.bsum = new System.Windows.Forms.Button();
            this.bkropka = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(760, 75);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(95, 579);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(75, 75);
            this.b0.TabIndex = 1;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.OnSetNumber);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(12, 497);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 75);
            this.b1.TabIndex = 2;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.OnSetNumber);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(95, 497);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 75);
            this.b2.TabIndex = 3;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.OnSetNumber);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(176, 497);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 75);
            this.b3.TabIndex = 4;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.OnSetNumber);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(12, 416);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(75, 75);
            this.b4.TabIndex = 5;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.OnSetNumber);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(95, 416);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(75, 75);
            this.b5.TabIndex = 6;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.OnSetNumber);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(176, 416);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(75, 75);
            this.b6.TabIndex = 7;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.OnSetNumber);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(12, 335);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(75, 75);
            this.b7.TabIndex = 8;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.OnSetNumber);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(95, 335);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(75, 75);
            this.b8.TabIndex = 9;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.OnSetNumber);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(176, 335);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(75, 75);
            this.b9.TabIndex = 10;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.OnSetNumber);
            // 
            // bC
            // 
            this.bC.Location = new System.Drawing.Point(350, 335);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(75, 75);
            this.bC.TabIndex = 11;
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = true;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // bod
            // 
            this.bod.Location = new System.Drawing.Point(350, 497);
            this.bod.Name = "bod";
            this.bod.Size = new System.Drawing.Size(75, 75);
            this.bod.TabIndex = 12;
            this.bod.Text = "-";
            this.bod.UseVisualStyleBackColor = true;
            this.bod.Click += new System.EventHandler(this.bod_Click);
            // 
            // bdod
            // 
            this.bdod.Location = new System.Drawing.Point(350, 416);
            this.bdod.Name = "bdod";
            this.bdod.Size = new System.Drawing.Size(75, 75);
            this.bdod.TabIndex = 13;
            this.bdod.Text = "+";
            this.bdod.UseVisualStyleBackColor = true;
            this.bdod.Click += new System.EventHandler(this.bdod_Click);
            // 
            // bdzie
            // 
            this.bdzie.Location = new System.Drawing.Point(441, 497);
            this.bdzie.Name = "bdzie";
            this.bdzie.Size = new System.Drawing.Size(75, 75);
            this.bdzie.TabIndex = 14;
            this.bdzie.Text = "/";
            this.bdzie.UseVisualStyleBackColor = true;
            this.bdzie.Click += new System.EventHandler(this.bdzie_Click);
            // 
            // bmno
            // 
            this.bmno.Location = new System.Drawing.Point(441, 416);
            this.bmno.Name = "bmno";
            this.bmno.Size = new System.Drawing.Size(75, 75);
            this.bmno.TabIndex = 15;
            this.bmno.Text = "*";
            this.bmno.UseVisualStyleBackColor = true;
            this.bmno.Click += new System.EventHandler(this.bmno_Click);
            // 
            // bsum
            // 
            this.bsum.Location = new System.Drawing.Point(350, 579);
            this.bsum.Name = "bsum";
            this.bsum.Size = new System.Drawing.Size(166, 75);
            this.bsum.TabIndex = 16;
            this.bsum.Text = "=";
            this.bsum.UseVisualStyleBackColor = true;
            this.bsum.Click += new System.EventHandler(this.bsum_Click);
            // 
            // bkropka
            // 
            this.bkropka.Location = new System.Drawing.Point(12, 579);
            this.bkropka.Name = "bkropka";
            this.bkropka.Size = new System.Drawing.Size(75, 75);
            this.bkropka.TabIndex = 17;
            this.bkropka.Text = ".";
            this.bkropka.UseVisualStyleBackColor = true;
            this.bkropka.Click += new System.EventHandler(this.OnSetNumber);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(784, 762);
            this.Controls.Add(this.bkropka);
            this.Controls.Add(this.bsum);
            this.Controls.Add(this.bmno);
            this.Controls.Add(this.bdzie);
            this.Controls.Add(this.bdod);
            this.Controls.Add(this.bod);
            this.Controls.Add(this.bC);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Calkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button bod;
        private System.Windows.Forms.Button bdod;
        private System.Windows.Forms.Button bdzie;
        private System.Windows.Forms.Button bmno;
        private System.Windows.Forms.Button bsum;
        private System.Windows.Forms.Button bkropka;
    }
}

