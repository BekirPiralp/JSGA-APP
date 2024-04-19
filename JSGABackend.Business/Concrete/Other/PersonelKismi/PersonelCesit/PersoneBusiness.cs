using JSGABackend.Business.Concrete.Base;
using JSGABackend.DataAccess.Abstract.Other.PersonelKismi.PersonelCesit;
using JSGABackend.Entity.Concrete.Other.PersonelKismi.PersonelCesit;

namespace JSGABackend.Business;

public class PersonelBusiness : BaseForBusiness< IPersonelDataAccess, Personel>, IPersonelBusiness
{

}
