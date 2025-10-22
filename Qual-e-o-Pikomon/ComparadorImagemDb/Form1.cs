using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComparadorImagemDb
{
    public partial class Form1 : Form
    {
        bool imagemSelecionada = false;
        byte[] imagemBytes;
        private Image SelecionarImagem()
        {
            OpenFileDialog opf = new OpenFileDialog();

            opf.Title = "Selecionar imagem";
            opf.Filter = "Filtro de Image | *.png;*.jpg;";

            if (opf.ShowDialog() == DialogResult.OK)
            {
                imagemSelecionada = true;
                imagemBytes = File.ReadAllBytes(opf.FileName);
                return Image.FromFile(opf.FileName);
            }

            return null;

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btSelecionarImg_Click(object sender, EventArgs e)
        {
           Image imagemEscolhida = SelecionarImagem();

            if(imagemEscolhida != null)
            {
                btSelecionarImg.Image = imagemEscolhida;
                btSelecionarImg.BackgroundImageLayout = ImageLayout.Stretch;
            }                    
        }
    }
}
