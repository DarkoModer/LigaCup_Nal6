using System;

public class Uporabnik {
	private string username;
	private string geslo;

	public bool PreveriUporabniskoIme(ref string uporabnisko) {
		throw new System.NotImplementedException("Not implemented");
	}
	public void SetUporabniskoIme(ref string username) {
		throw new System.NotImplementedException("Not implemented");
	}
	public void SetGeslo(ref string geslo) {
		this.geslo = geslo;
	}
	public bool Shrani() {
		throw new System.NotImplementedException("Not implemented");
	}
	public void SetNoviPodatki(ref string username, ref string geslo) {
		throw new System.NotImplementedException("Not implemented");
	}

	private Ekipa ustvari_in_ureja;

	private Zapisnik pridobi;
	private Igralec ustvari;

}
