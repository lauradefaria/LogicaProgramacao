using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.ListaExercicios.Exercicios
{
    internal class ArrayCrescente
    {
        private readonly int[] _numeros;
        internal int[] Numeros
        {
            get { return _numeros; }
        }
        internal void Ordenar()
        {
            int quantidade;
            do
            {
                Console.Clear();
                Console.Write("Digite a quantidade de inteiros que deseja ordenar: ");
            } while (!int.TryParse(Console.ReadLine(), out quantidade));

            int numero, contagem=1;
            while(contagem <= quantidade)
            {
                Console.Clear();
                do
                {
                    Console.Clear();
                    Console.Write($"Digite o {contagem}° número: ");
                } while (!int.TryParse(Console.ReadLine(), out numero));

                _numeros[contagem] = numero;
                contagem++;
            }

            Array.Sort(_numeros);
        }
    }
}
