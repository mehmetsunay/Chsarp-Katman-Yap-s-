using Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
   public interface IcategoriesDal : IRepository<categories>
    {
        // Burada crud ıslemlerımız ıcın gereklı olan komutları bır sınıf ıcerısınde yapabılırız
        //yada metodlarla yine işlemlerimizi sağlayabiliriz
        //ama ben oyle bır yonetem kullanmak ıstıyorumkı butun sınıflar ıcın gecerlı olan bır crud yapısı olsun 

        //O YUZDEN GENERİC REPOSİTORY UZERINDEN DEVAM EDECEGIM 

    }
}
