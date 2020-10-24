using AwesomeGymAPI.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeGymAPI.Models
{
    public class Aluno
    {
        protected Aluno() { }
        public Aluno(string nome, string endereco, DateTime dataNasicmento)
        {
            Nome = nome;
            Endereco = endereco;
            DataNasicmento = dataNasicmento;
            Status = StatusAlunoEnum.Ativo;
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Endereco { get; private set; }
        public DateTime DataNasicmento { get; private set; }
        public StatusAlunoEnum Status { get; private set; }

        public int IdUnidade { get; private set; }

        public Unidade Unidade { get; private set; }

        public int IdProfessor { get; private set; }
        public Professor Professor { get; set; }
    }
}
