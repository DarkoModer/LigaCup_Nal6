using System;

public class Igralec {
	private string ime;
	private string priimek;
	private int zadetki;
	private int kartoni;
	private int letoRojstva;

	public void SetZadetki(ref int zadetki) {
		throw new System.NotImplementedException("Not implemented");
	}
	public void SetKartoni(ref int kartoni) {
		this.kartoni = kartoni;
	}
	public bool Shrani() {
		throw new System.NotImplementedException("Not implemented");
	}

	private Uporabnik ustvari;
	private Ekipa ima_;

	private Tekma igra;
	private Trening sodeluje;

}
