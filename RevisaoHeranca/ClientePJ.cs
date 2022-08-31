using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoHeranca
{
    internal class ClientePJ : Pessoa
    {
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string InsEst { get; set; }

        public ClientePJ()
        {

        }
    }
}
