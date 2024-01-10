using System;
using System.ComponentModel.DataAnnotations;

public class Razpored {
    [Key]
    public int ID_Razpored { get; set; }
    private string stKroga;
	private List <Tekma> tekme;

	public void PoisciIzbraniKrog() {
		throw new System.NotImplementedException("Not implemented");
	}

	private Zapisnik vsebuje;

}
