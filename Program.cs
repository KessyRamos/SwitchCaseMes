using System;

namespace ComparacaoSwitchCaseMes
{
    class Program
    {
        static void Main(string[] args)
        {
            int mes = 0;

            Console.Write("Digite o mês desejado: ");
            mes = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");

            switch(mes)
            {
               case 1:
                Console.WriteLine("Este mês tem 31 dias");
               break;

               case 3:
                Console.WriteLine("Este mês tem 31 dias");
               break;

               case 5:
                Console.WriteLine("Este mês tem 31 dias");
               break;

               case 7:
                Console.WriteLine("Este mês tem 31 dias");
               break;

               case 8:
                Console.WriteLine("Este mês tem 31 dias");
               break;

               case 10:
                Console.WriteLine("Este mês tem 31 dias");
               break;

               case 12:
                Console.WriteLine("Este mês tem 31 dias");
               break;

               case 2:
                Console.WriteLine("Este mês tem 28 dias ou 29 dias nos anos bissextos");
               break;

               default:
                Console.WriteLine("Este mês tem 30 dias");
               break;
            }
            Console.WriteLine("");
        }
    }
}
