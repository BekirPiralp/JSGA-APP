using JSGABackend.Entity.Concrete.Base;
using JSGABackend.Entity.Concrete.Other.OkulKismi;

namespace JSGABackend.Entity.Concrete.Other.HaftalikPlanKismi
{
	public class GunlukIslemSaati : BaseEntity
	{ 
		public required Sinif Sinif { get; set; }
		public required string SaatAdi { get; set; }
		public required int SuresiDakika { get; set; }
		public required int BaslangicSaat { get; set; }
		public required int BaslangicDakika { get; set; }
		public required int HaftadakiGun { get; set; } // pzt = 1 vs....
	}

	public enum HaftadakiGun
	{
		Pazartesi = 1,
		Sali = 2,
		Carsamba = 3,
		Persembe = 4,
		Cuma = 5,
		Cumartesi = 6,
		Pazar = 7
	}

}
