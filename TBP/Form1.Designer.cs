namespace TBP
{
    partial class Form1
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
            this.txtBoxPrijavaKorisnickoIme = new System.Windows.Forms.TextBox();
            this.txtBoxPrijavaLozinka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPrijava = new System.Windows.Forms.GroupBox();
            this.lblRegistracija = new System.Windows.Forms.Label();
            this.btnPrijavi = new System.Windows.Forms.Button();
            this.gbRegistracija = new System.Windows.Forms.GroupBox();
            this.lblPrijava = new System.Windows.Forms.Label();
            this.panelRegistracijaDoktor = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBoxAdresaOrdinacije = new System.Windows.Forms.TextBox();
            this.btnRegistraraj = new System.Windows.Forms.Button();
            this.radioBtnDoktor = new System.Windows.Forms.RadioButton();
            this.panelRegistracijaPacijent = new System.Windows.Forms.Panel();
            this.dateRodenja = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.rbZdravstvenoNe = new System.Windows.Forms.RadioButton();
            this.rbZdravstvenoDa = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.datePredvidenogPoroda = new System.Windows.Forms.DateTimePicker();
            this.dateZadnjeMenstruacije = new System.Windows.Forms.DateTimePicker();
            this.radioBtnPacijent = new System.Windows.Forms.RadioButton();
            this.txtBoxPrezime = new System.Windows.Forms.TextBox();
            this.txtBoxIme = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxKorisnickoIme = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxLozinka = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbPrijava.SuspendLayout();
            this.gbRegistracija.SuspendLayout();
            this.panelRegistracijaDoktor.SuspendLayout();
            this.panelRegistracijaPacijent.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxPrijavaKorisnickoIme
            // 
            this.txtBoxPrijavaKorisnickoIme.Location = new System.Drawing.Point(94, 32);
            this.txtBoxPrijavaKorisnickoIme.Name = "txtBoxPrijavaKorisnickoIme";
            this.txtBoxPrijavaKorisnickoIme.Size = new System.Drawing.Size(140, 20);
            this.txtBoxPrijavaKorisnickoIme.TabIndex = 0;
            // 
            // txtBoxPrijavaLozinka
            // 
            this.txtBoxPrijavaLozinka.Location = new System.Drawing.Point(94, 75);
            this.txtBoxPrijavaLozinka.Name = "txtBoxPrijavaLozinka";
            this.txtBoxPrijavaLozinka.Size = new System.Drawing.Size(140, 20);
            this.txtBoxPrijavaLozinka.TabIndex = 1;
            this.txtBoxPrijavaLozinka.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lozinka:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Korisničko ime:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbPrijava
            // 
            this.gbPrijava.Controls.Add(this.lblRegistracija);
            this.gbPrijava.Controls.Add(this.btnPrijavi);
            this.gbPrijava.Controls.Add(this.txtBoxPrijavaKorisnickoIme);
            this.gbPrijava.Controls.Add(this.label2);
            this.gbPrijava.Controls.Add(this.txtBoxPrijavaLozinka);
            this.gbPrijava.Controls.Add(this.label1);
            this.gbPrijava.Location = new System.Drawing.Point(316, 150);
            this.gbPrijava.Name = "gbPrijava";
            this.gbPrijava.Size = new System.Drawing.Size(274, 215);
            this.gbPrijava.TabIndex = 4;
            this.gbPrijava.TabStop = false;
            this.gbPrijava.Text = "Prijava";
            // 
            // lblRegistracija
            // 
            this.lblRegistracija.AutoSize = true;
            this.lblRegistracija.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegistracija.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblRegistracija.Location = new System.Drawing.Point(53, 183);
            this.lblRegistracija.Name = "lblRegistracija";
            this.lblRegistracija.Size = new System.Drawing.Size(168, 13);
            this.lblRegistracija.TabIndex = 5;
            this.lblRegistracija.Text = "Nemaš račun? Registriraj se ovdje";
            this.lblRegistracija.Click += new System.EventHandler(this.lblRegistracija_Click);
            // 
            // btnPrijavi
            // 
            this.btnPrijavi.Location = new System.Drawing.Point(94, 116);
            this.btnPrijavi.Name = "btnPrijavi";
            this.btnPrijavi.Size = new System.Drawing.Size(75, 23);
            this.btnPrijavi.TabIndex = 4;
            this.btnPrijavi.Text = "Prijavi se";
            this.btnPrijavi.UseVisualStyleBackColor = true;
            this.btnPrijavi.Click += new System.EventHandler(this.btnPrijavi_Click);
            // 
            // gbRegistracija
            // 
            this.gbRegistracija.Controls.Add(this.lblPrijava);
            this.gbRegistracija.Controls.Add(this.panelRegistracijaDoktor);
            this.gbRegistracija.Controls.Add(this.btnRegistraraj);
            this.gbRegistracija.Controls.Add(this.radioBtnDoktor);
            this.gbRegistracija.Controls.Add(this.panelRegistracijaPacijent);
            this.gbRegistracija.Controls.Add(this.radioBtnPacijent);
            this.gbRegistracija.Controls.Add(this.txtBoxPrezime);
            this.gbRegistracija.Controls.Add(this.txtBoxIme);
            this.gbRegistracija.Controls.Add(this.txtBoxEmail);
            this.gbRegistracija.Controls.Add(this.label3);
            this.gbRegistracija.Controls.Add(this.label4);
            this.gbRegistracija.Controls.Add(this.label5);
            this.gbRegistracija.Controls.Add(this.txtBoxKorisnickoIme);
            this.gbRegistracija.Controls.Add(this.label7);
            this.gbRegistracija.Controls.Add(this.txtBoxLozinka);
            this.gbRegistracija.Controls.Add(this.label6);
            this.gbRegistracija.Location = new System.Drawing.Point(231, 44);
            this.gbRegistracija.Name = "gbRegistracija";
            this.gbRegistracija.Size = new System.Drawing.Size(481, 443);
            this.gbRegistracija.TabIndex = 5;
            this.gbRegistracija.TabStop = false;
            this.gbRegistracija.Text = "Registracija";
            this.gbRegistracija.Visible = false;
            // 
            // lblPrijava
            // 
            this.lblPrijava.AutoSize = true;
            this.lblPrijava.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPrijava.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPrijava.Location = new System.Drawing.Point(163, 414);
            this.lblPrijava.Name = "lblPrijava";
            this.lblPrijava.Size = new System.Drawing.Size(160, 13);
            this.lblPrijava.TabIndex = 21;
            this.lblPrijava.Text = "Već imaš račun? Prijavi se ovdje";
            this.lblPrijava.Click += new System.EventHandler(this.lblPrijava_Click);
            // 
            // panelRegistracijaDoktor
            // 
            this.panelRegistracijaDoktor.Controls.Add(this.label13);
            this.panelRegistracijaDoktor.Controls.Add(this.txtBoxAdresaOrdinacije);
            this.panelRegistracijaDoktor.Location = new System.Drawing.Point(22, 222);
            this.panelRegistracijaDoktor.Name = "panelRegistracijaDoktor";
            this.panelRegistracijaDoktor.Size = new System.Drawing.Size(437, 142);
            this.panelRegistracijaDoktor.TabIndex = 20;
            this.panelRegistracijaDoktor.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Adresa ordinacije";
            // 
            // txtBoxAdresaOrdinacije
            // 
            this.txtBoxAdresaOrdinacije.Location = new System.Drawing.Point(105, 14);
            this.txtBoxAdresaOrdinacije.Name = "txtBoxAdresaOrdinacije";
            this.txtBoxAdresaOrdinacije.Size = new System.Drawing.Size(234, 20);
            this.txtBoxAdresaOrdinacije.TabIndex = 0;
            // 
            // btnRegistraraj
            // 
            this.btnRegistraraj.Location = new System.Drawing.Point(206, 373);
            this.btnRegistraraj.Name = "btnRegistraraj";
            this.btnRegistraraj.Size = new System.Drawing.Size(75, 23);
            this.btnRegistraraj.TabIndex = 20;
            this.btnRegistraraj.Text = "Registriraj se";
            this.btnRegistraraj.UseVisualStyleBackColor = true;
            this.btnRegistraraj.Click += new System.EventHandler(this.btnRegistraraj_Click);
            // 
            // radioBtnDoktor
            // 
            this.radioBtnDoktor.AutoSize = true;
            this.radioBtnDoktor.Location = new System.Drawing.Point(166, 30);
            this.radioBtnDoktor.Name = "radioBtnDoktor";
            this.radioBtnDoktor.Size = new System.Drawing.Size(57, 17);
            this.radioBtnDoktor.TabIndex = 2;
            this.radioBtnDoktor.Text = "Doktor";
            this.radioBtnDoktor.UseVisualStyleBackColor = true;
            this.radioBtnDoktor.CheckedChanged += new System.EventHandler(this.radioBtnDoktor_CheckedChanged);
            // 
            // panelRegistracijaPacijent
            // 
            this.panelRegistracijaPacijent.Controls.Add(this.dateRodenja);
            this.panelRegistracijaPacijent.Controls.Add(this.label12);
            this.panelRegistracijaPacijent.Controls.Add(this.rbZdravstvenoNe);
            this.panelRegistracijaPacijent.Controls.Add(this.rbZdravstvenoDa);
            this.panelRegistracijaPacijent.Controls.Add(this.label11);
            this.panelRegistracijaPacijent.Controls.Add(this.label10);
            this.panelRegistracijaPacijent.Controls.Add(this.label9);
            this.panelRegistracijaPacijent.Controls.Add(this.label8);
            this.panelRegistracijaPacijent.Controls.Add(this.datePredvidenogPoroda);
            this.panelRegistracijaPacijent.Controls.Add(this.dateZadnjeMenstruacije);
            this.panelRegistracijaPacijent.Location = new System.Drawing.Point(19, 225);
            this.panelRegistracijaPacijent.Name = "panelRegistracijaPacijent";
            this.panelRegistracijaPacijent.Size = new System.Drawing.Size(440, 142);
            this.panelRegistracijaPacijent.TabIndex = 0;
            // 
            // dateRodenja
            // 
            this.dateRodenja.Location = new System.Drawing.Point(105, 50);
            this.dateRodenja.Name = "dateRodenja";
            this.dateRodenja.Size = new System.Drawing.Size(150, 20);
            this.dateRodenja.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Datum rođenja*";
            // 
            // rbZdravstvenoNe
            // 
            this.rbZdravstvenoNe.AutoSize = true;
            this.rbZdravstvenoNe.Checked = true;
            this.rbZdravstvenoNe.Location = new System.Drawing.Point(216, 17);
            this.rbZdravstvenoNe.Name = "rbZdravstvenoNe";
            this.rbZdravstvenoNe.Size = new System.Drawing.Size(39, 17);
            this.rbZdravstvenoNe.TabIndex = 17;
            this.rbZdravstvenoNe.TabStop = true;
            this.rbZdravstvenoNe.Text = "Ne";
            this.rbZdravstvenoNe.UseVisualStyleBackColor = true;
            // 
            // rbZdravstvenoDa
            // 
            this.rbZdravstvenoDa.AutoSize = true;
            this.rbZdravstvenoDa.Location = new System.Drawing.Point(161, 17);
            this.rbZdravstvenoDa.Name = "rbZdravstvenoDa";
            this.rbZdravstvenoDa.Size = new System.Drawing.Size(39, 17);
            this.rbZdravstvenoDa.TabIndex = 16;
            this.rbZdravstvenoDa.TabStop = true;
            this.rbZdravstvenoDa.Text = "Da";
            this.rbZdravstvenoDa.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Zdravstveno osiguranje*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(248, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Datum predviđenog poroda";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Datum zadnje menstruacije";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "ILI";
            // 
            // datePredvidenogPoroda
            // 
            this.datePredvidenogPoroda.Checked = false;
            this.datePredvidenogPoroda.Location = new System.Drawing.Point(248, 102);
            this.datePredvidenogPoroda.Name = "datePredvidenogPoroda";
            this.datePredvidenogPoroda.ShowCheckBox = true;
            this.datePredvidenogPoroda.Size = new System.Drawing.Size(144, 20);
            this.datePredvidenogPoroda.TabIndex = 11;
            // 
            // dateZadnjeMenstruacije
            // 
            this.dateZadnjeMenstruacije.Checked = false;
            this.dateZadnjeMenstruacije.Location = new System.Drawing.Point(22, 102);
            this.dateZadnjeMenstruacije.Name = "dateZadnjeMenstruacije";
            this.dateZadnjeMenstruacije.ShowCheckBox = true;
            this.dateZadnjeMenstruacije.Size = new System.Drawing.Size(144, 20);
            this.dateZadnjeMenstruacije.TabIndex = 10;
            // 
            // radioBtnPacijent
            // 
            this.radioBtnPacijent.AutoSize = true;
            this.radioBtnPacijent.Checked = true;
            this.radioBtnPacijent.Location = new System.Drawing.Point(41, 30);
            this.radioBtnPacijent.Name = "radioBtnPacijent";
            this.radioBtnPacijent.Size = new System.Drawing.Size(63, 17);
            this.radioBtnPacijent.TabIndex = 1;
            this.radioBtnPacijent.TabStop = true;
            this.radioBtnPacijent.Text = "Pacijent";
            this.radioBtnPacijent.UseVisualStyleBackColor = true;
            this.radioBtnPacijent.CheckedChanged += new System.EventHandler(this.radioBtnPacijent_CheckedChanged);
            // 
            // txtBoxPrezime
            // 
            this.txtBoxPrezime.Location = new System.Drawing.Point(122, 93);
            this.txtBoxPrezime.Name = "txtBoxPrezime";
            this.txtBoxPrezime.Size = new System.Drawing.Size(150, 20);
            this.txtBoxPrezime.TabIndex = 1;
            // 
            // txtBoxIme
            // 
            this.txtBoxIme.Location = new System.Drawing.Point(122, 67);
            this.txtBoxIme.Name = "txtBoxIme";
            this.txtBoxIme.Size = new System.Drawing.Size(150, 20);
            this.txtBoxIme.TabIndex = 0;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(122, 119);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(150, 20);
            this.txtBoxEmail.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ime*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prezime*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "E-mail*";
            // 
            // txtBoxKorisnickoIme
            // 
            this.txtBoxKorisnickoIme.Location = new System.Drawing.Point(122, 156);
            this.txtBoxKorisnickoIme.Name = "txtBoxKorisnickoIme";
            this.txtBoxKorisnickoIme.Size = new System.Drawing.Size(150, 20);
            this.txtBoxKorisnickoIme.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Lozinka*";
            // 
            // txtBoxLozinka
            // 
            this.txtBoxLozinka.Location = new System.Drawing.Point(122, 183);
            this.txtBoxLozinka.Name = "txtBoxLozinka";
            this.txtBoxLozinka.Size = new System.Drawing.Size(150, 20);
            this.txtBoxLozinka.TabIndex = 7;
            this.txtBoxLozinka.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Korisničko ime*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 567);
            this.Controls.Add(this.gbRegistracija);
            this.Controls.Add(this.gbPrijava);
            this.Name = "Form1";
            this.Text = "Prijava";
            this.gbPrijava.ResumeLayout(false);
            this.gbPrijava.PerformLayout();
            this.gbRegistracija.ResumeLayout(false);
            this.gbRegistracija.PerformLayout();
            this.panelRegistracijaDoktor.ResumeLayout(false);
            this.panelRegistracijaDoktor.PerformLayout();
            this.panelRegistracijaPacijent.ResumeLayout(false);
            this.panelRegistracijaPacijent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxPrijavaKorisnickoIme;
        private System.Windows.Forms.TextBox txtBoxPrijavaLozinka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbPrijava;
        private System.Windows.Forms.GroupBox gbRegistracija;
        private System.Windows.Forms.RadioButton radioBtnDoktor;
        private System.Windows.Forms.RadioButton radioBtnPacijent;
        private System.Windows.Forms.Panel panelRegistracijaPacijent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxPrezime;
        private System.Windows.Forms.TextBox txtBoxIme;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dateRodenja;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rbZdravstvenoNe;
        private System.Windows.Forms.RadioButton rbZdravstvenoDa;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker datePredvidenogPoroda;
        private System.Windows.Forms.DateTimePicker dateZadnjeMenstruacije;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxLozinka;
        private System.Windows.Forms.TextBox txtBoxKorisnickoIme;
        private System.Windows.Forms.Button btnRegistraraj;
        private System.Windows.Forms.Button btnPrijavi;
        private System.Windows.Forms.Panel panelRegistracijaDoktor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBoxAdresaOrdinacije;
        private System.Windows.Forms.Label lblRegistracija;
        private System.Windows.Forms.Label lblPrijava;
    }
}

