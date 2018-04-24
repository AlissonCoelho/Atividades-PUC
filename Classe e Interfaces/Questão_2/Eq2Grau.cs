using System;
using System.Collections.Generic;
using System.Text;

namespace Questão_2
{
    class Eq2Grau : Raizes, Delta
    {
        public double CalcularDelta(double A, double B, double C)
        {
            return Math.Pow(B, 2) - (4 * A * C);
        }

        public double[] CalcularRaizes(double B, double A, double Delta)
        {
            double Raiz1 = 0;
            double Raiz2 = 0;

            double Angulo1 = 0;
            double Angulo2 = 0;
            double A1 = 0;
            double B1 = 0;
            double A2 = 0;
            double B2 = 0;
            double vetor;

            if (Delta >= 0)
            {

                Raiz1 = (-1 * B + Math.Sqrt(Delta)) / 2 * A;
                Raiz1 = (-1 * B - Math.Sqrt(Delta)) / 2 * A;

                return new double[2] { Raiz1, Raiz2 };
            }
            else
            {
                //Valor Polar (vetor<angulo)
                double xDelta = Delta * -1;
                double xB = B * -1;
                vetor = Math.Sqrt(Math.Pow(B, 2) + xDelta);
                Raiz2 = Raiz1 = vetor / 2 * A;

                var Angulo1RAD = Math.Atan2(Math.Sqrt(xDelta), xB);
                Angulo1 = (180 * Angulo1RAD) / Math.PI;

                var Angulo2RAD = Math.Atan2(-1 * Math.Sqrt(xDelta), xB);
                Angulo2 = (180 * Angulo2RAD) / Math.PI;

                //Valor Cartesiano (a + bi)
                A1 = Math.Cos(Angulo1RAD) * vetor;
                B1 = Math.Sin(Angulo1RAD) * vetor;

                A2 = Math.Cos(Angulo2RAD) * vetor;
                B2 = Math.Sin(Angulo2RAD) * vetor;

                return new double[8] { Raiz1, Angulo1, Raiz2, Angulo2, A1, B1, A2, B2 };
            }



        }


    }
}
