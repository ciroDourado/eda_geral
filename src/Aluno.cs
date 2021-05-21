using System;

public class Aluno: Pessoa {
	public string Nota { get; set; }

	public Aluno() {
		Nota = string.Empty;
	} // construtor

	public Aluno(string nota) {
		Nota = nota;
	} // construtor

	public Aluno(string nota, string nome) {
		Nome = nome;
		Nota = nota;
	} // construtor

	public Aluno(string nota, string nome, int idade) {
		Nota  = nota;
		Nome  = nome;
		Idade = idade;
	} // construtor

} // end class Aluno
