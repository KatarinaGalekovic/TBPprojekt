namespace TBP.Forms
{
    partial class DogadanjaForm
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
            this.btnPoslije = new System.Windows.Forms.Button();
            this.btnPrije = new System.Windows.Forms.Button();
            this.lblTjedan = new System.Windows.Forms.Label();
            this.lblTekst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPoslije
            // 
            this.btnPoslije.Location = new System.Drawing.Point(649, 36);
            this.btnPoslije.Name = "btnPoslije";
            this.btnPoslije.Size = new System.Drawing.Size(25, 25);
            this.btnPoslije.TabIndex = 6;
            this.btnPoslije.Text = ">";
            this.btnPoslije.UseVisualStyleBackColor = true;
            this.btnPoslije.Click += new System.EventHandler(this.btnPoslije_Click);
            // 
            // btnPrije
            // 
            this.btnPrije.Location = new System.Drawing.Point(91, 36);
            this.btnPrije.Name = "btnPrije";
            this.btnPrije.Size = new System.Drawing.Size(25, 25);
            this.btnPrije.TabIndex = 5;
            this.btnPrije.Text = "<";
            this.btnPrije.UseVisualStyleBackColor = true;
            this.btnPrije.Click += new System.EventHandler(this.btnPrije_Click);
            // 
            // lblTjedan
            // 
            this.lblTjedan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblTjedan.Location = new System.Drawing.Point(138, 27);
            this.lblTjedan.Name = "lblTjedan";
            this.lblTjedan.Size = new System.Drawing.Size(494, 32);
            this.lblTjedan.TabIndex = 4;
            this.lblTjedan.Text = "Tjedan";
            this.lblTjedan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTekst
            // 
            this.lblTekst.Location = new System.Drawing.Point(88, 104);
            this.lblTekst.Name = "lblTekst";
            this.lblTekst.Size = new System.Drawing.Size(586, 289);
            this.lblTekst.TabIndex = 7;
            // 
            // DogadanjaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTekst);
            this.Controls.Add(this.btnPoslije);
            this.Controls.Add(this.btnPrije);
            this.Controls.Add(this.lblTjedan);
            this.Name = "DogadanjaForm";
            this.Text = "Događanja";
            this.Load += new System.EventHandler(this.DogadanjaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPoslije;
        private System.Windows.Forms.Button btnPrije;
        private System.Windows.Forms.Label lblTjedan;
        private System.Windows.Forms.Label lblTekst;
    }
}