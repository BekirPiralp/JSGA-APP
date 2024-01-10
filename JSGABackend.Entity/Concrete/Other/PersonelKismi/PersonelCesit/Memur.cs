using JSGABackend.Entity.Concrete.Other.BirimKismi;
using JSGABackend.Entity.Concrete.Other.PersonelKismi.PersonelUnvan;

namespace JSGABackend.Entity.Concrete.Other.PersonelKismi.PersonelCesit
{
	public class Memur:PersonelBase
	{
		public required Derece Derece { get; set; }
		public required Sube Sube { get; set; }

	}
}
