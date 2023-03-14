namespace TBP.Forms
{
    partial class TemaForm
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
            this.lblNaslov = new System.Windows.Forms.Label();
            this.lblTekst = new System.Windows.Forms.Label();
            this.dataGridViewKomentari = new System.Windows.Forms.DataGridView();
            this.txtBoxKomentar = new System.Windows.Forms.TextBox();
            this.btnKomentiraj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblVrijemeObjave = new System.Windows.Forms.Label();
            this.lblKreatorTeme = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKomentari)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblNaslov.Location = new System.Drawing.Point(79, 38);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(634, 38);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Naslov";
            // 
            // lblTekst
            // 
            this.lblTekst.Location = new System.Drawing.Point(83, 109);
            this.lblTekst.Name = "lblTekst";
            this.lblTekst.Size = new System.Drawing.Size(630, 170);
            this.lblTekst.TabIndex = 1;
            this.lblTekst.Text = "Tekst";
            // 
            // dataGridViewKomentari
            // 
            this.dataGridViewKomentari.AllowUserToAddRows = false;
            this.dataGridViewKomentari.AllowUserToDeleteRows = false;
            this.dataGridViewKomentari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewKomentari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKomentari.Location = new System.Drawing.Point(85, 308);
            this.dataGridViewKomentari.Name = "dataGridViewKomentari";
            this.dataGridViewKomentari.ReadOnly = true;
            this.dataGridViewKomentari.Size = new System.Drawing.Size(628, 142);
            this.dataGridViewKomentari.TabIndex = 2;
            // 
            // txtBoxKomentar
            // 
            this.txtBoxKomentar.Location = new System.Drawing.Point(86, 484);
            this.txtBoxKomentar.Multiline = true;
            this.txtBoxKomentar.Name = "txtBoxKomentar";
            this.txtBoxKomentar.Size = new System.Drawing.Size(531, 67);
            this.txtBoxKomentar.TabIndex = 3;
            // 
            // btnKomentiraj
            // 
            this.btnKomentiraj.Location = new System.Drawing.Point(623, 499);
            this.btnKomentiraj.Name = "btnKomentiraj";
            this.btnKomentiraj.Size = new System.Drawing.Size(91, 37);
            this.btnKomentiraj.TabIndex = 4;
            this.btnKomentiraj.Text = "Komentiraj";
            this.btnKomentiraj.UseVisualStyleBackColor = true;
            this.btnKomentiraj.Click += new System.EventHandler(this.btnKomentiraj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Komentari";
            // 
            // lblVrijemeObjave
            // 
            this.lblVrijemeObjave.AutoSize = true;
            this.lblVrijemeObjave.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVrijemeObjave.Location = new System.Drawing.Point(82, 86);
            this.lblVrijemeObjave.Name = "lblVrijemeObjave";
            this.lblVrijemeObjave.Size = new System.Drawing.Size(76, 13);
            this.lblVrijemeObjave.TabIndex = 6;
            this.lblVrijemeObjave.Text = "Vrijeme objave";
            // 
            // lblKreatorTeme
            // 
            this.lblKreatorTeme.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblKreatorTeme.Location = new System.Drawing.Point(416, 81);
            this.lblKreatorTeme.Name = "lblKreatorTeme";
            this.lblKreatorTeme.Size = new System.Drawing.Size(283, 23);
            this.lblKreatorTeme.TabIndex = 7;
            this.lblKreatorTeme.Text = "Kreator";
            this.lblKreatorTeme.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TemaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.lblKreatorTeme);
            this.Controls.Add(this.lblVrijemeObjave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKomentiraj);
            this.Controls.Add(this.txtBoxKomentar);
            this.Controls.Add(this.dataGridViewKomentari);
            this.Controls.Add(this.lblTekst);
            this.Controls.Add(this.lblNaslov);
            this.Name = "TemaForm";
            this.Text = "Tema";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKomentari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label lblTekst;
        private System.Windows.Forms.DataGridView dataGridViewKomentari;
        private System.Windows.Forms.TextBox txtBoxKomentar;
        private System.Windows.Forms.Button btnKomentiraj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblVrijemeObjave;
        private System.Windows.Forms.Label lblKreatorTeme;
    }
}