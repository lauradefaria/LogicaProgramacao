using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdaTech.ListaExercicios.Exercicios
{
    internal class Palindromo
    {
        private string _palavra;
        internal string Palavra
        {
            get { return _palavra; }
        }
        internal bool VerificarPalindromo()
        {
            string palavra;
            do
            {
                Console.Write("Digite uma palavra para verificar se é um palíndromo: ");
                _palavra = Console.ReadLine();
            } while (VerificarApenasLetras(_palavra));

            palavra = _palavra;
            palavra = palavra.Replace(" ", "").ToLower();
            char[] palavraInvertida = palavra.ToCharArray();
            Array.Reverse(palavraInvertida);

            return palavra == new string(palavraInvertida);
        }
        private bool VerificarApenasLetras(string texto)
        {
            foreach (char caractere in texto)
            {
                if (char.IsLetter(caractere))
                {
                    return true;
                }
            }
            return false; 
        }
    }
}
