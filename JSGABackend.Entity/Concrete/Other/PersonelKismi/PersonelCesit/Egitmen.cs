using JSGABackend.Entity.Concrete.Other.BirimKismi;
using JSGABackend.Entity.Concrete.Other.PersonelKismi.PersonelUnvan;

namespace JSGABackend.Entity.Concrete.Other.PersonelKismi.PersonelCesit
{
	public class Egitmen : PersonelBase
	{
		public required Unvan Unvan { get; set; }
		public Sube? Sube { get; set; } // Dışardan gelen eğitmenlerin bağlı olduğu birim olmaya bilir
	}
}
