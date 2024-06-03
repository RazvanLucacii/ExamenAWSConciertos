using ExamenAWSConciertos.Models;
using ExamenAWSConciertos.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamenAWSConciertos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConciertosController : ControllerBase
    {
        private RepositoryConciertos repo;

        public ConciertosController(RepositoryConciertos repo)
        {
            this.repo = repo;
        }


        [HttpGet]
        public async Task<ActionResult<List<Evento>>> Get()
        {
            return await this.repo.GetEventosAsync();
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<ActionResult<List<Evento>>> Find(int id)
        {
            return await this.repo.GetEventoAsync(id);
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<List<Categoria>>> GetCategorias()
        {
            return await this.repo.GetCategoriasAsync();
        }

    }
}
