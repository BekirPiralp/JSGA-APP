using JSGABackend.Entity.Concrete.Other.SahisKismi;

namespace JSGABackend.Entity.Concrete.Other.OgrenciKismi
{
	public class Ogrenci :SahisBulunanBase
	{
		public required string OgrenciNo { get; set; }
		public bool KitaKaynaklimi { get; set; } = false;
		public float DisiplinPuani { get; set; } = 100;
		public bool MezuniyetDurumu { get; set; } = false;
		public float MezuniyetPuani { get; set; } = 0;
	}
}
