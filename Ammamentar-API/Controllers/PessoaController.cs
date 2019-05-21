using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Ammamentar.Domain;
using Microsoft.AspNetCore.Mvc;
using Ammamentar.Repository;

namespace Ammamentar_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IAmmamentarRepository _repo;

        public PessoaController(IAmmamentarRepository repo)
        {
            _repo = repo;

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            // Metodo que vai passar o Model completo
            try
            {
                var results = await _repo.GetAllPessoaAsync();
                return Ok(results);
            }
            catch (System.Exception)
            {

                
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dado Falhou");
            }
            
        }
         [HttpGet("{PessoaId}")]
        public async Task<IActionResult> Get(int PessoaId)
        {

            try
            {
                var results = await _repo.GetPessoaAsyncById(PessoaId);

                return Ok(results);
            }
            catch (System.Exception)
            {

                
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dado Falhou");
            }
            
        }
        [HttpGet("getByNome/{nome}")]
        public async Task<IActionResult> Get(string nome)
        {

            try
            {
                var results = await _repo.GetAllPessoaAsyncByNome(nome);
                
                return Ok(results);
            }
            catch (System.Exception)
            {

                
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dado Falhou");
            }
            
        }
        [HttpPost]
        public async Task<IActionResult> Post(Pessoa model)
        {

            try
            {
                _repo.Add(model);

                if(await _repo.SaveChangesAsync()){  

                    return Created($"/api/pessoa/{model.Id}",model);
                }

            }
            catch (System.Exception)
            {

                
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dado Falhou");
            }
                return BadRequest();
            
        }
        [HttpPut]
        public async Task<IActionResult> Put(int PessoaId,Pessoa model)
        {

            try
            {
                var pessoa = await _repo.GetPessoaAsyncById(PessoaId);
                if(pessoa == null) return NotFound();

                _repo.Update(model);

                if(await _repo.SaveChangesAsync()){  

                    return Created($"/api/pessoa/{model.Id}",model);
                }

            }
            catch (System.Exception)
            {

                
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dado Falhou");
            }
                return BadRequest();
            
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int PessoaId)
        {

            try
            {
                var pessoa = await _repo.GetPessoaAsyncById(PessoaId);
                if(pessoa == null) return NotFound();
                
                _repo.Delete(pessoa);

                if(await _repo.SaveChangesAsync()){  

                    return Ok();
                }

            }
            catch (System.Exception)
            {

                
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dado Falhou");
            }
                return BadRequest();
            
        }
    }
}