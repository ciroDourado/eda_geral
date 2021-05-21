using System;
using System.Collections.Generic;

public class Aluno {
	private string nome;
	private string nota;

	public Aluno() {
		nome = string.Empty;
		nota = string.Empty;
	} // construtor

	public Aluno(string nome, string nota) {
		SetNome(nome);
		SetNota(nota);
	} // construtor
	

	// Get e Set Nota
	public string GetNota() {
		return nota;
	} // GetNota

	public void SetNota(string nota) {
		this.nota = nota;
	} // SetNota
	

	// Get e Set Nome
	public string GetNome() {
		return nome;
	} // GetNome

	public void SetNome(string nome) {
		this.nome = nome;
	} // SetNome


	// Metodos
	public string IniciaisNome() {
		return String.IsNullOrEmpty(nome)? 
			string.Empty:
			_IniciaisNome();
	} // IniciaisNome

	
	private string _IniciaisNome() {
		var nomes    = nome.Split(' ');
		var iniciais = new Queue<char>();

		foreach(string nome in nomes) {
			var inicial = _ObterInicial(nome);
			iniciais.Enqueue(inicial);
		}
		return _IniciaisFormatadas(iniciais);
	} // _IniciaisNome


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
