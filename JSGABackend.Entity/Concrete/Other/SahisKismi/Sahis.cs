using JSGABackend.Entity.Concrete.Base;

namespace JSGABackend.Entity.Concrete.Other.SahisKismi
{
	public class Sahis : BaseEntity
	{
		public required string TC { get; set; }
		public required string Pbik { get; set; }
		public required string Ad { get; set; }
		public required string Soyad { get; set; }
		public byte[]? Foto { get; set; }

	}
}
