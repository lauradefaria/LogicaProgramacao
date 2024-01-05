using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.ListaExercicios.Exercicios
{
    internal class ArrayCrescente
    {
        private int[] _numeros;
        internal int[] Numeros
        {
            get { return _numeros; }
            set { _numeros = value; }
        }
        internal void Ordenar()
        {
            int quantidade;
            do
            {
                Console.Clear();
                Console.Write("Digite a quantidade de inteiros que deseja ordenar: ");
            } while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade <= 0);

            _numeros = new int[quantidade]; // Inicializa o array com o tamanho especificado

            for (int contagem = 0; contagem < quantidade; contagem++)
            {
                int numero;
                do
                {
                    Console.Clear();
                    Console.Write($"Digite o {contagem + 1}° número: ");
                } while (!int.TryParse(Console.ReadLine(), out numero));

                _numeros[contagem] = numero;
            }

            Array.Sort(_numeros);
            Console.Clear();
        }
    }
}
