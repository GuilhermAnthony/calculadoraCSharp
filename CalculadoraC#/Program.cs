using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char operacao = ' ';
            bool operacaoValida = false;
            int n1;
            int n2;
            int resultado;
            int cont = 1;

            while (cont == 1)
            {
                Console.WriteLine("Digite o primeiro numero:");
                n1 = int.Parse(Console.ReadLine());

                while (operacaoValida == false)
                {

                    Console.WriteLine("Digite a operação desejada (+, -, *, /):");
                    operacao = char.Parse(Console.ReadLine());

                    if (operacao == '+' || operacao == '-' || operacao == '*' || operacao == '/')
                    {
                        operacaoValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Operação inválida! Por favor, insira uma operação válida.\n");
                    }
                }

                Console.WriteLine("Digite o segundo numero:");
                n2 = int.Parse(Console.ReadLine());

                switch (operacao)
                {
                    case '+':
                        resultado = n1 + n2;
                        Console.WriteLine("Resultado: {0}", resultado);
                        break;
                    case '-':
                        resultado = n1 - n2;
                        Console.WriteLine("Resultado: {0}", resultado);
                        break;
                    case '*':
                        resultado = n1 * n2;
                        Console.WriteLine("Resultado: {0}", resultado);
                        break;
                    case '/':
                        if (n2 != 0)
                        {
                            resultado = n1 / n2;
                            Console.WriteLine("Resultado: {0}", resultado);
                        }
                        else
                        {
                            Console.WriteLine("Não é possível dividir por zero");
                        }
                        break;
                    default:
                        Console.WriteLine("Operação invalida");
                        break;
                }

                Console.WriteLine("Deseja continuar? (Digite 1 para 'SIM' ou 0 para 'NÂO')");
                cont = int.Parse(Console.ReadLine());

                operacaoValida = false;
                Console.Clear();

            }
        }
    }
}
