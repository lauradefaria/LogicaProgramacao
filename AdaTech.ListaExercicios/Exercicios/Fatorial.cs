using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.ListaExercicios.Exercicios
{
    internal class Fatorial
    {
        private int _numero, _valorTotal;
        internal int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        internal int ValorTotal
        {
            get { return _valorTotal; }
            set { _valorTotal = value; }
        }
        internal Fatorial()
        {
            this._valorTotal = 0;
        }
        internal void CalcularFatorial()
        {
            do
            {
                Console.Clear();
                Console.Write("Digite o número que deseja descobrir: ");
            } while (!int.TryParse(Console.ReadLine(), out _numero));

            if (_numero == 0 || _numero == 1)
            {
                _valorTotal = 1;
            }
            else if(_numero > 1)
            {
                _valorTotal = _numero;
                int n = _numero;
                while(n > 0)
                {
                    _valorTotal += n * _valorTotal;
                    n--;
                }
            }
        }
    }
}
