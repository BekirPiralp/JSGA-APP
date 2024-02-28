using JSGABackend.Contexts;
using JSGABackend.DataAccess.Abstract.Other.OgrenciKismi;
using JSGABackend.DataAccess.Concrete.Base;
using JSGABackend.Entity.Concrete.Other.OgrenciKismi;

namespace JSGABackend.DataAccess.Concrete.Other.OgrenciKismi
{
    public class OgrenciDataAccess :
        EntityBaseForEntityFrameworkDataAccess<Ogrenci, EntityFrameworkContextMsSql>,
        IOgrenciDataAccess
    {
    }
}
