using JSGABackend.Entity.Concrete.Other.SahisKismi;

namespace JSGABackend.Entity.Concrete.Other.PersonelKismi.PersonelCesit
{
	public class PersonelBase:SahisBulunanBase
	{
		public bool PasiflikDurumu {  get; set; }
		public DateTime? PasiflikZamani { get; set; }
	}
}
