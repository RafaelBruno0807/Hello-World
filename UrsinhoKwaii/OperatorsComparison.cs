using System;

namespace OperadorComparacao
{
    class OperatorsComparison
    {
        public static void Main(string[] args)
        {
            int valor1 = 5;
            int valor2 = 10;

            /*Operadores de comparação são usados para
            comparar dois valores ou variáveis. O resultado do valor de uma comparação retorna Valores Booleanos, ou seja, True ou False. Por exemplo:*/

            // == (Igual): Verifica se os valores são iguais.
            Console.WriteLine("== (Igual): " + (valor1 == valor2)); // Retorna False

            // != (Diferente): Verifica se os valores são diferentes.
            Console.WriteLine("!= (Diferente): " + (valor1 != valor2)); // Retorna True

            // > (Maior que): Verifica se valor1 é maior que valor2.
            Console.WriteLine("> (Maior que): " + (valor1 > valor2)); // Retorna False

            // < (Menor que): Verifica se valor1 é menor que valor2.
            Console.WriteLine("< (Menor que): " + (valor1 < valor2)); // Retorna True

            // >= (Maior ou igual a): Verifica se valor1 é maior ou igual a valor2.
            Console.WriteLine(">= (Maior ou igual a): " + (valor1 >= valor2)); // Retorna False

            // <= (Menor ou igual a): Verifica se valor1 é menor ou igual a valor2.
            Console.WriteLine("<= (Menor ou igual a): " + (valor1 <= valor2)); // Retorna True

            /*Operadores de comparação:
            
            == Igual
            != Negação ou não igual
            > Maior que
            < Menor que
            >= Maior ou igual há
            <= Menor ou igual há*/
        }
    }
}
