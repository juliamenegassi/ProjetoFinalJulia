using Microsoft.EntityFrameworkCore;

namespace ProjetoFinalJulia.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        //public DbSet<Paciente> Paciente { get; set; }
    }
}
