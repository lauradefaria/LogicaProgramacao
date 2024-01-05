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
            Console.WriteLine("Digite sua senha para validação: ");
            _senhaUsuario = Console.ReadLine();

            if (_senhaUsuario.Length < 8)
            {
                erro = 1;
            }
            if (!_senhaUsuario.Any(char.IsDigit))
            {
                erro = 4;
            }

            if (!_senhaUsuario.Any(char.IsUpper))
            {
                erro = 2;
            }
            if (!_senhaUsuario.Any(char.IsLower))
            {
                erro = 3;
            }

            Console.Clear();
            return erro;
        }
    }
}
