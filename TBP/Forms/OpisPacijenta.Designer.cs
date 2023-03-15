namespace TBP
{
    partial class OpisPacijenta
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
            this.lblImeIPrezime = new System.Windows.Forms.Label();
            this.lblDatumRodenja = new System.Windows.Forms.Label();
            this.lblZdravstveno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMenstruacija = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPorod = new System.Windows.Forms.Label();
            this.dataGridViewPregledi = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridViewBiljeske = new System.Windows.Forms.DataGridView();
            this.btnNoviPregled = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblKilaza = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPregledi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBiljeske)).BeginInit();
            this.SuspendLayout();
            // 
            // lblImeIPrezime
            // 
            this.lblImeIPrezime.AutoSize = true;
            this.lblImeIPrezime.Location = new System.Drawing.Point(204, 50);
            this.lblImeIPrezime.Name = "lblImeIPrezime";
            this.lblImeIPrezime.Size = new System.Drawing.Size(68, 13);
            this.lblImeIPrezime.TabIndex = 0;
            this.lblImeIPrezime.Text = "Ime i prezime";
            // 
            // lblDatumRodenja
            // 
            this.lblDatumRodenja.AutoSize = true;
            this.lblDatumRodenja.Location = new System.Drawing.Point(204, 78);
            this.lblDatumRodenja.Name = "lblDatumRodenja";
            this.lblDatumRodenja.Size = new System.Drawing.Size(77, 13);
            this.lblDatumRodenja.TabIndex = 1;
            this.lblDatumRodenja.Text = "Datum rođenja";
            // 
            // lblZdravstveno
            // 
            this.lblZdravstveno.AutoSize = true;
            this.lblZdravstveno.Location = new System.Drawing.Point(204, 107);
            this.lblZdravstveno.Name = "lblZdravstveno";
            this.lblZdravstveno.Size = new System.Drawing.Size(67, 13);
            this.lblZdravstveno.TabIndex = 2;
            this.lblZdravstveno.Text = "Zdravstveno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Zdravstveno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datum rođenja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ime i prezime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Datum zadnje menstruacije:";
            // 
            // lblMenstruacija
            // 
            this.lblMenstruacija.AutoSize = true;
            this.lblMenstruacija.Location = new System.Drawing.Point(204, 135);
            this.lblMenstruacija.Name = "lblMenstruacija";
            this.lblMenstruacija.Size = new System.Drawing.Size(134, 13);
            this.lblMenstruacija.TabIndex = 7;
            this.lblMenstruacija.Text = "Datum zadnje menstruacije";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Datum predviđenog poroda:";
            // 
            // lblPorod
            // 
            this.lblPorod.AutoSize = true;
            this.lblPorod.Location = new System.Drawing.Point(204, 164);
            this.lblPorod.Name = "lblPorod";
            this.lblPorod.Size = new System.Drawing.Size(137, 13);
            this.lblPorod.TabIndex = 9;
            this.lblPorod.Text = "Datum predviđenog poroda";
            // 
            // dataGridViewPregledi
            // 
            this.dataGridViewPregledi.AllowUserToAddRows = false;
            this.dataGridViewPregledi.AllowUserToDeleteRows = false;
            this.dataGridViewPregledi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewPregledi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPregledi.Location = new System.Drawing.Point(63, 236);
            this.dataGridViewPregledi.Name = "dataGridViewPregledi";
            this.dataGridViewPregledi.ReadOnly = true;
            this.dataGridViewPregledi.Size = new System.Drawing.Size(362, 164);
            this.dataGridViewPregledi.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Popis pregleda pacijenta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(457, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Bilješke pacijenta";
            // 
            // dataGridViewBiljeske
            // 
            this.dataGridViewBiljeske.AllowUserToAddRows = false;
            this.dataGridViewBiljeske.AllowUserToDeleteRows = false;
            this.dataGridViewBiljeske.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewBiljeske.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBiljeske.Location = new System.Drawing.Point(460, 68);
            this.dataGridViewBiljeske.Name = "dataGridViewBiljeske";
            this.dataGridViewBiljeske.ReadOnly = true;
            this.dataGridViewBiljeske.Size = new System.Drawing.Size(302, 332);
            this.dataGridViewBiljeske.TabIndex = 13;
            // 
            // btnNoviPregled
            // 
            this.btnNoviPregled.Location = new System.Drawing.Point(63, 407);
            this.btnNoviPregled.Name = "btnNoviPregled";
            this.btnNoviPregled.Size = new System.Drawing.Size(134, 37);
            this.btnNoviPregled.TabIndex = 14;
            this.btnNoviPregled.Text = "Zakaži novi pregled";
            this.btnNoviPregled.UseVisualStyleBackColor = true;
            this.btnNoviPregled.Click += new System.EventHandler(this.btnNoviPregled_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Kilaža:";
            // 
            // lblKilaza
            // 
            this.lblKilaza.AutoSize = true;
            this.lblKilaza.Location = new System.Drawing.Point(204, 190);
            this.lblKilaza.Name = "lblKilaza";
            this.lblKilaza.Size = new System.Drawing.Size(35, 13);
            this.lblKilaza.TabIndex = 16;
            this.lblKilaza.Text = "Kilaža";
            // 
            // OpisPacijenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.lblKilaza);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnNoviPregled);
            this.Controls.Add(this.dataGridViewBiljeske);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewPregledi);
            this.Controls.Add(this.lblPorod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblMenstruacija);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblZdravstveno);
            this.Controls.Add(this.lblDatumRodenja);
            this.Controls.Add(this.lblImeIPrezime);
            this.Name = "OpisPacijenta";
            this.Text = "Opis pacijenta";
            this.Load += new System.EventHandler(this.OpisPacijenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPregledi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBiljeske)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImeIPrezime;
        private System.Windows.Forms.Label lblDatumRodenja;
        private System.Windows.Forms.Label lblZdravstveno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMenstruacija;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPorod;
        private System.Windows.Forms.DataGridView dataGridViewPregledi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridViewBiljeske;
        private System.Windows.Forms.Button btnNoviPregled;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblKilaza;
    }
}