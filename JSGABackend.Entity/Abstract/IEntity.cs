namespace JSGABackend.Entity.Abstract
{
	public interface IEntity
	{
		public int Id { get; set; }

		#region temel veriler
		public DateTime? KayitZamani { get; set; }
		public DateTime? GuncellemeZamani { get; set; }
		public DateTime? SilmeZamani { get; set; }
		public bool SilDurum { get; set; }
		#endregion
	}
}
