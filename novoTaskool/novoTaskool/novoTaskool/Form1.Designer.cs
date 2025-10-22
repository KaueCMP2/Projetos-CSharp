namespace novoTaskool
{
    partial class FormPrincipal
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
            this.lblUsu = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCred = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btTecVt = new System.Windows.Forms.LinkLabel();
            this.btIrCad = new System.Windows.Forms.LinkLabel();
            this.btCred = new System.Windows.Forms.Button();
            this.Btentar = new System.Windows.Forms.Button();
            this.Fundo = new System.Windows.Forms.DataGridView();
            this.lblCaps = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Fundo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsu
            // 
            this.lblUsu.AutoSize = true;
            this.lblUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsu.Location = new System.Drawing.Point(256, 126);
            this.lblUsu.Name = "lblUsu";
            this.lblUsu.Size = new System.Drawing.Size(61, 16);
            this.lblUsu.TabIndex = 0;
            this.lblUsu.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 69);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bem vindo";
            // 
            // lblCred
            // 
            this.lblCred.AutoSize = true;
            this.lblCred.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCred.Location = new System.Drawing.Point(246, 200);
            this.lblCred.Name = "lblCred";
            this.lblCred.Size = new System.Drawing.Size(82, 16);
            this.lblCred.TabIndex = 0;
            this.lblCred.Text = "Credencial";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(175, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // btTecVt
            // 
            this.btTecVt.AutoSize = true;
            this.btTecVt.Location = new System.Drawing.Point(401, 153);
            this.btTecVt.Name = "btTecVt";
            this.btTecVt.Size = new System.Drawing.Size(98, 16);
            this.btTecVt.TabIndex = 2;
            this.btTecVt.TabStop = true;
            this.btTecVt.Text = "Teclado Virtual";
            // 
            // btIrCad
            // 
            this.btIrCad.AutoSize = true;
            this.btIrCad.Location = new System.Drawing.Point(249, 422);
            this.btIrCad.Name = "btIrCad";
            this.btIrCad.Size = new System.Drawing.Size(85, 16);
            this.btIrCad.TabIndex = 2;
            this.btIrCad.TabStop = true;
            this.btIrCad.Text = "Cadastrar-se";
            // 
            // btCred
            // 
            this.btCred.Location = new System.Drawing.Point(229, 224);
            this.btCred.Name = "btCred";
            this.btCred.Size = new System.Drawing.Size(120, 115);
            this.btCred.TabIndex = 3;
            this.btCred.UseVisualStyleBackColor = true;
            this.btCred.Click += new System.EventHandler(this.btCred_Click);
            // 
            // Btentar
            // 
            this.Btentar.Location = new System.Drawing.Point(237, 384);
            this.Btentar.Name = "Btentar";
            this.Btentar.Size = new System.Drawing.Size(109, 35);
            this.Btentar.TabIndex = 3;
            this.Btentar.Text = "Entar";
            this.Btentar.UseVisualStyleBackColor = true;
            // 
            // Fundo
            // 
            this.Fundo.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.Fundo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Fundo.Location = new System.Drawing.Point(172, 143);
            this.Fundo.Name = "Fundo";
            this.Fundo.RowHeadersWidth = 51;
            this.Fundo.RowTemplate.Height = 24;
            this.Fundo.Size = new System.Drawing.Size(226, 28);
            this.Fundo.TabIndex = 4;
            this.Fundo.Visible = false;
            // 
            // lblCaps
            // 
            this.lblCaps.AutoSize = true;
            this.lblCaps.ForeColor = System.Drawing.Color.Red;
            this.lblCaps.Location = new System.Drawing.Point(238, 174);
            this.lblCaps.Name = "lblCaps";
            this.lblCaps.Size = new System.Drawing.Size(101, 16);
            this.lblCaps.TabIndex = 5;
            this.lblCaps.Text = "CapsLock Ativo";
            this.lblCaps.Visible = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.lblCaps);
            this.Controls.Add(this.Btentar);
            this.Controls.Add(this.btCred);
            this.Controls.Add(this.btIrCad);
            this.Controls.Add(this.btTecVt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCred);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblUsu);
            this.Controls.Add(this.Fundo);
            this.Name = "FormPrincipal";
            this.Text = "Principla | Taskool";
            ((System.ComponentModel.ISupportInitialize)(this.Fundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCred;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel btTecVt;
        private System.Windows.Forms.LinkLabel btIrCad;
        private System.Windows.Forms.Button btCred;
        private System.Windows.Forms.Button Btentar;
        private System.Windows.Forms.DataGridView Fundo;
        private System.Windows.Forms.Label lblCaps;
    }
}

