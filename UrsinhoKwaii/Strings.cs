using System;

namespace Texto
{
	class Striing
	{
		public static void Main(string[] args)
		{
			//Strings são utilizadas para armazenar textos, uma variável do tipo (string) terá uma sequência de caracteres dentro de aspas duplas (""), exemplo:

			string texto = "Olá";
			string textoDois = "É um prazer te conhecer!";


			Console.WriteLine(texto);
			Console.WriteLine(textoDois);

			//Método para mostrar quantos caracteres tem na string
			Console.WriteLine("A quantidade de letras nessa variável é: " + textoDois.Length);

			//Método para retornar a variável com letra Maiúscula
			Console.WriteLine(texto.ToUpper());

			//Método para retornar a variável com letra Minúscula
			Console.WriteLine(textoDois.ToLower());
		}
	}
}