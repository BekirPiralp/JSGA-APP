using JSGABackend.Entity.Concrete.Base;

namespace JSGABackend.Entity.Concrete.Other.DersAlmaVermeKismi
{
    public class NotHesapYüzdesi : BaseEntity
    {
        public required float VizeYuzde { get; set; }
        public required float FinalYüzde { get; set; }
    }
}