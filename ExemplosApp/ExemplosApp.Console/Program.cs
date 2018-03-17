using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosAppConsole
{
    public static class Program
    {
        static void Main(string[] args)
        {
            // Início
            Console.WriteLine("MEU APLICATIVO\n\n");

            var idade = 18;
            var nomePessoa = "João";
            string nomeDaMae;
            nomeDaMae = "Joana";
            int idadeDaMae;
            idadeDaMae = 42;

            Console.WriteLine("Nome: " + nomePessoa);
            Console.WriteLine("Idade: " + idade.ToString());
            Console.WriteLine("Mãe: " + nomeDaMae);
            Console.WriteLine("Idade: " + idadeDaMae);

            // Funções
            var sobrenome = "Silva";
            Console.WriteLine( "Nome completo: " + NomeCompleto(nomePessoa, sobrenome) );

            EscreveDiferencaIdade(idadeDaMae, idade);

            Console.WriteLine("\n----------------------------------\n");

            var pessoa = new Pessoa();
            pessoa.Nome = "Pedro";
            pessoa.Sobrenome = "Santana";
            pessoa.Cpf = "84646465113";

            // Telefones
            pessoa.Telefones = new List<Telefone>();
            AdicionarTelefone(pessoa, "+55 51 3333-4444");
            AdicionarTelefone(pessoa, "+55 51 99999-9999");
            AdicionarTelefone(pessoa, "+55 51 33333-55555");
            AdicionarTelefone(pessoa, "+55 51 33333-555999");
            AdicionarTelefone(pessoa, "+55 51 33333-55464");

            // Emails
            pessoa.Emails = new List<Email>();
            AdicionarEmail(pessoa, "tinono@hhh");
            AdicionarEmail(pessoa, "fgfdgdf@hhh.bb");
            AdicionarEmail(pessoa, "gfdgdf@lil.bb");
            AdicionarEmail(pessoa, "jjjjj@cvom.pt");
            AdicionarEmail(pessoa, "hjhkjhk@hhh.ps");

            // Logradouros
            pessoa.Logradouros = new List<Logradouro>();
            AdicionarLogradouro(pessoa, "Rua A", "110");
            AdicionarLogradouro(pessoa, "Rua B", "111");
            AdicionarLogradouro(pessoa, "Rua C", "112");

            Console.WriteLine($"Nome: {pessoa.Nome}\nCPF: {pessoa.Cpf}");

            Console.WriteLine("Nome completo: {0}",
                              pessoa.NomeCompleto(pessoa.Nome,
                                                  pessoa.Sobrenome));

            EscreveNumeros(pessoa);
            EscreveEmail(pessoa);
            EscreveLogradouros(pessoa);

            Console.ReadKey();
        }

        static string NomeCompleto(string primeiro, string sobrenome)
        {
            return primeiro + " " + sobrenome;
        }

        static void EscreveDiferencaIdade(int idadeMaisVelho, int idadeMaisNovo)
        {
            Console.WriteLine("Diferença: " + (idadeMaisVelho - idadeMaisNovo).ToString());
        }

        public static void AdicionarTelefone(Pessoa pessoa, 
                                             string telefone)
        {
            var objetoTelefone = new Telefone();
            objetoTelefone.Numero = telefone;
            pessoa.Telefones.Add(objetoTelefone);
        }

        public static void AdicionarEmail(Pessoa pessoa,
                                          string endereco)
        {
            var objetoEmail = new Email();
            objetoEmail.Endereco = endereco;
            pessoa.Emails.Add(objetoEmail);
        }

        public static void AdicionarLogradouro(Pessoa pessoa,
                                               string rua,
                                               string numero)
        {
            var objetoLogradouro = new Logradouro();
            objetoLogradouro.Rua = rua;
            objetoLogradouro.Numero = numero;
            pessoa.Logradouros.Add(objetoLogradouro);
        }

        public static void EscreveNumeros(Pessoa pessoa)
        {
            for (int i = 0; i < pessoa.Telefones.Count(); i++)
            {
                Console.WriteLine($"Telefone {i + 1}: {pessoa.Telefones[i].Numero}");
            }           
        }

        public static void EscreveEmail(Pessoa pessoa)
        {
            Console.Write("Emails: ");
            foreach (Email item in pessoa.Emails)
            {
                Console.Write($"{item.Endereco},");
            }            
        }

        public static void EscreveLogradouros(Pessoa pessoa)
        {
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Logradouros: ");
            foreach (Logradouro item in pessoa.Logradouros)
            {
                Console.WriteLine($"Rua {item.Rua}, {item.Numero}");
            }
        }
    }
}