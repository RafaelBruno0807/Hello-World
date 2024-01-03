using System;

namespace Concatenacao
{
	class StrigConcatenation
	{
		public static void Main(string[] args)
		{
			//O operador "+" pode ser usado para juntar duas Strings e isso é chamado de concatenação. Exemplo:

			string nomePrimeiro = "Rafael ";
			string nomeTeste = "Nome ";
			string nomeSegundo = "Bruno";
			string nomeTesteSegundo = "Teste";
			string nomeCompleto = nomePrimeiro + nomeSegundo;
			string nomeTesteCompleto = string.Concat(nomeTeste, nomeTesteSegundo);

			Console.WriteLine(nomeCompleto);

			//Há outro método para fazer a concatenação

			Console.WriteLine(nomeTesteCompleto);

			//Se quiser mostrar números como strings basta colocá-los dentro de aspas duplas, por exemplo:

			string x = "10";
			string y = "20";
			string numeroConcatenado = x + y; //Irá retornar 1020 como uma string

			Console.WriteLine(numeroConcatenado);
		}
	}
}