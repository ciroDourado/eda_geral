using System;
using System.Collections.Generic;
using System.Linq;

public class Aluno: Pessoa {
	public  string      Descricao { get; set; }
	private List<float> notas;

	public Aluno() {
		Descricao = string.Empty;
		notas     = new List<float>();
	} // construtor

	public Aluno(string descricao) {
		Descricao = descricao;
	} // construtor

	public Aluno(string descricao, string nome) {
		// classe-pai
		Nome = nome;
		
		// classe Aluno
		Descricao = descricao;
	} // construtor

	public Aluno(string descricao, string nome, int idade) {
		// classe-pai
		Nome  = nome;
		Idade = idade;
		
		// classe Aluno
		Descricao = descricao;
	} // construtor


	public void InserirNota(float nota) {
		var erro = "Todas as notas foram preenchidas";
		
		if( notas.Count <= 3 ) {
			notas.Add(nota);
		} else Console.WriteLine(erro);
	} // InserirNota


	public void CorrigirNota(int ordinal, float nota) {
		var erro = "Fora do intervalo";
		int indice = ordinal - 1;

		if( _EstaNoIntervalo(indice) ) {
			notas[indice] = nota;
		} else Console.WriteLine(erro);
	} // CorrigirNota

	
	private bool _EstaNoIntervalo(int indice) {
		return indice >= 0 && indice < notas.Count;
	} // _EstaNoIntervalo


	public float Media() {
		return notas.Average();
	} // Media

} // end class Aluno
