using System;

namespace Nova_pasta
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insira sua idade: ");

                //Variáveis dos períodos
            int idade = int.Parse(Console.ReadLine());
            int meses;
            int dias;
            int horas;
            int minutos;

                //Cálculo dos períodos
            meses = idade*12;
            dias = meses*30;
            horas = dias*24;
            minutos = horas*60;

                //WriteLine dos períodos
            Console.WriteLine("Aqui está a sua idade em anos: "+idade);
            Console.WriteLine("Aqui está a sua idade em meses: "+meses);
            Console.WriteLine("Aqui está a sua idade em dias: "+dias);
            Console.WriteLine("Aqui está a sua idade em horas: "+horas);
            Console.WriteLine("Aqui está a sua idade em minutos: "+minutos);
            
        }
    }
}
