public class Pessoa {
	private string _localizacao = string.Empty;
	public  string Nome  { get; set; }
	public  int    Idade { get; set; }

	public Pessoa() {
		Nome  = string.Empty;
		Idade = 0;
	} // Pessoa

	public Pessoa(string nome, int idade) {
		Nome  = nome;
		Idade = idade;
	} // Pessoa

	public void Realocar(string localizacao) {
		if (!string.IsNullOrEmpty(localizacao)) {
			_localizacao = localizacao;
		}
	} // end Realocar

/*
	public float GetDistancia(string localizacao) {
		return DistanciaHelpers
			.GetDistancia(_localizacao, localizacao);
	} // end GetDistancia
*/

} // end class Pessoa
