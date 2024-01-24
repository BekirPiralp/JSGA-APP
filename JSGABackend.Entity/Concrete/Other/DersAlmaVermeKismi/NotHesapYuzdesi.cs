using JSGABackend.Entity.Concrete.Base;

namespace JSGABackend.Entity.Concrete.Other.DersAlmaVermeKismi
{
    public class NotHesapYuzdesi : BaseEntity
    {
        public required float VizeYuzde { get; set; }
        public required float FinalYüzde { get; set; }
    }
}