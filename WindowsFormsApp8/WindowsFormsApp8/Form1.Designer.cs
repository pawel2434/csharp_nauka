﻿namespace WindowsFormsApp8
{
    partial class Calkulator
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
            this.tBwynik = new System.Windows.Forms.TextBox();
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
            this.bsumy = new System.Windows.Forms.Button();
            this.bdzielenia = new System.Windows.Forms.Button();
            this.bodejmowania = new System.Windows.Forms.Button();
            this.bdodawania = new System.Windows.Forms.Button();
            this.bmnorzenia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBwynik
            // 
            this.tBwynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tBwynik.Location = new System.Drawing.Point(5, 12);
            this.tBwynik.Name = "tBwynik";
            this.tBwynik.Size = new System.Drawing.Size(783, 38);
            this.tBwynik.TabIndex = 0;
            this.tBwynik.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tBwynik.TextChanged += new System.EventHandler(this.tBwynik_TextChanged);
            // 
            // b0
            // 
            this.b0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b0.Location = new System.Drawing.Point(90, 368);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(70, 70);
            this.b0.TabIndex = 1;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.b0_Click);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b1.Location = new System.Drawing.Point(12, 294);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(70, 70);
            this.b1.TabIndex = 2;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b2.Location = new System.Drawing.Point(90, 294);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(70, 70);
            this.b2.TabIndex = 3;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b3.Location = new System.Drawing.Point(166, 294);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(70, 70);
            this.b3.TabIndex = 4;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b4.Location = new System.Drawing.Point(12, 218);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(70, 70);
            this.b4.TabIndex = 5;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b5.Location = new System.Drawing.Point(90, 218);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(70, 70);
            this.b5.TabIndex = 6;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b6.Location = new System.Drawing.Point(166, 218);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(70, 70);
            this.b6.TabIndex = 7;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b7.Location = new System.Drawing.Point(12, 142);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(70, 70);
            this.b7.TabIndex = 8;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b8.Location = new System.Drawing.Point(90, 142);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(70, 70);
            this.b8.TabIndex = 9;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b9.Location = new System.Drawing.Point(166, 142);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(70, 70);
            this.b9.TabIndex = 10;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // bsumy
            // 
            this.bsumy.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bsumy.Location = new System.Drawing.Point(261, 368);
            this.bsumy.Name = "bsumy";
            this.bsumy.Size = new System.Drawing.Size(146, 70);
            this.bsumy.TabIndex = 11;
            this.bsumy.Text = "=";
            this.bsumy.UseVisualStyleBackColor = true;
            this.bsumy.Click += new System.EventHandler(this.bsumy_Click);
            // 
            // bdzielenia
            // 
            this.bdzielenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bdzielenia.Location = new System.Drawing.Point(337, 294);
            this.bdzielenia.Name = "bdzielenia";
            this.bdzielenia.Size = new System.Drawing.Size(70, 70);
            this.bdzielenia.TabIndex = 12;
            this.bdzielenia.Text = "/";
            this.bdzielenia.UseVisualStyleBackColor = true;
            this.bdzielenia.Click += new System.EventHandler(this.bdzielenia_Click);
            // 
            // bodejmowania
            // 
            this.bodejmowania.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bodejmowania.Location = new System.Drawing.Point(261, 294);
            this.bodejmowania.Name = "bodejmowania";
            this.bodejmowania.Size = new System.Drawing.Size(70, 70);
            this.bodejmowania.TabIndex = 13;
            this.bodejmowania.Text = "-";
            this.bodejmowania.UseVisualStyleBackColor = true;
            this.bodejmowania.Click += new System.EventHandler(this.bodejmowania_Click);
            // 
            // bdodawania
            // 
            this.bdodawania.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bdodawania.Location = new System.Drawing.Point(261, 218);
            this.bdodawania.Name = "bdodawania";
            this.bdodawania.Size = new System.Drawing.Size(70, 70);
            this.bdodawania.TabIndex = 14;
            this.bdodawania.Text = "+";
            this.bdodawania.UseVisualStyleBackColor = true;
            this.bdodawania.Click += new System.EventHandler(this.bdodawania_Click);
            // 
            // bmnorzenia
            // 
            this.bmnorzenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bmnorzenia.Location = new System.Drawing.Point(337, 218);
            this.bmnorzenia.Name = "bmnorzenia";
            this.bmnorzenia.Size = new System.Drawing.Size(70, 70);
            this.bmnorzenia.TabIndex = 15;
            this.bmnorzenia.Text = "*";
            this.bmnorzenia.UseVisualStyleBackColor = true;
            this.bmnorzenia.Click += new System.EventHandler(this.bmnorzenia_Click);
            // 
            // Calkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bmnorzenia);
            this.Controls.Add(this.bdodawania);
            this.Controls.Add(this.bodejmowania);
            this.Controls.Add(this.bdzielenia);
            this.Controls.Add(this.bsumy);
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
            this.Controls.Add(this.tBwynik);
            this.Name = "Calkulator";
            this.Text = "Calkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBwynik;
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
        private System.Windows.Forms.Button bsumy;
        private System.Windows.Forms.Button bdzielenia;
        private System.Windows.Forms.Button bodejmowania;
        private System.Windows.Forms.Button bdodawania;
        private System.Windows.Forms.Button bmnorzenia;
    }
}

