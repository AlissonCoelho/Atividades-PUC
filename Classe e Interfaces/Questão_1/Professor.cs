using System;
using System.Collections.Generic;
using System.Text;

namespace Classe_Interfaces
{
    public abstract class Professor
    {
        enum Mês { Janeiro, Fevereiro, Março, Abril, Maio, Junho, Julho, Agosto, Setembro, Outubro, Novembro, Dezembro }

        public string Nome { get; set; }
        public string Disciplina { get; set; }
        public DateTime Datanascimento { get; set; }

        public abstract void MostrarDados();

        public virtual string MostrarAniversario()
        {
            Mês Aniversario = (Mês)Datanascimento.Month;
            return Convert.ToString(Aniversario);
        }

    }
}
