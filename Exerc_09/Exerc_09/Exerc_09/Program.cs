using System;

namespace Exerc_09
{
    class Program
    {
        static void Main(string[] args)
        {
            #region declarações & instâncias
            Calculo s;
            s = new Calculo();
            #endregion

            #region Introducao
            Console.Write("Descubra qual o Maior Numero, ou se eles sao iguais");
            Console.ReadLine();
            #endregion

            #region entrada
            Console.Write("Informe o 1° numero: ");
            s.setNum1(int.Parse(Console.ReadLine()));

            Console.Write("Informe o 2° numero: ");
            s.setNum2(int.Parse(Console.ReadLine()));
            #endregion

            #region processo
            s.calcular();
            #endregion

        }
    }
}