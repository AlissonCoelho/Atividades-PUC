using System;
using System.Collections.Generic;
using System.Text;

namespace Classe_Interfaces
{
    class Contratados:Professor
    {
        public DateTime DataAdmissão { get; set; }

        public override void MostrarDados()
        {
            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"Disciplina: {this.Disciplina}");
            Console.WriteLine($"Data Admissão: {this.DataAdmissão.Day}/{this.DataAdmissão.Month}/{this.DataAdmissão.Year}");
        }

        public override string MostrarAniversario()
        {
            return Datanascimento.Day +" de " + base.MostrarAniversario();
        }

    }
}
