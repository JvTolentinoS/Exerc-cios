using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira seu ano de nascimento: ");

            int data = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Insira o ano atual: ");

            int atualData = int.Parse(Console.ReadLine());
            
            int idade = atualData - data;
            int semanas = (idade*12)*4;

            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Idade: " +idade+ " anos.");
            Console.WriteLine("Com " +idade+ " anos você possui " +semanas+ " semanas.");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------");
        }
    }
}
