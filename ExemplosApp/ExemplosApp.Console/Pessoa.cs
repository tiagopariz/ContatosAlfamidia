﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemplosAppConsole
{
    public class Pessoa
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }

        public List<Telefone> Telefones { get; set; }
        public List<Email> Emails { get; set; }

        public string NomeCompleto(string nome, string sobrenome)
        {
            return nome + " " + sobrenome;
        }
    }
}