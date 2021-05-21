using System;
using System.Text;
namespace geral {

class Program {
	enum Linguagens { PT, EN, DE }	

	static void Main(string[] args) {	
		StringBuilder sb = new StringBuilder();
		sb.Append("joao ");
		sb.Append("pedro");
		sb.ToString();

		object  linguagem = Linguagens.PT;
		switch (linguagem) {
			case Linguagens.PT: /* versao portuguesa */ 
				Console.WriteLine("PT");
				break;
			case Linguagens.DE: /* versao alema */ 
				Console.WriteLine("DE");
				break;
			default: /* versão inglesa */ 
				Console.WriteLine("EN");
				break;
		} // end switch

		// String
		string primeiroNome = "joao";
		string ultimoNome   = "jose";
		int ano = 1988;

		string primeiro     = primeiroNome + " ";
		string ultimo       = ultimoNome.ToUpper() + " ";
		string anoFormatado = " nasceu em " + ano;

		string nota = primeiro + ultimo + anoFormatado;
		Console.WriteLine(String.Format("Nota: {0}", nota));

		string primeiraInicial = primeiroNome.ToUpper()[0] + ".";
		string segundaInicial  = ultimoNome.ToUpper()[0] + ".";
		
		string iniciais = primeiraInicial + segundaInicial;
		Console.WriteLine(String.Format("Iniciais: {0}", iniciais));

		nota = String.Format("{0} {1} nasceu em {2}", 
			primeiroNome, 
			ultimoNome.ToUpper(), 
			ano
		);
		Console.WriteLine(String.Format("Nota: {0}", nota));

		nota = $"{primeiro}{ultimo}nasceu em {ano}";
		Console.WriteLine(String.Format("Nota: {0}", nota));
	} // end Main

} // end class Program
} // end namespace geral
