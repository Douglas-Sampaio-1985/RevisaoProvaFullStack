using Gestao.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Gestao.Repositorio
{
    public class AlunoDbContext : DbContext
    {
        public AlunoDbContext(DbContextOptions<AlunoDbContext> options)
        : base(options)
        {
        }
        public DbSet<Aluno> Alunos { get; set; }
    }
}
