using System;

namespace Questão_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de A");
            var A = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de B");
            var B = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de C");
            var C = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine($"y = {A}x² + {B}x + {C}");
            Console.WriteLine();
            Console.WriteLine();

            Eq2Grau Equação = new Eq2Grau();
            var Delta = Equação.CalcularDelta(A, B, C);
            var vetor = Equação.CalcularRaizes(B, A, Delta);


            if (vetor.Length == 2)
            {
                Console.WriteLine($"Raiz 1 = {vetor[0]}");
                Console.WriteLine($"Raiz 2 = {vetor[1]}");
            }
            else
            {
                Console.WriteLine($"Raiz 1 em Polar = {vetor[0]}<{vetor[1]}");
                Console.WriteLine($"Raiz 2 em Polar = {vetor[2]}<{vetor[3]}");

                Console.WriteLine("Raiz 1 em Cartesiano = {0:N2} + {1:F2}i", vetor[4], vetor[5]);
                Console.WriteLine("Raiz 2 em Cartesiano = {0} {1:F2}i", vetor[6], vetor[7]);
            }

            Console.ReadKey();


        }
    }
}
