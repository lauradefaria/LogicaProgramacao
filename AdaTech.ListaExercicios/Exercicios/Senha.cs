using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdaTech.ListaExercicios.Exercicios
{
    internal class Senha
    {
        private string _senhaUsuario;
        internal string SenhaUsuario
        {
            get { return _senhaUsuario; }
            set { _senhaUsuario = value; }
        }
        internal int ehValido()
        {
            int erro = 0;
            Console.Clear();
            Console.Write("Digite sua senha para validação: ");
            _senhaUsuario = Console.ReadLine();

            if (_senhaUsuario.Length < 8)
            {
                return 1;
            }
            if (!_senhaUsuario.Any(char.IsDigit))
            {
                return 2;
            }

            if (!_senhaUsuario.Any(char.IsUpper))
            {
                return 3;
            }
            if (!_senhaUsuario.Any(char.IsLower))
            {
                return 4;
            }

            return 0;
        }
    }
}
