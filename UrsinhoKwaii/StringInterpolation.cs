using System;

namespace Interpolação
{
	class StringInterpolation
	{
		public static void Main(string[] args)
		{
			string nomePrimeiro = "Silvio ";
			string nomeSegundo = "Domingos";
			string nomeCompleto = $"Meu nome completo é: {nomePrimeiro} {nomeSegundo}";

			Console.WriteLine(nomeCompleto);
		}
	}
}