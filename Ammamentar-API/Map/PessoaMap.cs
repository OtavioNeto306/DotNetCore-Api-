using Ammamentar.API.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ammamentar.API.Map

{
    public class PessoaMap
    {
           public PessoaMap(EntityTypeBuilder<Pessoa> etbPessoa)
        {
            etbPessoa.HasKey(tbPessoa => tbPessoa.PessoaId);

            //etbPessoa.HasMany(tbPessoa => tbPessoa.ListaManuais)
              //  .WithOne(tbManu => tbManu.Pessoa)
                //.HasForeignKey(tbManu => tbManu.IdPessoa);
        }
    }
}