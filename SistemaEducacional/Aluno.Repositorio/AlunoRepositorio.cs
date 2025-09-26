using Gestao.Dominio;
namespace Gestao.Repositorio
{
    public class AlunoRepositorio : IAlunoRepositorio
    {
        private readonly AlunoDbContext _context;
        public AlunoRepositorio(AlunoDbContext contexto)
        {
            _context = contexto;
        }
        public void Adicionar(Aluno aluno)
        {
            _context.Alunos.Add(aluno);
            _context.SaveChanges();
        }
        public List<Aluno> Listar()
        {
            return _context.Alunos.ToList();
        }
        public void Atualizar(Aluno aluno)
        {
            _context.Alunos.Update(aluno);
            _context.SaveChanges();
        }
        public void Remover(int id)
        {
            var RemoverAluno = new Aluno { Id = id };
            _context.Alunos.Remove(RemoverAluno);
            _context.SaveChanges();
        }
    }
}
