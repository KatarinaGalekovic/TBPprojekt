namespace TBP.Forms
{
    partial class PrijasnjiDoktoriForm
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
            this.dataGridViewDoktori = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoktori)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDoktori
            // 
            this.dataGridViewDoktori.AllowUserToAddRows = false;
            this.dataGridViewDoktori.AllowUserToDeleteRows = false;
            this.dataGridViewDoktori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoktori.Location = new System.Drawing.Point(90, 75);
            this.dataGridViewDoktori.Name = "dataGridViewDoktori";
            this.dataGridViewDoktori.ReadOnly = true;
            this.dataGridViewDoktori.Size = new System.Drawing.Size(602, 328);
            this.dataGridViewDoktori.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Moji prijašnji doktori";
            // 
            // PrijasnjiDoktoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewDoktori);
            this.Name = "PrijasnjiDoktoriForm";
            this.Text = "Prijašnji doktori";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoktori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDoktori;
        private System.Windows.Forms.Label label1;
    }
}