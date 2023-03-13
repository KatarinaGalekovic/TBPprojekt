namespace TBP.Forms
{
    partial class PregledForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerVrijeme = new System.Windows.Forms.DateTimePicker();
            this.txtBoxTrajanje = new System.Windows.Forms.TextBox();
            this.txtBoxBiljeska = new System.Windows.Forms.TextBox();
            this.btnZakazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Početak pregleda:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bilješka doktora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trajanje pregleda (u min):";
            // 
            // dateTimePickerVrijeme
            // 
            this.dateTimePickerVrijeme.CustomFormat = "dd.MM.yyyy.    HH:mm";
            this.dateTimePickerVrijeme.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerVrijeme.Location = new System.Drawing.Point(188, 40);
            this.dateTimePickerVrijeme.Name = "dateTimePickerVrijeme";
            this.dateTimePickerVrijeme.Size = new System.Drawing.Size(145, 20);
            this.dateTimePickerVrijeme.TabIndex = 3;
            // 
            // txtBoxTrajanje
            // 
            this.txtBoxTrajanje.Location = new System.Drawing.Point(188, 74);
            this.txtBoxTrajanje.Name = "txtBoxTrajanje";
            this.txtBoxTrajanje.Size = new System.Drawing.Size(56, 20);
            this.txtBoxTrajanje.TabIndex = 4;
            // 
            // txtBoxBiljeska
            // 
            this.txtBoxBiljeska.Location = new System.Drawing.Point(188, 103);
            this.txtBoxBiljeska.Multiline = true;
            this.txtBoxBiljeska.Name = "txtBoxBiljeska";
            this.txtBoxBiljeska.Size = new System.Drawing.Size(265, 142);
            this.txtBoxBiljeska.TabIndex = 5;
            // 
            // btnZakazi
            // 
            this.btnZakazi.Location = new System.Drawing.Point(213, 271);
            this.btnZakazi.Name = "btnZakazi";
            this.btnZakazi.Size = new System.Drawing.Size(105, 36);
            this.btnZakazi.TabIndex = 6;
            this.btnZakazi.Text = "Zakaži pregled";
            this.btnZakazi.UseVisualStyleBackColor = true;
            this.btnZakazi.Click += new System.EventHandler(this.btnZakazi_Click);
            // 
            // PregledForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 327);
            this.Controls.Add(this.btnZakazi);
            this.Controls.Add(this.txtBoxBiljeska);
            this.Controls.Add(this.txtBoxTrajanje);
            this.Controls.Add(this.dateTimePickerVrijeme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PregledForm";
            this.Text = "Novi pregled";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxTrajanje;
        private System.Windows.Forms.TextBox txtBoxBiljeska;
        private System.Windows.Forms.Button btnZakazi;
        private System.Windows.Forms.DateTimePicker dateTimePickerVrijeme;
    }
}