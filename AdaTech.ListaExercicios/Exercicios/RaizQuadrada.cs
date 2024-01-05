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
        private double _numero;
        private double _resultadoRaiz;
        private bool _flag;
        internal double Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        internal double ResultadoRaiz
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
            } while (!double.TryParse(Console.ReadLine(), out _numero) || _numero < 0);

            if (_numero == 0 || _numero == 1)
            {
                _resultadoRaiz = _numero;
                _flag = true;
            }
            else
            {
                for (double i = 2; i <= _numero / 2; i++)
                {
                    if (i * i == _numero)
                    {
                        _resultadoRaiz = i;
                        _flag = true;
                        break;
                    }
                    else if (i * i > _numero)
                    {
                        double estimativa = _numero / 2; 

                        for (int j = 0; j < i; j++) 
                        {
                            estimativa = (estimativa + _numero / estimativa) / 2;
                        }
                        _resultadoRaiz = estimativa;
                        break;
                    }
                }
            }
        }
    }
}
