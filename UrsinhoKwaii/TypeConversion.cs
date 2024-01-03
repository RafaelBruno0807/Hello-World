using System;
namespace TipoConversão
{
	class TypeConversion
	{
		public static void Main(string[] args)
		{

			int myInt = 10;
			double myDouble = 5.25;
			bool myBool = true;

			//Converte inteiro para string
			Console.WriteLine(Convert.ToString(myInt));
			
			//Converte inteiro para double
			Console.WriteLine(Convert.ToDouble(myInt));
			
			//Converte double para inteiro
			Console.WriteLine(Convert.ToInt32(myDouble));
			
			//Converte boolean para string
			Console.WriteLine(Convert.ToString(myBool));
		}
	}
}