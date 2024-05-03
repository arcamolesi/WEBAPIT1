
using Microsoft.EntityFrameworkCore;

namespace WEBAPIT1
{
    public class Contexto: DbContext 
    {

        public Contexto(DbContextOptions<Contexto> options): base(options) { }
        
        public DbSet<Aluno> Alunos { get; set; }
    }
}
