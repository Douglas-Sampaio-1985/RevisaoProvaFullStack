using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestao.Dominio
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public float Nota { get; set; }
        public bool EstaAprovado()
        {
            return this.Nota >= 7;
        }
    }
}
