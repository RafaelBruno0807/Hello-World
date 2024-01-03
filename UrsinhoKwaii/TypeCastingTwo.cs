using System;
namespace Explicito
{
	class TypeCastingTwo
	{
		public static void Main(string[] args){

			Console.WriteLine("Teste");
			double myDouble = 9.78;
			int myInt = (int) myDouble; //Troca manual

			Console.WriteLine(myDouble); //Retorna 9.78
			Console.WriteLine(myInt); //Retorna 9

			//Nesse código como foi uma conversão Explicita ela precisou ser feita manualmente.
		}
	}
}