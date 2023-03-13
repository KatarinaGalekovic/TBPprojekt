namespace TBP.Forms
{
    partial class BiljeskaForm
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
            this.txtBoxOpis = new System.Windows.Forms.TextBox();
            this.cbPrikazatiDoktoru = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxOpis
            // 
            this.txtBoxOpis.Location = new System.Drawing.Point(50, 125);
            this.txtBoxOpis.Multiline = true;
            this.txtBoxOpis.Name = "txtBoxOpis";
            this.txtBoxOpis.Size = new System.Drawing.Size(611, 260);
            this.txtBoxOpis.TabIndex = 0;
            // 
            // cbPrikazatiDoktoru
            // 
            this.cbPrikazatiDoktoru.AutoSize = true;
            this.cbPrikazatiDoktoru.Location = new System.Drawing.Point(50, 50);
            this.cbPrikazatiDoktoru.Name = "cbPrikazatiDoktoru";
            this.cbPrikazatiDoktoru.Size = new System.Drawing.Size(154, 17);
            this.cbPrikazatiDoktoru.TabIndex = 1;
            this.cbPrikazatiDoktoru.Text = "Prikazati bilješku i doktoru?";
            this.cbPrikazatiDoktoru.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bilješka:";
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(311, 406);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(85, 33);
            this.btnSpremi.TabIndex = 3;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // BiljeskaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 467);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPrikazatiDoktoru);
            this.Controls.Add(this.txtBoxOpis);
            this.Name = "BiljeskaForm";
            this.Text = "Bilješka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxOpis;
        private System.Windows.Forms.CheckBox cbPrikazatiDoktoru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSpremi;
    }
}