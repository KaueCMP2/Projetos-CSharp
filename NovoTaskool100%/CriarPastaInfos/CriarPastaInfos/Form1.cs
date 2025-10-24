using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace novoTaskool100_
{
    public partial class Form1 : Form
    {

        private string pegarIp()
        {
            // Obtem o nome do host local
            string nomeHost = Dns.GetHostName();
            IPHostEntry hostEntry = Dns.GetHostEntry(nomeHost);

            IPAddress ip = hostEntry.AddressList.FirstOrDefault(a => a.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
            return ip?.ToString();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btTeste_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {

                SystemSounds.Beep.Play();
                MessageBox.Show("Digite um nome de usuario", "Erro", MessageBoxButtons.OK);
                textBox1.Focus();
                return;
            }

            else
            {
                string nomeUsuario = textBox1.Text.ToLower(); // nomeUsuario recebe o conteudo da caixa de texto
                int id = new Random().Next(1, 100); // id é um objeto de recebe Randon.next que escolhe um numero aleatorio... 
                string ip = pegarIp(); // ip recebe o resultado de pegarIp();

                if (nomeUsuario != null) // se nomeUsuario != null
                {
                    string pasta = @"C:\USER_LOGS"; // pasta recebe o caminho do arquivo USER_LOGS; Todo caminho de arquivo vem com @ depois "";
                    if (!Directory.Exists(pasta)) // Diretory.Exists quer dizer, se o camnho da "pasta" existir
                        Directory.CreateDirectory(pasta); // Diretory.CreateDiretory(pasta) ou seja Crie o caminho de pasta

                    string caminhoArquivo = Path.Combine(pasta, $"{nomeUsuario}{id}.txt"); // caminhoArquivo que e uma variavel do tipo stirng
                                                                                           // recebe Path.Combine que como no nome possibilita
                                                                                           // combinar pastar sem dar erros
                                                                                           // E ai no caminho da pasta, $"{nomeUsuario} + {id}.txt"
                                                                                           //ou seja a variavel nome de usuario + id .txt
                                                                                           //sao o nome do arquivo gerado


                    bool novoArquivo = !File.Exists(caminhoArquivo); // gera uma variavel "novoArquivo" que recebe o contrario de File.Exists(caminhoArquivo)
                                                                     // ou seja se o arquivo nao existir retorna true e se existir false...
                    
                    //using garante que sera usado e fechado ao final do escopo
                    using (StreamWriter sw = new StreamWriter(caminhoArquivo, true)) //stremWriter e um escritor de arquivos...
                                                                                     // sw o objeto dele...
                                                                                     // (caminhoArquivo, true) quer dizer que:
                                                                                     // No caminhoArq, a edição esta ativa.
                    {
                        if (novoArquivo) // se novo arquivo nao existia... ele criar agora
                            sw.WriteLine(""); // sw é o objeto do StreamWriter... WriteLine("") basicamente pula uma linha

                        sw.WriteLine($"{DateTime.Now:dd/MM/yyyy};{DateTime.Now:HH:mm};{nomeUsuario};{ip}"); // entao excreve {data agora};{hora};{ip};
                    }
                }

                else
                {
                    return;
                }
            }

        }
    }
}
