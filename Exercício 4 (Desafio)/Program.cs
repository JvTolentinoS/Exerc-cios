using System;

namespace Exercício_4__Desafio_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Informações
            Console.WriteLine("Insira o seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Olá "+nome+", insira a sua idade:");
            int idade = int.Parse(Console.ReadLine());
            
            //Impressão
            if(idade < 5 ){
                Console.WriteLine("Infelizmente o usuário " +nome+ " não pode ser incluido por estar abaixo idade mínima de 5 anos.");
            
            }else if(idade <= 7){
                Console.WriteLine("O usuário "+nome+" será incluido na categoria Infantil A");

            }else if(idade <= 10){
                Console.WriteLine("O usuário "+nome+" será incluido na categoria Infantil B");

            }else if(idade <= 13){
                Console.WriteLine("O usuário "+nome+" será incluido na categoria Juvenil A");

            }else if(idade <= 17){
                Console.WriteLine("O usuário "+nome+" será incluido na categoria Juvenil B");
                
            }else if(idade > 18){
                Console.WriteLine("O usuário "+nome+" será incluido na categoria Sênior");
            }
        }
    }
}
