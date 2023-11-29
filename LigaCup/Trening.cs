using System;

public class Trening {
	private int idTrening;
	private DateTime ura;
	private DateTime date;
	private string lokacija;

	public void SetIdTrening(ref int idTrening) {
		this.idTrening = idTrening;
	}
	public void SetUra(ref DateTime ura) {
		this.ura = ura;
	}
	public void SetDatum(ref DateTime datum) {
		throw new System.NotImplementedException("Not implemented");
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
