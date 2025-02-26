using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FiapOperacoes
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Digite seu nome: ");
                string nome = Console.ReadLine();

                Console.Write("Digite um número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite outro número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                

                double soma = num1 + num2;
                double sub = num1 - num2;
                double mult = num1 * num2;
                double modulo = num1 % num2;



                Console.WriteLine("\n Resultados das operações");

                Console.WriteLine($"O valor da soma é {soma}");
                Console.WriteLine($"O valor da sub é {sub}");
                Console.WriteLine($"O valor da mult é {mult}");
                Console.WriteLine($"O valor da modulo é {modulo}");

                //Operações Relacionais

                Console.WriteLine("\nComparação entre números");
                Console.WriteLine($"Os números são iguais? {num1 == num2}");
                Console.WriteLine($"Os números são diferentes? {num1 != num2}");
                Console.WriteLine($"O primeiro número é maior que o segundo? {num1 > num2}");

                //Operadores Lógicos

                bool ambosPositivos = num1 > 0 && num2 > 0;
                bool nenhumNegativo = !(num1 < 0 || num2 < 0);

                Console.WriteLine($"Ambos positivos {ambosPositivos}");
                Console.WriteLine($"Nenhum número é negativo? {nenhumNegativo}");

                //Encerramento do sistema

                Console.WriteLine("\nDigite qualquer coisa para sair");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
