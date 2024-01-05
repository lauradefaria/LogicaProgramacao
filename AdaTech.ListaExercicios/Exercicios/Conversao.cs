using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdaTech.ListaExercicios.Exercicios
{
    internal class Conversao
    {
        private decimal _valorReal;
        private decimal _valorDolar;
        private decimal _taxaConversao;
        internal decimal ValorReal
        {
            get { return _valorReal; }
            set { _valorReal = value; }
        }
        internal decimal ValorDolar
        {
            get { return _valorDolar; }
            set { _valorDolar = value; }
        }
        internal decimal TaxaConversao
        {
            get { return _taxaConversao; }
            set { _taxaConversao = value; }
        }
        internal Conversao()
        {
            this._valorReal = 0.0m;
            this._valorDolar = 0.0m;
            this._taxaConversao = 0.0m;
        }
        internal void ConverterRealDolar()
        {
            do
            {
                Console.Clear();
                Console.Write("Digite a o valor em reais: R$");
            } while (!decimal.TryParse(Console.ReadLine(), out _valorReal));
            do
            {
                Console.Write("Digite o valor da cotação do dólar: $");
            } while (!decimal.TryParse(Console.ReadLine(), out _taxaConversao));

            _valorDolar = _valorReal * _taxaConversao;
        }
    }
}
