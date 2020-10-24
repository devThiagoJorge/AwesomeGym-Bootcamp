using AwesomeGymAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeGymAPI.Models
{
    public class Professor
    {
        protected Professor()
        {

        }
        public Professor(string nome, string endereco)
        {
            Nome = nome;
            Endereco = endereco;
            Status = StatusProfessor.Ativo;
            Alunos = new List<Aluno>();
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public StatusProfessor Status { get; private set; }
        public List<Aluno> Alunos { get; private set; }

        public int IdUnidade { get; private set; }
        public Unidade Unidade { get; private set; }
    }
}
