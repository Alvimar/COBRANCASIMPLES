using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobrancaSimples.Code
{
    public class Cobranca
    {
        public Cobranca() { }

        public int Id { get; set; }
        public string Numero { get; set; }
        public string Autor { get; set;}
        public string Reu { get; set; }
        public float? ValorDaCausa { get; set; }
        public float? ValorAtualizado { get; set; }

        //public List<Historico> Ocorrencias { get; }
    }
}
