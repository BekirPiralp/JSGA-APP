using JSGABackend.Entity.Abstract;
using System.ComponentModel.DataAnnotations;

namespace JSGABackend.Entity.Concrete.Base
{
	public class BaseEntity : IEntity
	{
		[Key]
		public int Id { get; set; }
		public DateTime? KayitZamani { get; set; }
		public DateTime? GuncellemeZamani { get; set; }
		public DateTime? SilmeZamani { get; set; }
		public bool SilDurum { get; set; } = false;
	}
}
