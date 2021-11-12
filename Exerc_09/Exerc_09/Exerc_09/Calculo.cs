using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_09
{
    class Calculo
    {
        #region atributos
        private int num1;
        private int num2;
        #endregion

        #region construtores
        public Calculo()
        {
            this.num1 = 0;
            this.num2 = 0;
        }

        public Calculo(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }
        #endregion

        #region métodos de interface (Setter's & Getter's)
        public void setNum1(int num1)
        {
            this.num1 = num1;
        }

        public void setNum2(int num2)
        {
            this.num2 = num2;
        }

        public int getNum1()
        {
            return this.num1;
        }

        public int getNum2()
        {
            return this.num2;
        }
        #endregion

        #region métodos funcionais
        public void calcular()
        {
            if (this.num1 == this.num2)
            {
                Console.Write("Os números digitados são iguais");
            }

            else
            {
                if (this.num1 > this.num2)
                {
                    Console.Write("O número {0} é o maior entre eles", getNum1());
                }
                else
                {
                    Console.Write("O número {0} é o maior entre eles", getNum2());
                }
            }
        }
        #endregion
    }
}