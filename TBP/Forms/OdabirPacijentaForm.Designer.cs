namespace TBP
{
    partial class OdabirPacijentaForm
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
            this.dataGridViewPacijenti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacijenti)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPacijenti
            // 
            this.dataGridViewPacijenti.AllowUserToAddRows = false;
            this.dataGridViewPacijenti.AllowUserToDeleteRows = false;
            this.dataGridViewPacijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPacijenti.Location = new System.Drawing.Point(33, 35);
            this.dataGridViewPacijenti.Name = "dataGridViewPacijenti";
            this.dataGridViewPacijenti.ReadOnly = true;
            this.dataGridViewPacijenti.Size = new System.Drawing.Size(718, 380);
            this.dataGridViewPacijenti.TabIndex = 0;
            this.dataGridViewPacijenti.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPacijenti_CellDoubleClick);
            // 
            // OdabirPacijentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewPacijenti);
            this.Name = "OdabirPacijentaForm";
            this.Text = "Odaberite pacijenta";
            this.Load += new System.EventHandler(this.OdabirPacijentaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPacijenti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPacijenti;
    }
}