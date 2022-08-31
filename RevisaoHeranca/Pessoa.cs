using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoHeranca
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; } //aqui começa o xablau!
        public DateTime Data { get; set; }

        public Pessoa()
        {

        }
    }
}
