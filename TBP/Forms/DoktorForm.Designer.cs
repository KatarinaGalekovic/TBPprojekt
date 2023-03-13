namespace TBP
{
    partial class DoktorForm
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
            this.lblDobrodosli = new System.Windows.Forms.Label();
            this.dataGridViewPacijenti = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajPacijenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacijenti)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDobrodosli
            // 
            this.lblDobrodosli.AutoSize = true;
            this.lblDobrodosli.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.lblDobrodosli.Location = new System.Drawing.Point(56, 40);
            this.lblDobrodosli.Name = "lblDobrodosli";
            this.lblDobrodosli.Size = new System.Drawing.Size(181, 39);
            this.lblDobrodosli.TabIndex = 0;
            this.lblDobrodosli.Text = "Dobrodošli";
            // 
            // dataGridViewPacijenti
            // 
            this.dataGridViewPacijenti.AllowUserToAddRows = false;
            this.dataGridViewPacijenti.AllowUserToDeleteRows = false;
            this.dataGridViewPacijenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPacijenti.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPacijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPacijenti.Location = new System.Drawing.Point(38, 135);
            this.dataGridViewPacijenti.Name = "dataGridViewPacijenti";
            this.dataGridViewPacijenti.ReadOnly = true;
            this.dataGridViewPacijenti.Size = new System.Drawing.Size(690, 258);
            this.dataGridViewPacijenti.TabIndex = 1;
            this.dataGridViewPacijenti.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPacijenti_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Popis pacijenata (dvostruki klik na pacijenta za detalje)";
            // 
            // btnDodajPacijenta
            // 
            this.btnDodajPacijenta.Location = new System.Drawing.Point(41, 399);
            this.btnDodajPacijenta.Name = "btnDodajPacijenta";
            this.btnDodajPacijenta.Size = new System.Drawing.Size(116, 30);
            this.btnDodajPacijenta.TabIndex = 3;
            this.btnDodajPacijenta.Text = "Dodaj pacijenta";
            this.btnDodajPacijenta.UseVisualStyleBackColor = true;
            this.btnDodajPacijenta.Click += new System.EventHandler(this.btnDodajPacijenta_Click);
            // 
            // DoktorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 602);
            this.Controls.Add(this.btnDodajPacijenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPacijenti);
            this.Controls.Add(this.lblDobrodosli);
            this.Name = "DoktorForm";
            this.Text = "Doktor";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacijenti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDobrodosli;
        private System.Windows.Forms.DataGridView dataGridViewPacijenti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajPacijenta;
    }
}