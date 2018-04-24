using System;
using System.Collections.Generic;
using System.Text;

namespace Classe_Interfaces
{
    class Temporarios : Professor
    {
        public DateTime DataInícioContrato { get; set; }
        public DateTime DataTérminoContrato { get; set; }

        public override void MostrarDados()
        {
           Console.WriteLine($"Nome: {this.Nome}");
           Console.WriteLine($"Disciplina: {this.Disciplina}");
           Console.WriteLine($"Data Início Contrato: {this.DataInícioContrato.Day}/{this.DataInícioContrato.Month}/{this.DataInícioContrato.Year}");
           Console.WriteLine($"Data Término Contrato: {this.DataTérminoContrato.Day}/{this.DataTérminoContrato.Month}/{this.DataTérminoContrato.Year}");

        }

      
    }
}
 