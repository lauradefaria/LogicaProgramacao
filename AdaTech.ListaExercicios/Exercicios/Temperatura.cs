using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdaTech.ListaExercicios.Exercicios
{
    internal class Temperatura
    {
        private decimal _numeroConvertido;
        private string _chave;
        internal decimal NumeroConvertido
        {
            get { return _numeroConvertido; }
            set { _numeroConvertido = value; }
        }
        internal string Chave
        {
            get { return _chave; }
            set { _chave = value; }
        }
        public void EscolhaUsuario()
        {
            bool flag = true;
            do
            {
                Console.Clear();
                Console.WriteLine("\t\tDigite a temperatura que deseja converter\n");
                Console.WriteLine("1: Celsius --> Fahrenheit\n2: Fahrenheit --> Celsius");
                _chave = Console.ReadLine();
                switch (_chave) {
                    case "1":
                        ConversaoCF();
                        flag = false;
                        break;
                    case "2":
                        ConversaoFC();
                        flag = false;
                        break;
                    default:
                        break;
                }
            }while (flag);

            Console.Clear();
        }

        private void ConversaoCF()
        {
            Console.Clear();
            decimal numero;

            do
            {
                Console.WriteLine("Digite a temperatura em Celsius: ");
            } while (!decimal.TryParse(Console.ReadLine(), out numero));

            NumeroConvertido = ((numero * 9) / 5) + 32;
            Console.Clear();
        }
        private void ConversaoFC()
        {
            Console.Clear();
            decimal numero;

            do
            {
                Console.WriteLine("Digite a temperatura em Fahrenheit: ");
            } while (!decimal.TryParse(Console.ReadLine(), out numero));

            NumeroConvertido = ((numero - 32) * 5) / 9;
            Console.Clear();
        }
    }
}
