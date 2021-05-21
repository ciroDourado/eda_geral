using System;
using System.Collections.Generic;

public class Pessoa {
	private string _localizacao = string.Empty;
	public  string Nome  { get; set; }
	public  int    Idade { get; set; }

	public Pessoa() {
		Nome  = "Sem nome";
		Idade = 0;
	} // Pessoa

	public Pessoa(string nome, int idade) {
		Nome  = nome;
		Idade = idade;
	} // Pessoa


    // Metodos
    public string IniciaisNome() {
        string nomeCompleto = Nome;
		return String.IsNullOrEmpty(nomeCompleto)?
            string.Empty:
            _Iniciais(nomeCompleto);
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


/*	
	public void Realocar(string localizacao) {
		if (!string.IsNullOrEmpty(localizacao)) {
			_localizacao = localizacao;
		}
	} // end Realocar
*/


/*
	public float GetDistancia(string localizacao) {
		return DistanciaHelpers
			.GetDistancia(_localizacao, localizacao);
	} // end GetDistancia
*/


} // end class Pessoa
