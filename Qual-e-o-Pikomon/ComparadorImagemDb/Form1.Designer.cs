namespace ComparadorImagemDb
{
    partial class Form1
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
            this.btEncontrar = new System.Windows.Forms.Button();
            this.btSelecionarImg = new System.Windows.Forms.Button();
            this.lblCadastrar = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btEncontrar
            // 
            this.btEncontrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btEncontrar.Location = new System.Drawing.Point(138, 251);
            this.btEncontrar.Name = "btEncontrar";
            this.btEncontrar.Size = new System.Drawing.Size(263, 75);
            this.btEncontrar.TabIndex = 0;
            this.btEncontrar.Text = "Pesquisar";
            this.btEncontrar.UseVisualStyleBackColor = false;
            // 
            // btSelecionarImg
            // 
            this.btSelecionarImg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSelecionarImg.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btSelecionarImg.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btSelecionarImg.Location = new System.Drawing.Point(139, 54);
            this.btSelecionarImg.Name = "btSelecionarImg";
            this.btSelecionarImg.Size = new System.Drawing.Size(365, 190);
            this.btSelecionarImg.TabIndex = 0;
            this.btSelecionarImg.UseVisualStyleBackColor = false;
            this.btSelecionarImg.Click += new System.EventHandler(this.btSelecionarImg_Click);
            // 
            // lblCadastrar
            // 
            this.lblCadastrar.AutoSize = true;
            this.lblCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastrar.Location = new System.Drawing.Point(177, 329);
            this.lblCadastrar.Name = "lblCadastrar";
            this.lblCadastrar.Size = new System.Drawing.Size(177, 18);
            this.lblCadastrar.TabIndex = 1;
            this.lblCadastrar.TabStop = true;
            this.lblCadastrar.Text = "Cadastrar Novo Pikomon";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCadastrar);
            this.groupBox1.Controls.Add(this.btEncontrar);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 369);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione um pikomon";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 450);
            this.Controls.Add(this.btSelecionarImg);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btEncontrar;
        private System.Windows.Forms.Button btSelecionarImg;
        private System.Windows.Forms.LinkLabel lblCadastrar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

