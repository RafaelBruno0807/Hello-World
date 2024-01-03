using System;
namespace TiposDeDados
{
    class DataType
    {
        public static void Main(string[] args)
        {
            int numeroInteiro = 10;
            long numerosGigantes = 10000000L;
            float numerosReal = 1.2F;
            double numeroReal = 1.3D;
            bool valoresLogicos = true;
            char caracterLetra = 'A';
            string palavras = "Rafael";
            
            //Long Armazena Numeros Inteiros Muito Grandes
            Console.WriteLine(numerosGigantes);
            
            // Int Armazena Numeros Inteiros
            Console.WriteLine(numeroInteiro);
            
            //Float Armazena Numeros Reais com até 6 dígitos após a vírgula
            Console.WriteLine(numerosReal);
            
            //Double Armazena Numeros Reais com até 15 dígitos após a vírgula
            Console.WriteLine(numeroReal);
            
            //Bool Armazena Valores Lógicos como True ou False
            Console.WriteLine(valoresLogicos);
            
            //Char Armazena Apenas uma Letra/Caracter utilizando Aspas Simples
            Console.WriteLine(caracterLetra);
            
            //String Armazena uma Sequência de Letras/Caracteres
            Console.WriteLine(palavras);
            
        }
    }
}