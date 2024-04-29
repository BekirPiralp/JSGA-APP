using AppObjectOlusturucu.Abstract;
using AppObjectOlusturucu.Concrete;
using JSGABackend.Security.Abstract;
using Sec = JSGABackend.Security.Concrete;

namespace JSGABackend.Security
{
    public class SecurityCreateHandler : OlusturCreateHandler
    {
        public override void CreateObj()
        {
            this._nextHandler = null;

            OlusturCreator.CreateObject<ISecurity, Sec.Security>();
        }
    }
}
