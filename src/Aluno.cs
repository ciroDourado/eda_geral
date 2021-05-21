using System;
using System.Collections.Generic;

public class Aluno: Pessoa {
	public string Nota { get; set; }

	public Aluno() {
		Nome = string.Empty;
		Nota = string.Empty;
	} // construtor

	public Aluno(string nome, string nota) {
		Nome = nome;
		Nota = nota;
	} // construtor


	// Metodos
	public string IniciaisNome() {
		return String.IsNullOrEmpty(Nome)? 
			string.Empty:
			_Iniciais(Nome);
	} // IniciaisNome

	
	private string _Iniciais(string nomeCompleto) {
		var iniciais = new Queue<char>();

		foreach(string nome in nomeCompleto.Split(' ')) {
			var inicial = _ObterInicial(nome);
			iniciais.Enqueue(inicial);
		}
		return _IniciaisFormatadas(iniciais);
	} // _Iniciais


	private char _ObterInicial(string nome) {
		return Convert.ToChar(nome[0]);
	} // _ObterInicial

	
	private string _IniciaisFormatadas(Queue<char> iniciais) {
		var primeira = _InicialFormatada(iniciais);
		var segunda  = _InicialFormatada(iniciais);
		return $"{primeira}{segunda}";
	} // _IniciaisFormatadas

	
	private string _InicialFormatada(Queue<char> iniciais) {
		return iniciais.Count >= 1?
			Char.ToUpper(iniciais.Dequeue()) + ".":
			string.Empty;
	} // _ObterInicial

} // end class Aluno
