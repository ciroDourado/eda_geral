using System;
using System.Diagnostics;

class Program {
	
	static void Main(string[] args) {	

		Aluno fulano = new Aluno(
			"Graduação EAD", 
			"Fulaninho Tal", 
			21 // idade
		);
		Console.WriteLine(fulano.IniciaisNome());
		Console.WriteLine(fulano.Nome);
		Console.WriteLine(fulano.Idade);

		fulano.InserirNota(5);
		fulano.InserirNota(7);
		fulano.InserirNota(9);
		fulano.InserirNota(6); // mostra mensagem de erro

		Debug.Assert(fulano.Media() == 7); // ok

	} // end Main

} // end class Program
