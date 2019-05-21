using System;
using System.Collections.Generic;

namespace Ammamentar.Domain
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Cpf { get; set; }
        public string Rg { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public int RegistroAtivo { get; set; }
        public DateTime DataCadastro { get; set; }
        public List<Endereco> Enderecos { get; set; }
    }
}