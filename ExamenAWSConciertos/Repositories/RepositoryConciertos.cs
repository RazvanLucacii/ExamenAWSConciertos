using ExamenAWSConciertos.Data;
using ExamenAWSConciertos.Models;
using Microsoft.EntityFrameworkCore;

namespace ExamenAWSConciertos.Repositories
{
    public class RepositoryConciertos
    {
        private ConciertosContext context;

        public RepositoryConciertos(ConciertosContext context)
        {
            this.context = context;
        }

        public async Task<List<Evento>> GetEventosAsync()
        {
            return await this.context.Eventos.ToListAsync();
        }

        public async Task<List<Evento>> GetEventoAsync(int idcategoria)
        {
            return await this.context.Eventos.Where(x => x.IdCategoria == idcategoria).ToListAsync();
        }

        public async Task<List<Categoria>> GetCategoriasAsync()
        {
            return await this.context.Categorias.ToListAsync();
        }
    }
}
