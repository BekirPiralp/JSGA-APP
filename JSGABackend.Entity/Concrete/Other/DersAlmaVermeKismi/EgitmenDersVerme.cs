using JSGABackend.Entity.Concrete.Base;
using JSGABackend.Entity.Concrete.Other.AkademikKisim;
using JSGABackend.Entity.Concrete.Other.DersKismi;
using JSGABackend.Entity.Concrete.Other.DerslikKismi;
using JSGABackend.Entity.Concrete.Other.HaftalikPlanKismi;
using JSGABackend.Entity.Concrete.Other.OkulKismi;
using JSGABackend.Entity.Concrete.Other.PersonelKismi.PersonelCesit;

namespace JSGABackend.Entity.Concrete.Other.DersAlmaVermeKismi
{
	public class EgitmenDersVerme : BaseEntity
	{
		public required Egitmen Egitmen { get; set; }
		public required Kisim Kisim { get; set; }
		public required Ders Ders { get; set; }
		public required Derslik Derslik { get; set; } // Derslik yok ise ders kısımda işlenecek
		public required AkademikYil AkademikYil { get; set; }
		public required AkademikDonem AkademikDonem { get; set; }
		public required GunlukIslemSaati GunlukIslemSaati { get; set; }
		public required float GecmeNotu { get; set; } = 0; // Varsayıaln olarak sıfır atalı ise normal bağıldan hesap edilecek

	}
}
