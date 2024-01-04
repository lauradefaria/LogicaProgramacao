using AdaTech.ListaExercicios.Exercicios;

namespace AdaTech.ListaExercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while(flag) {
                Console.Clear();
                Console.WriteLine("\t\tLista de Exercícios - Lógica de Programação\n");
                Console.WriteLine("1 - Conversão de Temperatura\n2 - Número Primo\n3 - Fatorial de número inteiro\n4 - Array em ordem crescente\n5 - Palavra palíndromo\n6 - Raiz quadrada\n7 - Conversão Real para Dólar\n8 - validação de senha\n9 - Validação de CPF\n10 - Frequência de palavra\n\nQ - SAIR DO PROGRAMA");
                string chave = Console.ReadLine();

                switch (chave)
                {
                    case "1":
                        Exercicio1();
                        break;
                    case "2":
                        Exercicio2();
                        break;
                    case "3":
                        Exercicio3();
                        break;
                    case "4":
                        Exercicio4();
                        break;
                    case "5":
                        Exercicio5();
                        break;
                    case "6":
                        Exercicio6();
                        break;
                    case "7":
                        Exercicio7();
                        break;
                    case "8":
                        Exercicio8();
                        break;
                    case "9":
                        Exercicio9();
                        break;
                    case "10":
                        Exercicio10();
                        break;
                    case "q":
                        flag = false;
                        break;
                    default:
                        break;
                }
            }

            return;
        }
        static void Exercicio1()
        {
            Console.Clear();
            Temperatura valorTemperatura = new Temperatura();
            valorTemperatura.EscolhaUsuario();
            if(valorTemperatura.Chave == "1")
            {
                Console.WriteLine($"Valor em Fahrenheit: {valorTemperatura.NumeroConvertido}");
            }
            else { Console.WriteLine($"Valor em Fahrenheit: {valorTemperatura.NumeroConvertido}"); }

            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadLine();
            return;
        }
        static void Exercicio2()
        {

        }
        static void Exercicio3()
        {

        }
        static void Exercicio4()
        {

        }
        static void Exercicio5()
        {

        }
        static void Exercicio6()
        {

        }
        static void Exercicio7()
        {

        }
        static void Exercicio8()
        {

        }
        static void Exercicio9()
        {

        }
        static void Exercicio10()
        {

        }
    }
}
