namespace TBP.Forms
{
    partial class ObvezeForm
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
            this.listBoxObveze = new System.Windows.Forms.ListBox();
            this.lblFaza = new System.Windows.Forms.Label();
            this.btnPrije = new System.Windows.Forms.Button();
            this.btnPoslije = new System.Windows.Forms.Button();
            this.btnOznaciObavljeno = new System.Windows.Forms.Button();
            this.txtBoxNovaObveza = new System.Windows.Forms.TextBox();
            this.btnDodajObvezu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxObveze
            // 
            this.listBoxObveze.DisplayMember = "opis";
            this.listBoxObveze.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.listBoxObveze.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.listBoxObveze.FormattingEnabled = true;
            this.listBoxObveze.Location = new System.Drawing.Point(99, 115);
            this.listBoxObveze.Name = "listBoxObveze";
            this.listBoxObveze.Size = new System.Drawing.Size(583, 277);
            this.listBoxObveze.TabIndex = 0;
            this.listBoxObveze.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxObveze_DrawItem);
            this.listBoxObveze.SelectedIndexChanged += new System.EventHandler(this.listBoxObveze_SelectedIndexChanged);
            // 
            // lblFaza
            // 
            this.lblFaza.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lblFaza.Location = new System.Drawing.Point(146, 75);
            this.lblFaza.Name = "lblFaza";
            this.lblFaza.Size = new System.Drawing.Size(494, 32);
            this.lblFaza.TabIndex = 1;
            this.lblFaza.Text = "Faza";
            this.lblFaza.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrije
            // 
            this.btnPrije.Location = new System.Drawing.Point(99, 84);
            this.btnPrije.Name = "btnPrije";
            this.btnPrije.Size = new System.Drawing.Size(25, 25);
            this.btnPrije.TabIndex = 2;
            this.btnPrije.Text = "<";
            this.btnPrije.UseVisualStyleBackColor = true;
            this.btnPrije.Click += new System.EventHandler(this.btnPrije_Click);
            // 
            // btnPoslije
            // 
            this.btnPoslije.Location = new System.Drawing.Point(657, 84);
            this.btnPoslije.Name = "btnPoslije";
            this.btnPoslije.Size = new System.Drawing.Size(25, 25);
            this.btnPoslije.TabIndex = 3;
            this.btnPoslije.Text = ">";
            this.btnPoslije.UseVisualStyleBackColor = true;
            this.btnPoslije.Click += new System.EventHandler(this.btnPoslije_Click);
            // 
            // btnOznaciObavljeno
            // 
            this.btnOznaciObavljeno.Location = new System.Drawing.Point(581, 398);
            this.btnOznaciObavljeno.Name = "btnOznaciObavljeno";
            this.btnOznaciObavljeno.Size = new System.Drawing.Size(101, 37);
            this.btnOznaciObavljeno.TabIndex = 4;
            this.btnOznaciObavljeno.Text = "Označi kao obavljeno";
            this.btnOznaciObavljeno.UseVisualStyleBackColor = true;
            this.btnOznaciObavljeno.Click += new System.EventHandler(this.btnOznaciObavljeno_Click);
            // 
            // txtBoxNovaObveza
            // 
            this.txtBoxNovaObveza.Location = new System.Drawing.Point(99, 32);
            this.txtBoxNovaObveza.Name = "txtBoxNovaObveza";
            this.txtBoxNovaObveza.Size = new System.Drawing.Size(411, 20);
            this.txtBoxNovaObveza.TabIndex = 5;
            // 
            // btnDodajObvezu
            // 
            this.btnDodajObvezu.Location = new System.Drawing.Point(516, 22);
            this.btnDodajObvezu.Name = "btnDodajObvezu";
            this.btnDodajObvezu.Size = new System.Drawing.Size(98, 41);
            this.btnDodajObvezu.TabIndex = 6;
            this.btnDodajObvezu.Text = "Dodaj obvezu u ovu fazu";
            this.btnDodajObvezu.UseVisualStyleBackColor = true;
            this.btnDodajObvezu.Click += new System.EventHandler(this.btnDodajObvezu_Click);
            // 
            // ObvezeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDodajObvezu);
            this.Controls.Add(this.txtBoxNovaObveza);
            this.Controls.Add(this.btnOznaciObavljeno);
            this.Controls.Add(this.btnPoslije);
            this.Controls.Add(this.btnPrije);
            this.Controls.Add(this.lblFaza);
            this.Controls.Add(this.listBoxObveze);
            this.Name = "ObvezeForm";
            this.Text = "Obveze";
            this.Load += new System.EventHandler(this.ObvezeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxObveze;
        private System.Windows.Forms.Label lblFaza;
        private System.Windows.Forms.Button btnPrije;
        private System.Windows.Forms.Button btnPoslije;
        private System.Windows.Forms.Button btnOznaciObavljeno;
        private System.Windows.Forms.TextBox txtBoxNovaObveza;
        private System.Windows.Forms.Button btnDodajObvezu;
    }
}