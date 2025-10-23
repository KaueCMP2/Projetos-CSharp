using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparadorImagemDb
{
    public class CPikomon
    {
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string Vantagem { get; set; }
        public string Fraqueza { get; set; }
        public byte[] FotoPik { get; set; }

        public bool pikemonPesquisado;
    }
}
