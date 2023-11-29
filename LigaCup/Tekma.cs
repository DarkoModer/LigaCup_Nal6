using System;

public class Tekma {
	private int idTekme;
	private string rezultat;
	private string domacaEkipa;
	private string gostujocaEkipa;

	public void SetIdTekme(ref object idTekma_int) {
		throw new System.NotImplementedException("Not implemented");
	}
	public void SetRezultat(ref string rezultat) {
		this.rezultat = rezultat;
	}
	public void SetDomacaEkipa(ref string domacaEkipa) {
		this.domacaEkipa = domacaEkipa;
	}
	public bool Shrani() {
		throw new System.NotImplementedException("Not implemented");
	}
	public void SetGostujocaEkipa(ref string gostujocaEkipa) {
		this.gostujocaEkipa = gostujocaEkipa;
	}

	private Igralec igra;

}
