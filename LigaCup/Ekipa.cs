using System;
using System.ComponentModel.DataAnnotations;

public class Ekipa {
    [Key]
    public int ID_Ekipa { get; set; }
    public string ime { get; set; }
    public string trener { get; set; }
    public List<Igralec> igralci = new List<Igralec>();

	public Ekipa(int id, string ime, string trener) {
		ID_Ekipa = id;
        this.ime = ime;
        this.trener = trener;
    }

	public Ekipa() { }


    public void SetIme(ref string ime) {
		this.ime = ime;
	}
	public void SetTrener(ref string trener) {
		this.trener = trener;
	}
	public void SetIgralec(ref Igralec igralec) {
        igralci.Add(igralec);
    }
	public bool Shrani() {
		return true;
	}
	public void SetNoviPodatek(ref string podatek) {
		
	}

	private Uporabnik ustvari_in_ureja;
	private Igralec ima_;

}
