using System;
namespace Constantes
{
    class  VariaveisConstantes
    {
        public static void Main(string[] args)
        {
            //Algumas variáveis podem ter valores que não devem ser alterados e por isso tem seus valores constantes, aqui está alguns exemplos de como criar essas constantes.

            const double Pi = 3.14;
            const string Palmeiras = "Sem Mundial";

            /*Se tentar alterar o valor das constantes o código irá retornar um erro
            double Pi = 1;
            string Palmeiras = "Tem Mundial";
            */

            Console.WriteLine(Pi);
            Console.WriteLine(Palmeiras);

        }
    }
}