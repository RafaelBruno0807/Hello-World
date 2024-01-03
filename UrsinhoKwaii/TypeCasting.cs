using System;
namespace Implicito
{
    class TypeCasting
    {
        public static void Main(string [] args){
            
            /*TypeCasting ou Conversão de Tipo é quando você quer mudar a variável de um tipo para outro tipo, por exemplo: Uma variável com valor INT para DOUBLE porque será necessário mais casas decimais.
            Existem dois tipos de conversão:
            Conversão Implícita: É realizado automaticamente, é quando você converte um valor menor em um valor maior, por exemplo: int para long ou float para double
            Conversão Explícita: Precisa ser feito manualmente, é quando você converte um valor maior em um menor, por exemplo: long para int ou double para float.
            Exemplos práticos*/
            
            int numeroInteiro = 1;
            double numeroDouble = numeroInteiro;
            
            //Comando para ler o número inteiro
            
            Console.WriteLine(numeroInteiro);
            
            //Comando para ler um valor que será somado a variável double
            
            double entradaDouble = double.Parse(Console.ReadLine());
            
            //Comando para mostrar a soma do número inteiro com o double com o tipo alterado
            
            Console.WriteLine(numeroDouble + entradaDouble);
            
        }
    }
}