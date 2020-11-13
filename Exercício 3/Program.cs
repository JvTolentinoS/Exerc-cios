using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aviso prévio
            Console.WriteLine("Olá funcionário da empresa XOXi Corps. Porfavor insira o valor do seu salário, caso esteja acima de R$ 500 você receberá um aumento garantido de 30%.");
            
            double salario = double.Parse(Console.ReadLine());
            double aumentoSalario;
            
            //Cálculo do salário
            aumentoSalario = salario*1.3;

            if(salario <= 500 ){
                Console.WriteLine("O seu salário será aumentado para R$ "+aumentoSalario+".");
            }else{
                Console.WriteLine("O seu salário não será aumentado, pois excede o valor máximo de R$ 500.");
            }
            
        }
    }
}
