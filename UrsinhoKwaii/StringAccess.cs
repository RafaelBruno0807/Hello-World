using System;

namespace AcessarStrings
{
	class StringAccess
	{
		public static void Main(string[] args)
		{
			string minhaString = "Olá";
			string myString = "Hello";

			Console.WriteLine(minhaString[0]); //Irá retornar a letra "O"

			Console.WriteLine(minhaString[1]); //Irá retornar a letra "L"

			Console.WriteLine(myString.IndexOf("e")); // IndexOf() Esse médotodo é usado para identificar a posição específica de um character na string

			//Outro método útil é "Substring", que extrai os caracteres de uma string, começando na posição/índice do caractere especificado, e retorna uma nova string. Este método é frequentemente usado junto com IndexOf() para obter a posição específica do character:

			//Nome completo
			string nome = "Rafael Bruno";

			//Localização da letra B
			int posicaoCharacter = nome.IndexOf("B");

			//Mostrar o último nome
			string ultimoNome = nome.Substring(posicaoCharacter);

			//Mostra o resultado
			Console.WriteLine(ultimoNome);

		}
	}
}