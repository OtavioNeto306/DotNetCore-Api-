using System.Linq;
using System.Threading.Tasks;
using Ammamentar.Domain;
using Microsoft.EntityFrameworkCore;

namespace Ammamentar.Repository
{
    public class AmmamentarRepository : IAmmamentarRepository
    {
        private readonly AmmamentarContext _context;

        public AmmamentarRepository(AmmamentarContext context)
        {
            _context = context;

            _context.ChangeTracker.QueryTrackingBehavior =  QueryTrackingBehavior.NoTracking;
        }

        //Gereais
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

          public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }
          public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) >0;
        }


        //Pessoa
        public async Task<Pessoa[]> GetAllPessoaAsync()
        {
            IQueryable<Pessoa> query = _context.Pessoas
                .Include(c => c.Enderecos);

                query = query.AsNoTracking()
                .OrderByDescending(c => c.DataCadastro);
            return await query.ToArrayAsync();
        }

        public async Task<Pessoa[]> GetAllPessoaAsyncByNome(string nome)
        {
             IQueryable<Pessoa> query = _context.Pessoas
                .Include(c => c.Enderecos);

                query = query.AsNoTracking()
                .OrderByDescending(c => c.DataCadastro)
                .Where(c => c.Nome.ToLower().Contains(nome.ToLower()));
                query = query.Where(p => p.Nome.ToLower().Contains(nome.ToLower()));

            return await query.ToArrayAsync();


        }

        public async Task<Pessoa> GetPessoaAsyncById(int PessoaId)
        {
              IQueryable<Pessoa> query = _context.Pessoas
                .Include(c => c.Enderecos);

                query = query.AsNoTracking()
                .OrderByDescending(c => c.DataCadastro)
                .Where(c => c.Id == PessoaId);

            return await query.FirstOrDefaultAsync();
        }

      
      
    }
}