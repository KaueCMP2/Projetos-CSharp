using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frases
{
    public class Frase
    {
        [JsonPropertyName("mensagem")]
        public string Mensagem { get; set; }

        [JsonPropertyName("autor")]
        public string Autor { get; set; }

    }

    public partial class Form1 : Form
    {
        private List<Frase> frases;
        public Form1()
        {
            InitializeComponent();
            CarregarFrases();
            MostrarFraseAleatoria();
        }

        private void CarregarFrases()
        {
            string json = File.ReadAllText(@"C:\Users\KaueCMP2\Documents\Projetos C#\NovoTaskool100%\ArquivoGuia\1 - Desktop - S1 Nacional 2018\sessao_1\DataFilesS01\mensagens.json");

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

        }

        public void MostrarFraseAleatoria()
        {
            if (frases == null || frases.Count == 0)
            {
                label1.Text = "Nenhuma frase encontrarda";
                return;
            }

            Random rnd = new Random();
            var fraseAleatoria = frases[rnd.Next(frases.Count)];
            label1.Text = $"\"{fraseAleatoria.Mensagem}\"\n-{fraseAleatoria.Autor}";
        }
    }
}
