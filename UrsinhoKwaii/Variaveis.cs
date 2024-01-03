using System;
namespace Variaveis
{
    class Program
    {
        public static void Main(string[] args)
        {
            int inteiro = 1;
            double real = 1.25;
            char letra = 'S';
            string palavra = "alve";
            bool verdadeiroFalso = false;

            //Exemplos de cada uma:

            //Soma de dois valores
            double soma = real + inteiro;
            Console.WriteLine(soma);
            
            //Palavra com algum caracter junto
            string completo = letra + palavra;
            Console.WriteLine(completo);
            
            //Verdadeiro ou Falso
            if(verdadeiroFalso == true)
            {
                Console.WriteLine("O valor e verdadeiro");
            }
            else
                Console.WriteLine("O valor e falso");
            



        }
    }
}