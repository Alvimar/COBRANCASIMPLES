using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CobrancaSimples.Code
{
    public class Historico
    {
        public Historico() { }

        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Evento { get; set; }
        public string Descricao { get; set;}

        public int IdCobranca { get; set;}
    }
}
