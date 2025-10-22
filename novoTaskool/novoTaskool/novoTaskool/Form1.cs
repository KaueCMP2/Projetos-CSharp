using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace novoTaskool
{
    public partial class FormPrincipal : Form
    {
        bool capsAtivo = false;
        // Formula Selecionar imagem
        bool imagemSelecionada;
        byte[] imagemBytes;
        private Image SelecionarImagem()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecione Imagem";
            ofd.Filter = "Tipo de Imagem | *.png; *.jpg;";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imagemSelecionada = true;
                imagemBytes = File.ReadAllBytes(ofd.FileName);
                return Image.FromFile(ofd.FileName);
            }
            return null;
        }

        public FormPrincipal()
        {
            InitializeComponent();
                if (Console.CapsLock)
                {
                    lblCaps.Visible = true;
                }

                else if (!Console.CapsLock)
                {
                    lblCaps.Visible = false;
                }
        }

        private void btCred_Click(object sender, EventArgs e)
        {
            Image imagemlocal = SelecionarImagem();
            if (imagemlocal != null)
            {
                btCred.Image = imagemlocal;
                btCred.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                SystemSounds.Beep.Play();
                MessageBox.Show("Voce precisa selecionar alguma imagem", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            Fundo.Visible = true;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            Fundo.Visible = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Console.CapsLock)
            {
                lblCaps.Visible = true;
            }
            else
            {
                lblCaps.Visible = false;
            }
        }
    }
}
