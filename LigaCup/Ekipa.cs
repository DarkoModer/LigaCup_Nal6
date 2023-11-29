using System;

public class Ekipa {
	private string ime;
	private string trener;
	private string igralci;

	public void SetIme(ref string ime) {
		this.ime = ime;
	}
	public void SetTrener(ref string trener) {
		this.trener = trener;
	}
	public void SetIgralec(ref Igralec igralec) {
		throw new System.NotImplementedException("Not implemented");
	}
	public bool Shrani() {
		throw new System.NotImplementedException("Not implemented");
	}
	public void SetNoviPodatek(ref string podatek) {
		throw new System.NotImplementedException("Not implemented");
	}

	private Uporabnik ustvari_in_ureja;
	private Igralec ima_;

}
