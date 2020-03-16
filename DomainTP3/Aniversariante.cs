using System;

namespace DomainTP3
{
    public class Aniversariante
    {
        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        public DateTime DataNascimento { get; set; }

        public Aniversariante(string nome, string sobrenome, DateTime data)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = data;

        }

        public TimeSpan CalcularDiasParaAniversario()
        {
            var dataAniversarioAnoPresente = new DateTime(DateTime.Now.Year, DataNascimento.Month, DataNascimento.Day);
            return dataAniversarioAnoPresente - DateTime.Now.Date;
        }

    }
}
