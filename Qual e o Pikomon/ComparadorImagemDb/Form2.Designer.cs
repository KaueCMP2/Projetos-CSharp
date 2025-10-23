namespace ComparadorImagemDb
{
    partial class Form2
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFraq = new System.Windows.Forms.TextBox();
            this.pnOp = new System.Windows.Forms.Panel();
            this.btOp = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imgPik = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.pnOp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPik)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Pikomon";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 50);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(187, 20);
            this.txtNome.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTipo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFraq);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtVant);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 209);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(580, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tipo Pikomon";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(583, 50);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(187, 20);
            this.txtTipo.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vantagem";
            // 
            // txtVant
            // 
            this.txtVant.Location = new System.Drawing.Point(123, 183);
            this.txtVant.Name = "txtVant";
            this.txtVant.Size = new System.Drawing.Size(187, 20);
            this.txtVant.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fraquesa";
            // 
            // txtFraq
            // 
            this.txtFraq.Location = new System.Drawing.Point(428, 183);
            this.txtFraq.Name = "txtFraq";
            this.txtFraq.Size = new System.Drawing.Size(187, 20);
            this.txtFraq.TabIndex = 1;
            // 
            // pnOp
            // 
            this.pnOp.Controls.Add(this.button2);
            this.pnOp.Location = new System.Drawing.Point(673, 53);
            this.pnOp.Name = "pnOp";
            this.pnOp.Size = new System.Drawing.Size(122, 45);
            this.pnOp.TabIndex = 4;
            this.pnOp.Visible = false;
            // 
            // btOp
            // 
            this.btOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btOp.Location = new System.Drawing.Point(720, 23);
            this.btOp.Name = "btOp";
            this.btOp.Size = new System.Drawing.Size(75, 23);
            this.btOp.TabIndex = 0;
            this.btOp.Text = "Opções";
            this.btOp.UseVisualStyleBackColor = false;
            this.btOp.Click += new System.EventHandler(this.btOp_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(3, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Sair";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imgPik
            // 
            this.imgPik.Location = new System.Drawing.Point(301, 23);
            this.imgPik.Name = "imgPik";
            this.imgPik.Size = new System.Drawing.Size(200, 200);
            this.imgPik.TabIndex = 3;
            this.imgPik.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btOp);
            this.Controls.Add(this.pnOp);
            this.Controls.Add(this.imgPik);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Principal";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnOp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgPik)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFraq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVant;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox imgPik;
        private System.Windows.Forms.Panel pnOp;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btOp;
    }
}