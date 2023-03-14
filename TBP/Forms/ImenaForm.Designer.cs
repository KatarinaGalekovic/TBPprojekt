namespace TBP.Forms
{
    partial class ImenaForm
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
            this.listBoxImena = new System.Windows.Forms.ListBox();
            this.txtBoxNovoIme = new System.Windows.Forms.TextBox();
            this.btnNovoIme = new System.Windows.Forms.Button();
            this.btnOznaciIme = new System.Windows.Forms.Button();
            this.rbM = new System.Windows.Forms.RadioButton();
            this.rbZ = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // listBoxImena
            // 
            this.listBoxImena.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBoxImena.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.listBoxImena.FormattingEnabled = true;
            this.listBoxImena.ItemHeight = 30;
            this.listBoxImena.Location = new System.Drawing.Point(128, 84);
            this.listBoxImena.Name = "listBoxImena";
            this.listBoxImena.Size = new System.Drawing.Size(537, 303);
            this.listBoxImena.TabIndex = 0;
            this.listBoxImena.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxImena_DrawItem);
            this.listBoxImena.SelectedIndexChanged += new System.EventHandler(this.listBoxImena_SelectedIndexChanged);
            // 
            // txtBoxNovoIme
            // 
            this.txtBoxNovoIme.Location = new System.Drawing.Point(128, 31);
            this.txtBoxNovoIme.Name = "txtBoxNovoIme";
            this.txtBoxNovoIme.Size = new System.Drawing.Size(162, 20);
            this.txtBoxNovoIme.TabIndex = 1;
            // 
            // btnNovoIme
            // 
            this.btnNovoIme.Location = new System.Drawing.Point(397, 22);
            this.btnNovoIme.Name = "btnNovoIme";
            this.btnNovoIme.Size = new System.Drawing.Size(93, 36);
            this.btnNovoIme.TabIndex = 2;
            this.btnNovoIme.Text = "Dodaj novo ime";
            this.btnNovoIme.UseVisualStyleBackColor = true;
            this.btnNovoIme.Click += new System.EventHandler(this.btnNovoIme_Click);
            // 
            // btnOznaciIme
            // 
            this.btnOznaciIme.Location = new System.Drawing.Point(553, 394);
            this.btnOznaciIme.Name = "btnOznaciIme";
            this.btnOznaciIme.Size = new System.Drawing.Size(99, 44);
            this.btnOznaciIme.TabIndex = 3;
            this.btnOznaciIme.Text = "Označi sa \'sviđa mi se\'";
            this.btnOznaciIme.UseVisualStyleBackColor = true;
            this.btnOznaciIme.Click += new System.EventHandler(this.btnOznaciIme_Click);
            // 
            // rbM
            // 
            this.rbM.AutoSize = true;
            this.rbM.Checked = true;
            this.rbM.Location = new System.Drawing.Point(310, 32);
            this.rbM.Name = "rbM";
            this.rbM.Size = new System.Drawing.Size(34, 17);
            this.rbM.TabIndex = 4;
            this.rbM.TabStop = true;
            this.rbM.Text = "M";
            this.rbM.UseVisualStyleBackColor = true;
            // 
            // rbZ
            // 
            this.rbZ.AutoSize = true;
            this.rbZ.Location = new System.Drawing.Point(350, 32);
            this.rbZ.Name = "rbZ";
            this.rbZ.Size = new System.Drawing.Size(32, 17);
            this.rbZ.TabIndex = 5;
            this.rbZ.Text = "Ž";
            this.rbZ.UseVisualStyleBackColor = true;
            // 
            // ImenaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbZ);
            this.Controls.Add(this.rbM);
            this.Controls.Add(this.btnOznaciIme);
            this.Controls.Add(this.btnNovoIme);
            this.Controls.Add(this.txtBoxNovoIme);
            this.Controls.Add(this.listBoxImena);
            this.Name = "ImenaForm";
            this.Text = "Imena djece";
            this.Load += new System.EventHandler(this.ImenaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxImena;
        private System.Windows.Forms.TextBox txtBoxNovoIme;
        private System.Windows.Forms.Button btnNovoIme;
        private System.Windows.Forms.Button btnOznaciIme;
        private System.Windows.Forms.RadioButton rbM;
        private System.Windows.Forms.RadioButton rbZ;
    }
}