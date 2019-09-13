using System;

namespace vsCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduza o primeiro numero:");
            int num= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduza o segundo nemero:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int soma = num+num2;
            Console.WriteLine("A soma dos dois numeros = "+soma);
            Console.ReadLine();
            Console.WriteLine("Alteracao efectuada com sucesso");
        }
    }
}

