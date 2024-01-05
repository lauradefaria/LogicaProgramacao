using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.ListaExercicios.Exercicios
{
    internal class Cpf
    {
        private string _cpfUsuario;
        internal string CpfUsuario
        {
            get { return _cpfUsuario; }
            set { _cpfUsuario = value; }
        }
        internal int ehValido()
        {
            Console.Clear();
            Console.Write("Digite seu cpf (ex: 111.111.111-11): ");
            _cpfUsuario = Console.ReadLine();

            string cpf = new string(_cpfUsuario.ToCharArray().Where(char.IsDigit).ToArray());

            if (cpf.Length != 11)
            {
                return 1;
            }

            if (new string(cpf[0], cpf.Length) == cpf)
            {
                return 1;
            }

            int soma = 0;
            for (int i = 0; i < 9; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * (10 - i);
            }

            int resto = soma % 11;
            int digitoVerificador1 = (resto < 2) ? 0 : 11 - resto;

            if (int.Parse(cpf[9].ToString()) != digitoVerificador1)
            {
                return 2;
            }

            soma = 0;
            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(cpf[i].ToString()) * (11 - i);
            }

            resto = soma % 11;
            int digitoVerificador2 = (resto < 2) ? 0 : 11 - resto;

            if(int.Parse(cpf[10].ToString()) != digitoVerificador2)
            {
                return 2;
            }

            Console.Clear();
            return 0;
        }
    }
}
