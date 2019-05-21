namespace Ammamentar.Domain
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string PontoReferencia { get; set; }

        // Fazendo referencia a classe Pessoa
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get;}
    }
}