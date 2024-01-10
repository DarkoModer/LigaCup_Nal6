using System;
using System.ComponentModel.DataAnnotations;

public class Lestvica {
    [Key]
    public int ID_Lestvica { get; set; }
    public int idKlub { get; set; }
    public string imeKlub { get; set; }
    public int pozicija { get; set; }

    public void PosodobiLestvico(ref int idklub, ref string imeKlub, ref int pozicija) {
		throw new System.NotImplementedException("Not implemented");
	}

}
