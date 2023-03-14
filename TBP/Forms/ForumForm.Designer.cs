namespace TBP.Forms
{
    partial class ForumForm
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
            this.listBoxTeme = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNovaTema = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxTeme
            // 
            this.listBoxTeme.DisplayMember = "naslov";
            this.listBoxTeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.listBoxTeme.FormattingEnabled = true;
            this.listBoxTeme.ItemHeight = 31;
            this.listBoxTeme.Location = new System.Drawing.Point(65, 84);
            this.listBoxTeme.Name = "listBoxTeme";
            this.listBoxTeme.Size = new System.Drawing.Size(640, 283);
            this.listBoxTeme.TabIndex = 0;
            this.listBoxTeme.DoubleClick += new System.EventHandler(this.listBoxTeme_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Otvorene teme";
            // 
            // btnNovaTema
            // 
            this.btnNovaTema.Location = new System.Drawing.Point(594, 385);
            this.btnNovaTema.Name = "btnNovaTema";
            this.btnNovaTema.Size = new System.Drawing.Size(95, 44);
            this.btnNovaTema.TabIndex = 2;
            this.btnNovaTema.Text = "Otvori novu temu";
            this.btnNovaTema.UseVisualStyleBackColor = true;
            this.btnNovaTema.Click += new System.EventHandler(this.btnNovaTema_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.label2.Location = new System.Drawing.Point(327, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "Forum";
            // 
            // ForumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNovaTema);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxTeme);
            this.Name = "ForumForm";
            this.Text = "Forum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTeme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNovaTema;
        private System.Windows.Forms.Label label2;
    }
}