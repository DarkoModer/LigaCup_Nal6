using System;
using System.ComponentModel.DataAnnotations;

public class Igralec {
    [Key]
    public int ID_Igralec { get; set; }
    public string? ime { get; set; }
    public string priimek { get; set; }
    public int zadetki { get; set; }
    public int kartoni { get; set; }
    public int letoRojstva { get; set; }


    public Igralec(string ime, string priimek, int letoRojstva, int zadetki) {
        this.ime = ime;
        this.priimek = priimek;
        this.letoRojstva = letoRojstva;
        this.zadetki = zadetki;
    }

    public Igralec() { }

    public void SetZadetki(int zadetki) {
        this.zadetki = zadetki;
    }

    public void SetKartoni(int kartoni) {
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
