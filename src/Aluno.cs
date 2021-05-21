using System;

public class Aluno: Pessoa {
	public string Nota { get; set; }

	public Aluno() {
		Nota = string.Empty;
	} // construtor

	public Aluno(string nota) {
		Nota = nota;
	} // construtor

} // end class Aluno
