using JSGABackend.Entity.Concrete.Base;
using JSGABackend.Entity.Concrete.Other.AkademikKisim;
using JSGABackend.Entity.Concrete.Other.OkulKismi;

namespace JSGABackend.Entity.Concrete.Other.DersKismi
{
	public class Ders : BaseEntity
	{
		public required DersIcerik DersIcerik { get; set; }
		public required AkademikYil AkademikYil { get; set; }
		public required AkademikDonem AkademikDonem { get; set; }
		public required Sinif Sinif { get; set; }
		public required DersBrans DersBrans { get; set; }
		public required string DersKodu { get; set; } // intger mi olmalı yoksa string mi ?
		public required string Ad { get; set; }
		public required float AKTS { get; set; }
		public required float Katsayi { get; set; }
		public required float Kredi { get; set; }
		public required float HaftalikTeorikSaat { get; set; }
		public required float HaftalikUygulamaliSaat { get; set; }
		public required int HaftaSayisi { get; set; }
	}
}
