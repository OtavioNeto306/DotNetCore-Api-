using System.Collections.Generic;

namespace Ammamentar.API.Model
{
    public class Pessoa
    {
        public int PessoaId { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string endereco { get; set; }
        public string rua { get; set; }
        public string numero { get; set; }
        public string telefone { get; set; }
        public string celular { get; set; }
        public int registroAtivo { get; set; }
    }
}