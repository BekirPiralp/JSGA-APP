using JSGABackend.Entity.Concrete.Base;
using JSGABackend.Entity.Concrete.Other.AkademikKisim;
using JSGABackend.Entity.Concrete.Other.DersKismi;
using JSGABackend.Entity.Concrete.Other.OgrenciKismi;
using JSGABackend.Entity.Concrete.Other.OkulKismi;

namespace JSGABackend.Entity.Concrete.Other.DersAlmaVermeKismi
{
	public class OgrenciDersAlma : BaseEntity
	{
		public required Ogrenci Ogrenci { get; set; }
		public required Kisim Kisim { get; set; }
		public required Ders Ders { get; set; }
		public required AkademikYil AkademikYil { get; set; }
		public required AkademikDonem AkademikDonem { get; set; }
		public HarfNotu? HarfNotu { get; set; } // sınavlar sonuclanınca eklenecek
		public float Vize { get; set; }
		public float Final { get; set; }
		public float Butunleme { get; set; }
		public bool Muafiyet {  get; set; }
		public bool Alttan { get; set; }
		public float Notu { get; set; }
		public bool SartliGecmeDurumu { get; set; }
		public bool GecmeDurumu { get; set; }
	}
}
