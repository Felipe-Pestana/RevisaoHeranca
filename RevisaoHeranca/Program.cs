using System;

namespace RevisaoHeranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ClientePF pf1 = new ClientePF();
            pf1.ImprimirCadastro(pf1);

            string AlteraEndereco()
            {
                Console.WriteLine("Informe o novo endereço: ");
                string novo = Console.ReadLine();
                return novo;
            }


            string x = AlteraEndereco();
            pf1.DefinirEndereco(x);

            pf1.ImprimirCadastro(pf1);
            
            
            //pf1.CadastrarCliente(pf1);
                
            //ClientePJ pj1 = new ClientePJ();

            //Console.Write("Informe o nome de cadastro da PF: ");
            //pf1.Nome = Console.ReadLine();

            //Console.Write("Informe o telefone de cadastro da PF: ");
            //pf1.Telefone = Console.ReadLine();

            //Console.Write("Informe o endereço de cadastro da PF: ");
            //pf1.Endereco = Console.ReadLine();

            //Console.Write("Informe o data de nascimento da PF: ");
            //pf1.Data = DateTime.Parse(Console.ReadLine());

            //Console.Write("Informe o CPF de cadastro da PF: ");
            //pf1.CPF = long.Parse(Console.ReadLine());

            //Console.Write("Informe o RG de cadastro da PF: ");
            //pf1.RG = Console.ReadLine();

            //Console.Write("Informe o sexo de cadastro da PF: ");
            //pf1.Sexo = char.Parse(Console.ReadLine());

            //Console.WriteLine(pf1.ImprimirCadastro());

            //Console.WriteLine(pf1.Nome);
            //Console.WriteLine(pf1.Telefone);
            //Console.WriteLine(pf1.Endereco);
            //Console.WriteLine(pf1.Data);
            //Console.WriteLine(pf1.CPF);
            //Console.WriteLine(pf1.RG);
            //Console.WriteLine(pf1.Sexo);
        }
    }
}
