using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTeste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha a operação desejada, usando os números 1(+), 2(-), 3(*), 4(/): ");
            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            switch (operacao)
            {
                case 1:
                    int soma = num1 + num2;
                    Console.WriteLine("O resultado da soma é: "+ soma);
                break;
 
                case 2:
                    int subt = num1 - num2;
                    Console.WriteLine("O resultado da subtração é: " +  subt);
                break;

                case 3:
                    int mult = num1 * num2;
                    Console.WriteLine("O resultado da multiplicação é: " + mult);
                break;

                case 4:
                    int div = num1 / num2;
                    Console.WriteLine("O resultado da divisão é: " + div);
                break;

            }

            Console.ReadKey();

        }
    }
}
