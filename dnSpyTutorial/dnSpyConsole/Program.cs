using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dnSpyLibrary;

namespace dnSpyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao ChEcA MaIoR NúMeRo!");
            Console.WriteLine("Este é um simples software para testar a ferramenta dnSpy.");
            Console.WriteLine("Haverá um erro de lógica no assembly, e você não terá o fonte para corrigir, portanto utilize o dnSpy.");
            Console.WriteLine();
            ProgramaChecaMaiorNumero();
            Console.ReadKey();
        }

        static void ProgramaChecaMaiorNumero()
        {
            Console.WriteLine("Vamos verificar qual o maior número.");
            Console.WriteLine();
            Console.Write("Digite um primeiro número: ");
            var number1 = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Digite um segundo número: ");
            var number2 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"O maior número é: {Matematica.ChecarMaiorNumero(Convert.ToInt32(number1), Convert.ToInt32(number2))}");
        }
    }
}
