using System;

namespace Atribuicao
{
    class OperatorsAssignment
    {
        public static void Main(string[] args)
        {
            /* Operadores de Atribuição
               São usados para atribuir valores a variáveis
               Como no exemplo abaixo: */

            // A variável x está sendo atribuída ao valor 10
            int x = 10;

            // Outros operadores de atribuição

            int y = 5;

            // Operador de adição e atribuição (+=)
            x += 3; // Equivalente a x = x + 3;

            // Operador de subtração e atribuição (-=)
            y -= 2; // Equivalente a y = y - 2;

            // Operador de multiplicação e atribuição (*=)
            x *= 2; // Equivalente a x = x * 2;

            // Operador de divisão e atribuição (/=)
            y /= 3; // Equivalente a y = y / 3;

            // Operador de resto da divisão e atribuição (%=)
            x %= 4; // Equivalente a x = x % 4;

            // Operador de incremento (++)
            x++; // Equivalente a x = x + 1;

            // Operador de decremento (--)
            y--; // Equivalente a y = y - 1;

            // Exibindo os valores após as operações
            Console.WriteLine("Valor de x: " + x);
            Console.WriteLine("Valor de y: " + y);
        }
    }
}
