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
    }
}
