using JSGABackend.Entity.Concrete.Base;

namespace JSGABackend.Entity.Concrete.Other.GuvenlikKismi
{
	public class SahisSifre : BaseEntity
	{
		public required SahisKullaniciAdi SahisKullaniciAdi { get; set; }
		public required string Sifre { get; set; }
	}
}
