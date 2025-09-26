using Gestao.Dominio;

namespace Gestao.Repositorio
{
    public interface IAlunoRepositorio
    {
        void Adicionar(Aluno aluno);
        List<Aluno> Listar();
        void Atualizar(Aluno aluno);
        void Remover(int id);

    }
}
