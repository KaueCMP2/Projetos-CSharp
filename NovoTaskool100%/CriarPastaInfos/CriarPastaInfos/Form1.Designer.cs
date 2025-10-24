namespace novoTaskool100_
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
            this.btTeste = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btTeste
            // 
            this.btTeste.Location = new System.Drawing.Point(86, 82);
            this.btTeste.Name = "btTeste";
            this.btTeste.Size = new System.Drawing.Size(253, 112);
            this.btTeste.TabIndex = 0;
            this.btTeste.Text = "Teste";
            this.btTeste.UseVisualStyleBackColor = true;
            this.btTeste.Click += new System.EventHandler(this.btTeste_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(280, 20);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 253);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btTeste);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btTeste;
        private System.Windows.Forms.TextBox textBox1;
    }
}

