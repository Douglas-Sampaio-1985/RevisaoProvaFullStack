using Gestao.Dominio;
using Gestao.Repositorio;

namespace Gestao.Servico
{
    public class AlunoServico : IAlunoServico
    {
        private readonly IAlunoRepositorio _repositorio;

        public AlunoServico(IAlunoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Adicionar(Aluno aluno)
        {
            if (string.IsNullOrWhiteSpace(aluno.Nome))
                throw new Exception("O nome do aluno é obrigatório.");

            _repositorio.Adicionar(aluno);
        }

        public List<Aluno> Listar()
        {
            return _repositorio.Listar();
        }

        public void Atualizar(Aluno aluno)
        {
            // Regra de negócio: não permitir que um aluno seja atualizado para um nome vazio.
            if (string.IsNullOrWhiteSpace(aluno.Nome))
                throw new Exception("O nome do aluno é obrigatório na atualização.");

            _repositorio.Atualizar(aluno);
        }

        public void Remover(int id)
        {
            _repositorio.Remover(id);
        }
    }
}
