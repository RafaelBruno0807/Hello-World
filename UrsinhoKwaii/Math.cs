using System;

namespace MetodosMatematicos
{
	class math
	{
		public static void Main(string[] args)
		{

			Console.WriteLine("Digite o valor de x: ");
			int x = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Digite o valor de y: ");
			int y = int.Parse(Console.ReadLine());

			//Imprime o maior valor entre x e y
			Console.WriteLine(Math.Max(x, y));

			//Imprime o menor valor entre x e y
			Console.WriteLine(Math.Min(x, y));

			//Imprime a raiz quadrada de x
			Console.WriteLine(Math.Sqrt(x));

			//Imprime o valor absoluto positivo de -4.7
			Console.WriteLine(Math.Abs(-4.7));

			//Arredonda para o valor inteiro mais próximo
			Console.WriteLine(Math.Round(9.99));
		}
	}
}