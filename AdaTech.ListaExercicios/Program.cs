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
            Temperatura valorTemperatura = new Temperatura();
            valorTemperatura.EscolhaUsuario();
            if(valorTemperatura.Chave == "1")
            {
                Console.WriteLine($"\nValor em Fahrenheit: {valorTemperatura.NumeroConvertido}");
            }
            else { Console.WriteLine($"\nValor em Fahrenheit: {valorTemperatura.NumeroConvertido}"); }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadLine();
            return;
        }
        static void Exercicio2()
        {
            Primo primo = new Primo();
            if (primo.EhPrimo())
            {
                Console.WriteLine($"\n{primo.Numero} é primo!");
            }
            else
            {
                Console.WriteLine($"\n{primo.Numero} não é primo!");
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadLine();
            return;
        }
        static void Exercicio3()
        {
            Fatorial fatorial = new Fatorial();
            fatorial.CalcularFatorial();
            if(fatorial.ValorTotal == 0)
            {
                Console.WriteLine($"O número {fatorial.Numero} não possui fatorial, pois é negativo");
            }
            else
            {
                Console.WriteLine($"O fatorial do número {fatorial.Numero} é: {fatorial.ValorTotal}");
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadLine();
            return;

        }
        static void Exercicio4()
        {
            ArrayCrescente array = new ArrayCrescente();
            array.Ordenar();
            Console.WriteLine("\nArray ordenado em ordem crescente: ");
            Console.WriteLine(string.Join(",", array.Numeros));

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadLine();
            return;
        }
        static void Exercicio5()
        {
            Palindromo palindromo = new Palindromo();
            if (palindromo.VerificarPalindromo())
            {
                Console.WriteLine($"{palindromo.Palavra} é um palíndromo.");
            }
            else
            {
                Console.WriteLine($"{palindromo.Palavra} não é um palíndromo.");
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadLine();
            return;
        }
        static void Exercicio6()
        {
            RaizQuadrada raiz = new RaizQuadrada();
            raiz.CalcularRaiz();
            if (raiz.Flag)
            {
                Console.WriteLine($"\nA raiz quadrada exata do número {raiz.Numero} é {raiz.ResultadoRaiz}.");
            }
            else
            {
                Console.WriteLine($"\nA raiz quadrada aproximada do número {raiz.Numero} é {raiz.ResultadoRaiz}.");
            }

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadLine();
            return;
        }
        static void Exercicio7()
        {
            Conversao valor = new Conversao();
            valor.ConverterRealDolar();
            Console.Clear();
            Console.WriteLine($"Valor em Reais: R${valor.ValorReal}\nTaxa de conversão para dolar: ${valor.TaxaConversao}\nValor convertido em dólares: ${valor.ValorDolar}");

            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadLine();
            return;
        }
        static void Exercicio8()
        {
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadLine();
            return;
        }
        static void Exercicio9()
        {
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadLine();
            return;
        }
        static void Exercicio10()
        {
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadLine();
            return;
        }
    }
}
