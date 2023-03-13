namespace TBP.Forms
{
    partial class PacijentForm
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
            this.dataGridViewBiljeske = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDodajBiljesku = new System.Windows.Forms.Button();
            this.btnObveze = new System.Windows.Forms.Button();
            this.btnImenadjece = new System.Windows.Forms.Button();
            this.btnDogadanja = new System.Windows.Forms.Button();
            this.lblMjerenje = new System.Windows.Forms.Label();
            this.txtBoxMjerenje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNovoMjerenje = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewPregledi = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBiljeske)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPregledi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDobrodosli
            // 
            this.lblDobrodosli.AutoSize = true;
            this.lblDobrodosli.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
            this.lblDobrodosli.Location = new System.Drawing.Point(45, 29);
            this.lblDobrodosli.Name = "lblDobrodosli";
            this.lblDobrodosli.Size = new System.Drawing.Size(181, 39);
            this.lblDobrodosli.TabIndex = 0;
            this.lblDobrodosli.Text = "Dobrodošli";
            // 
            // dataGridViewBiljeske
            // 
            this.dataGridViewBiljeske.AllowUserToAddRows = false;
            this.dataGridViewBiljeske.AllowUserToDeleteRows = false;
            this.dataGridViewBiljeske.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBiljeske.Location = new System.Drawing.Point(320, 109);
            this.dataGridViewBiljeske.Name = "dataGridViewBiljeske";
            this.dataGridViewBiljeske.ReadOnly = true;
            this.dataGridViewBiljeske.Size = new System.Drawing.Size(450, 127);
            this.dataGridViewBiljeske.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Moje bilješke";
            // 
            // btnDodajBiljesku
            // 
            this.btnDodajBiljesku.Location = new System.Drawing.Point(645, 242);
            this.btnDodajBiljesku.Name = "btnDodajBiljesku";
            this.btnDodajBiljesku.Size = new System.Drawing.Size(125, 27);
            this.btnDodajBiljesku.TabIndex = 3;
            this.btnDodajBiljesku.Text = "Dodaj novu bilješku";
            this.btnDodajBiljesku.UseVisualStyleBackColor = true;
            this.btnDodajBiljesku.Click += new System.EventHandler(this.btnDodajBiljesku_Click);
            // 
            // btnObveze
            // 
            this.btnObveze.Location = new System.Drawing.Point(52, 115);
            this.btnObveze.Name = "btnObveze";
            this.btnObveze.Size = new System.Drawing.Size(104, 32);
            this.btnObveze.TabIndex = 4;
            this.btnObveze.Text = "Moje obaveze";
            this.btnObveze.UseVisualStyleBackColor = true;
            this.btnObveze.Click += new System.EventHandler(this.btnObveze_Click);
            // 
            // btnImenadjece
            // 
            this.btnImenadjece.Location = new System.Drawing.Point(52, 166);
            this.btnImenadjece.Name = "btnImenadjece";
            this.btnImenadjece.Size = new System.Drawing.Size(104, 31);
            this.btnImenadjece.TabIndex = 5;
            this.btnImenadjece.Text = "Imena djece";
            this.btnImenadjece.UseVisualStyleBackColor = true;
            this.btnImenadjece.Click += new System.EventHandler(this.btnImenadjece_Click);
            // 
            // btnDogadanja
            // 
            this.btnDogadanja.Location = new System.Drawing.Point(52, 217);
            this.btnDogadanja.Name = "btnDogadanja";
            this.btnDogadanja.Size = new System.Drawing.Size(104, 34);
            this.btnDogadanja.TabIndex = 6;
            this.btnDogadanja.Text = "Događanja u trudnoći";
            this.btnDogadanja.UseVisualStyleBackColor = true;
            // 
            // lblMjerenje
            // 
            this.lblMjerenje.AutoSize = true;
            this.lblMjerenje.Location = new System.Drawing.Point(198, 507);
            this.lblMjerenje.Name = "lblMjerenje";
            this.lblMjerenje.Size = new System.Drawing.Size(157, 13);
            this.lblMjerenje.TabIndex = 7;
            this.lblMjerenje.Text = "Još nema evidentiranih mjerenja";
            this.lblMjerenje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBoxMjerenje
            // 
            this.txtBoxMjerenje.Location = new System.Drawing.Point(30, 467);
            this.txtBoxMjerenje.Name = "txtBoxMjerenje";
            this.txtBoxMjerenje.Size = new System.Drawing.Size(57, 20);
            this.txtBoxMjerenje.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "kg";
            // 
            // btnNovoMjerenje
            // 
            this.btnNovoMjerenje.Location = new System.Drawing.Point(30, 494);
            this.btnNovoMjerenje.Name = "btnNovoMjerenje";
            this.btnNovoMjerenje.Size = new System.Drawing.Size(82, 39);
            this.btnNovoMjerenje.TabIndex = 11;
            this.btnNovoMjerenje.Text = "Upiši novo mjerenje";
            this.btnNovoMjerenje.UseVisualStyleBackColor = true;
            this.btnNovoMjerenje.Click += new System.EventHandler(this.btnNovoMjerenje_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 507);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Trenutno:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridViewPregledi
            // 
            this.dataGridViewPregledi.AllowUserToAddRows = false;
            this.dataGridViewPregledi.AllowUserToDeleteRows = false;
            this.dataGridViewPregledi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPregledi.Location = new System.Drawing.Point(320, 311);
            this.dataGridViewPregledi.Name = "dataGridViewPregledi";
            this.dataGridViewPregledi.ReadOnly = true;
            this.dataGridViewPregledi.Size = new System.Drawing.Size(450, 150);
            this.dataGridViewPregledi.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Moji pregledi";
            // 
            // PacijentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewPregledi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNovoMjerenje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxMjerenje);
            this.Controls.Add(this.lblMjerenje);
            this.Controls.Add(this.btnDogadanja);
            this.Controls.Add(this.btnImenadjece);
            this.Controls.Add(this.btnObveze);
            this.Controls.Add(this.btnDodajBiljesku);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewBiljeske);
            this.Controls.Add(this.lblDobrodosli);
            this.Name = "PacijentForm";
            this.Text = "Pacijent";
            this.Load += new System.EventHandler(this.PacijentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBiljeske)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPregledi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDobrodosli;
        private System.Windows.Forms.DataGridView dataGridViewBiljeske;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDodajBiljesku;
        private System.Windows.Forms.Button btnObveze;
        private System.Windows.Forms.Button btnImenadjece;
        private System.Windows.Forms.Button btnDogadanja;
        private System.Windows.Forms.Label lblMjerenje;
        private System.Windows.Forms.TextBox txtBoxMjerenje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNovoMjerenje;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewPregledi;
        private System.Windows.Forms.Label label4;
    }
}