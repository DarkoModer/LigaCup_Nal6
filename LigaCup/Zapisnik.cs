using System;
using System.ComponentModel.DataAnnotations;

public class Zapisnik {
    [Key]
    public int ID_Zapisnik { get; set; }
    public int stKartonov { get; set; }
    public string igralecId { get; set; }
    public DateTime datumUra { get; set; }
    public int idTekme { get; set; }

    public void GetStKartonov() {
		throw new System.NotImplementedException("Not implemented");
	}
	public void GetRezultat() {
		throw new System.NotImplementedException("Not implemented");
	}
	public void GetStrelci() {
		throw new System.NotImplementedException("Not implemented");
	}
	public void GetDatumInUra() {
		throw new System.NotImplementedException("Not implemented");
	}

	private Uporabnik pridobi;
	private Razpored vsebuje;

}
