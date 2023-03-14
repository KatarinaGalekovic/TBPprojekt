namespace TBP.Forms
{
    partial class NovaTemaForm
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
            this.txtBoxNaslov = new System.Windows.Forms.TextBox();
            this.txtBoxTekst = new System.Windows.Forms.TextBox();
            this.btnOtvoriTemu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naslov";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tekst";
            // 
            // txtBoxNaslov
            // 
            this.txtBoxNaslov.Location = new System.Drawing.Point(65, 56);
            this.txtBoxNaslov.Name = "txtBoxNaslov";
            this.txtBoxNaslov.Size = new System.Drawing.Size(629, 20);
            this.txtBoxNaslov.TabIndex = 2;
            // 
            // txtBoxTekst
            // 
            this.txtBoxTekst.Location = new System.Drawing.Point(65, 114);
            this.txtBoxTekst.Multiline = true;
            this.txtBoxTekst.Name = "txtBoxTekst";
            this.txtBoxTekst.Size = new System.Drawing.Size(629, 243);
            this.txtBoxTekst.TabIndex = 3;
            // 
            // btnOtvoriTemu
            // 
            this.btnOtvoriTemu.Location = new System.Drawing.Point(598, 372);
            this.btnOtvoriTemu.Name = "btnOtvoriTemu";
            this.btnOtvoriTemu.Size = new System.Drawing.Size(96, 32);
            this.btnOtvoriTemu.TabIndex = 4;
            this.btnOtvoriTemu.Text = "Otvori temu";
            this.btnOtvoriTemu.UseVisualStyleBackColor = true;
            this.btnOtvoriTemu.Click += new System.EventHandler(this.btnOtvoriTemu_Click);
            // 
            // NovaTemaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOtvoriTemu);
            this.Controls.Add(this.txtBoxTekst);
            this.Controls.Add(this.txtBoxNaslov);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NovaTemaForm";
            this.Text = "Otvaranje nove teme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxNaslov;
        private System.Windows.Forms.TextBox txtBoxTekst;
        private System.Windows.Forms.Button btnOtvoriTemu;
    }
}