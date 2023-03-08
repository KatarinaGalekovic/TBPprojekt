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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbPrijava = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.gbRegistracija = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.radioBtnDoktor = new System.Windows.Forms.RadioButton();
            this.radioBtnPacijent = new System.Windows.Forms.RadioButton();
            this.panelRegistracijaPacijent = new System.Windows.Forms.Panel();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxPrezime = new System.Windows.Forms.TextBox();
            this.txtBoxIme = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelRegistracijaDoktor = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gbPrijava.SuspendLayout();
            this.gbRegistracija.SuspendLayout();
            this.panelRegistracijaPacijent.SuspendLayout();
            this.panelRegistracijaDoktor.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 1;
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
            this.gbPrijava.Controls.Add(this.button2);
            this.gbPrijava.Controls.Add(this.textBox1);
            this.gbPrijava.Controls.Add(this.label2);
            this.gbPrijava.Controls.Add(this.textBox2);
            this.gbPrijava.Controls.Add(this.label1);
            this.gbPrijava.Location = new System.Drawing.Point(50, 45);
            this.gbPrijava.Name = "gbPrijava";
            this.gbPrijava.Size = new System.Drawing.Size(274, 154);
            this.gbPrijava.TabIndex = 4;
            this.gbPrijava.TabStop = false;
            this.gbPrijava.Text = "Prijava";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Prijavi se";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // gbRegistracija
            // 
            this.gbRegistracija.Controls.Add(this.panelRegistracijaDoktor);
            this.gbRegistracija.Controls.Add(this.button1);
            this.gbRegistracija.Controls.Add(this.radioBtnDoktor);
            this.gbRegistracija.Controls.Add(this.panelRegistracijaPacijent);
            this.gbRegistracija.Controls.Add(this.radioBtnPacijent);
            this.gbRegistracija.Controls.Add(this.txtBoxPrezime);
            this.gbRegistracija.Controls.Add(this.txtBoxIme);
            this.gbRegistracija.Controls.Add(this.txtBoxEmail);
            this.gbRegistracija.Controls.Add(this.label3);
            this.gbRegistracija.Controls.Add(this.label4);
            this.gbRegistracija.Controls.Add(this.label5);
            this.gbRegistracija.Controls.Add(this.textBox3);
            this.gbRegistracija.Controls.Add(this.label7);
            this.gbRegistracija.Controls.Add(this.textBox4);
            this.gbRegistracija.Controls.Add(this.label6);
            this.gbRegistracija.Location = new System.Drawing.Point(362, 45);
            this.gbRegistracija.Name = "gbRegistracija";
            this.gbRegistracija.Size = new System.Drawing.Size(481, 417);
            this.gbRegistracija.TabIndex = 5;
            this.gbRegistracija.TabStop = false;
            this.gbRegistracija.Text = "Registracija";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Registriraj se";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // panelRegistracijaPacijent
            // 
            this.panelRegistracijaPacijent.Controls.Add(this.dateTimePicker3);
            this.panelRegistracijaPacijent.Controls.Add(this.label12);
            this.panelRegistracijaPacijent.Controls.Add(this.radioButton4);
            this.panelRegistracijaPacijent.Controls.Add(this.radioButton3);
            this.panelRegistracijaPacijent.Controls.Add(this.label11);
            this.panelRegistracijaPacijent.Controls.Add(this.label10);
            this.panelRegistracijaPacijent.Controls.Add(this.label9);
            this.panelRegistracijaPacijent.Controls.Add(this.label8);
            this.panelRegistracijaPacijent.Controls.Add(this.dateTimePicker2);
            this.panelRegistracijaPacijent.Controls.Add(this.dateTimePicker1);
            this.panelRegistracijaPacijent.Location = new System.Drawing.Point(19, 225);
            this.panelRegistracijaPacijent.Name = "panelRegistracijaPacijent";
            this.panelRegistracijaPacijent.Size = new System.Drawing.Size(440, 142);
            this.panelRegistracijaPacijent.TabIndex = 0;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(105, 50);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(150, 20);
            this.dateTimePicker3.TabIndex = 19;
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
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(216, 17);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(39, 17);
            this.radioButton4.TabIndex = 17;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Ne";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(161, 17);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(39, 17);
            this.radioButton3.TabIndex = 16;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Da";
            this.radioButton3.UseVisualStyleBackColor = true;
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
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(248, 102);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker2.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(22, 102);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker1.TabIndex = 10;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Korisničko ime*";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(122, 183);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(150, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(122, 156);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 20);
            this.textBox3.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "E-mail";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ime*";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(122, 119);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(150, 20);
            this.txtBoxEmail.TabIndex = 2;
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
            // panelRegistracijaDoktor
            // 
            this.panelRegistracijaDoktor.Controls.Add(this.label13);
            this.panelRegistracijaDoktor.Controls.Add(this.textBox5);
            this.panelRegistracijaDoktor.Location = new System.Drawing.Point(22, 222);
            this.panelRegistracijaDoktor.Name = "panelRegistracijaDoktor";
            this.panelRegistracijaDoktor.Size = new System.Drawing.Size(437, 142);
            this.panelRegistracijaDoktor.TabIndex = 20;
            this.panelRegistracijaDoktor.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(105, 14);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(234, 20);
            this.textBox5.TabIndex = 0;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 517);
            this.Controls.Add(this.gbRegistracija);
            this.Controls.Add(this.gbPrijava);
            this.Name = "Form1";
            this.Text = "Prijava";
            this.gbPrijava.ResumeLayout(false);
            this.gbPrijava.PerformLayout();
            this.gbRegistracija.ResumeLayout(false);
            this.gbRegistracija.PerformLayout();
            this.panelRegistracijaPacijent.ResumeLayout(false);
            this.panelRegistracijaPacijent.PerformLayout();
            this.panelRegistracijaDoktor.ResumeLayout(false);
            this.panelRegistracijaDoktor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
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
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panelRegistracijaDoktor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox5;
    }
}

