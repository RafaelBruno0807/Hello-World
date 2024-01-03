using System;

namespace OperadorLogico
{
    class OperatorsLogical
    {
        public static void Main(string[] args)
        {
            // Os operadores lógicos são utilizados quando você quer apenas saber se o resultado entre variáveis é verdadeiro ou falso. Por exemplo:
            int valor1 = 5;
            int valor2 = 10;

            // Nessa condição, se ambas as afirmações forem verdadeiras, ele irá imprimir "Verdadeiro". Se alguma das afirmações for falsa, ele irá imprimir "Falso".
            if (valor1 >= 5 && valor1 < 10)
            {
                Console.WriteLine("Verdadeiro");
            }
            else
            {
                Console.WriteLine("Falso");
            }

            // Nessa condição, se uma das afirmações for verdadeira, ele irá imprimir "Verdadeiro". Somente se ambas as afirmações forem falsas, ele irá imprimir "Falso".
            if (valor2 <= 5 || valor2 > 10)
            {
                Console.WriteLine("Verdadeiro");
            }
            else
            {
                Console.WriteLine("Falso");
            }

            // Nessa condição, ele irá inverter o resultado: se a condição for verdadeira, irá imprimir "Falso"; se a condição for falsa, irá imprimir "Verdadeiro".
            if (!(valor1 >= 5 && valor1 < 10))
            {
                Console.WriteLine("Verdadeiro");
            }
            else
            {
                Console.WriteLine("Falso");
            }
        }
    }
}
