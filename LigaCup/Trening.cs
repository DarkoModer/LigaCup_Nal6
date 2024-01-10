using System;
using System.ComponentModel.DataAnnotations;

public class Trening {
    [Key]
    public int ID_Trening { get; set; }
    public DateTime ura { get; set; }
    public DateTime date { get; set; }
    public string lokacija { get; set; }

    public void SetIdTrening(ref int idTrening) {
		this.ID_Trening = idTrening;
	}
	public void SetUra(ref DateTime ura) {
		this.ura = ura;
	}
	public void SetDatum(ref DateTime datum) {
		this.date = datum;
	}
	public void SetLokacija(ref string lokacija) {
		this.lokacija = lokacija;
	}
	public bool Shrani() {
		throw new System.NotImplementedException("Not implemented");
	}
	public void PredlogTreninga(ref int idTreninga, ref DateTime ura, ref DateTime datum, ref string lokacija) {
		throw new System.NotImplementedException("Not implemented");
	}

	private Igralec sodeluje;

}
