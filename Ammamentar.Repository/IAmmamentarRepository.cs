using System.Threading.Tasks;
using Ammamentar.Domain;

namespace Ammamentar.Repository
{
    public interface IAmmamentarRepository
    {
        // Os Metodos que a interface vai ter
         
         // Geral
         void Add<T>(T entity) where T : class;
         void Update<T>(T entity) where T : class;
         void Delete<T>(T entity) where T : class;

         Task<bool> SaveChangesAsync();
         
         // Cadastro
         Task<Pessoa[]> GetAllPessoaAsyncByNome(string nome);
         
         Task<Pessoa[]> GetAllPessoaAsync();
         
         Task<Pessoa> GetPessoaAsyncById(int PessoaId);
    }
}