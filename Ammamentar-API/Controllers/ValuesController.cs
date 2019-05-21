using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Ammamentar.Repository;

namespace Ammamentar.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public readonly AmmamentarContext _context;
        public ValuesController(AmmamentarContext context)
        {
            _context = context;

        }
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {

            // Metodo que vai passar o Model completo
            try
            {
                var results = await _context.Pessoas.ToListAsync(); // A cada Chamada sera Criada uma instancia
                                                                    // E a cada chamada vai ter uma (await)Espera
                                                                    // Melhorar para não travar o recurso, com muitos dados
                return Ok(results);
            }
            catch (System.Exception)
            {

                
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dado Falhou");
            }
            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {   // Metodo que vai passar o model atraves do id
            try
            {
                
                var results = await _context.Pessoas.FirstOrDefaultAsync(x => x.Id == id); // A cada Chamada sera Criada uma instancia
                                                                    // E a cada chamada vai ter uma (await)Espera
                                                                    // Melhorar para não travar o recurso, com muitos dados
                return Ok(results);
            }
            catch (System.Exception)
            {

                
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco de dado Falhou"); // Retorna o espesifico
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
