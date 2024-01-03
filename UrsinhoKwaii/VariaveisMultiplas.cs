using System;
namespace Multiplas
{
    class VariaveisMultiplas
    {
        public static void Main(string[] args)
        {
            //É possível criar multiplas variaveis utilizando o mesmo tipo de valor
            string nomePrimeiro = "Rafael", nomeSegundo = "Bruno", nomeFinal = "Leite";
            
            //Utilizando às variáveis
            Console.WriteLine(nomePrimeiro + nomeSegundo + nomeFinal);
            
            //Outro exemplo com números
            int x = 10, y = 10, a = 10;
            int media = (x + y + a) / 3;
            
            //Média
            Console.WriteLine(media);
        }
    }
}