using JSGABackend.Entity.Concrete.Other.BirimKismi;
using JSGABackend.Entity.Concrete.Other.PersonelKismi.PersonelUnvan;

namespace JSGABackend.Entity.Concrete.Other.PersonelKismi.PersonelCesit
{
	public class Personel : PersonelBase
	{
		public required Rutbe Rutbe { get; set; }
		public required Sube Sube { get; set; }

	}
}
