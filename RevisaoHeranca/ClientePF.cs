using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoHeranca
{
    internal class ClientePF : Pessoa
    {
        public long CPF { get; set; }
        public string RG { get; set; }
        public char Sexo { get; set; }

        public  ClientePF()
        {
            Console.Write("Informe o nome de cadastro da PF: ");
            this.Nome = Console.ReadLine();

            Console.Write("Informe o telefone de cadastro da PF: ");
            this.Telefone = Console.ReadLine();

            Console.Write("Informe o endereço de cadastro da PF: ");
            this.Endereco = Console.ReadLine();

            Console.Write("Informe o data de nascimento da PF: ");
            this.Data = DateTime.Parse(Console.ReadLine());

            Console.Write("Informe o CPF de cadastro da PF: ");
            this.CPF = long.Parse(Console.ReadLine());

            Console.Write("Informe o RG de cadastro da PF: ");
            this.RG = Console.ReadLine();

            Console.Write("Informe o sexo de cadastro da PF: ");
            this.Sexo = char.Parse(Console.ReadLine());
        }

        public void ImprimirCadastro(ClientePF c)
        {
            Console.WriteLine("Nome: "+c.Nome);
            Console.WriteLine(c.Telefone);
            Console.WriteLine(c.Endereco);
            Console.WriteLine(c.Data);
            Console.WriteLine(c.CPF);
            Console.WriteLine(c.RG);
            Console.WriteLine(c.Sexo);

        }

       public void DefinirEndereco (string end)
        {
            this.Endereco = end;
        }
    }
}
