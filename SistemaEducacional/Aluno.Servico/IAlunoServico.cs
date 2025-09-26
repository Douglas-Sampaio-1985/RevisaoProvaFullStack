using Gestao.Dominio;

namespace Gestao.Servico
{
    public interface IAlunoServico
    {
        void Adicionar(Aluno aluno);
        List<Aluno> Listar();
        void Atualizar(Aluno aluno);
        void Remover(int id);
    }
}
