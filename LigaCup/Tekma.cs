using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

public class Tekma {
    [Key]
    public int ID_Tekma { get; set; }
    public string rezultat { get; set; }
    public string domacaEkipa { get; set; }
    public string gostujocaEkipa { get; set; }

	public Tekma(string rezultat, string domaci, string gosti) {
		this.rezultat = rezultat;
		this.domacaEkipa = domaci;
		this.gostujocaEkipa = gosti;
	}

	public Tekma() { }

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
