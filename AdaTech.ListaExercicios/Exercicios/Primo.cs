using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdaTech.ListaExercicios.Exercicios
{
    internal class Primo
    {
        private int _numero;
        internal int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        internal bool EhPrimo()
        {
            do
            {
                Console.Clear();
                Console.Write("Digite o número que deseja descobrir: ");
            } while (!int.TryParse(Console.ReadLine(), out _numero));

            if (_numero <= 1)  
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(_numero); i++)  
            {
                if (_numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
