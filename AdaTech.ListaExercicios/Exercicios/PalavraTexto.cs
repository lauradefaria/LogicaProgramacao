using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.ListaExercicios.Exercicios
{
    internal class PalavraTexto
    {
        private Dictionary<string, int> _frequencia = new Dictionary<string, int>();
        internal void AnaliseTextual()
        {
            Console.Clear();
            Console.WriteLine("Digite um texto: ");
            string texto = Console.ReadLine();
            string[] palavras = texto.Split(new char[] { ' ', '.', ',', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string palavra in palavras)
            {
                string palavraMinuscula = palavra.ToLower();

                if (_frequencia.ContainsKey(palavra))
                {
                    _frequencia[palavra]++;
                }
                else
                {
                    _frequencia[palavra] = 1;
                }
            }
        }
        internal Dictionary<string, int> ExibirFrequencia()
        {
            return _frequencia;
        }
    }
}
