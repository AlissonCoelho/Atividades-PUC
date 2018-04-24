using System;

namespace Classe_Interfaces
{
    class Principal
    {
        static void Main(string[] args)
        {
            Contratados MeusContratados = new Contratados();
            Temporarios MeusTemporarios = new Temporarios();

            Console.WriteLine("Digite o Nome do Professor Contratado:");
            MeusContratados.Nome = Console.ReadLine();

            Console.WriteLine("Digite a Disciplina do Professor Contratado:");
            MeusContratados.Disciplina = Console.ReadLine();

            
            MeusContratados.Datanascimento = Datas("do Nascimento do Professor Contratado:");

            MeusContratados.DataAdmissão = Datas("da Admissão do Professor Contratado:");

            Console.Clear();

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("Digite o Nome do Professo Temporario:");
            MeusTemporarios.Nome = Console.ReadLine();

            Console.WriteLine("Digite a Disciplina do Professo Temporario:");
            MeusTemporarios.Disciplina = Console.ReadLine();

            MeusTemporarios.Datanascimento = Datas("do Nascimento do Professor Temporario");

            MeusTemporarios.DataInícioContrato = Datas("do inicio do Professor Temporario:");


            TimeSpan Time;
            do
            {
                MeusTemporarios.DataTérminoContrato = Datas("do Termino do Professor Temporario:");
                Time = MeusTemporarios.DataTérminoContrato - MeusTemporarios.DataInícioContrato;
                Console.WriteLine(Time.Days < 60 ? "Tempo de Contrato tem que ser Maior que 60 dias": $"Tempo de Contrato:{Time.Days}");
            } while (Time.Days < 60);

            Console.Clear();

            Console.WriteLine("Dados Referente ao Professor Contratado");
            MeusContratados.MostrarDados();
            Console.WriteLine("Dia e mês do Aniversario do professor contratado: " + MeusContratados.MostrarAniversario());

            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("Dados Referente ao Professor Temporario");
            MeusTemporarios.MostrarDados();
            Console.WriteLine("Mês do Aniversario do professor temporario: " + MeusTemporarios.MostrarAniversario()); 

            Console.ReadKey();
        }

        public static DateTime Datas(string Text)
        {
            Console.WriteLine("Digite o Dia " + Text);
            var Dia = Console.ReadLine();
            Console.WriteLine("Digite o Mês " + Text);
            var Mês = Console.ReadLine();
            Console.WriteLine("Digite o Ano " + Text);
            var Ano = Console.ReadLine();
            return new DateTime(int.Parse(Ano), int.Parse(Mês), int.Parse(Dia));
        }

    }
}
