using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdaTech.ListaExercicios.Exercicios
{
    internal class RaizQuadrada
    {
        private decimal _numero;
        private decimal _resultadoRaiz;
        private bool _flag;
        internal decimal Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        internal decimal ResultadoRaiz
        {
            get { return _resultadoRaiz; }
            set { _resultadoRaiz = value; }
        }
        internal bool Flag
        {
            get { return _flag; }
            set { _flag = value; }
        }
        internal RaizQuadrada()
        {
            this._flag = false;
        }
        internal void CalcularRaiz()
        {
            do
            {
                Console.Clear();
                Console.Write("Digite um número para calcular a raiz quadrada: ");
            } while (!decimal.TryParse(Console.ReadLine(), out _numero) || _numero < 0);

            if (_numero == 0 || _numero == 1)
            {
                _resultadoRaiz = _numero;
                _flag = true;
            }
            else
            {
                bool encontrouRaiz = false;
                decimal estimativa = _numero / 2;
                decimal proximaEstimativa;

                for (int iteracao = 0; iteracao < 10; iteracao++) // Ajuste do número de iterações para melhorar a estimativa
                {
                    proximaEstimativa = (_numero / estimativa + estimativa) / 2;

                    if (proximaEstimativa * proximaEstimativa == _numero) // Verifica a convergência
                    {
                        _resultadoRaiz = proximaEstimativa;
                        encontrouRaiz = true;
                        break;
                    }

                    estimativa = proximaEstimativa;
                }

                if (!encontrouRaiz)
                {
                    _resultadoRaiz = estimativa;
                }
                else
                {
                    if(_numero != 2)
                    {
                        _flag = true;
                    }
                }
            }
        }
    }
}
