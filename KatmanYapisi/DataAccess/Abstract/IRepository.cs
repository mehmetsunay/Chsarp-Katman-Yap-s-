using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRepository<T>
    {
        //interfaceı olusturduktan sonra 2 yaklasım uzerınden gıdebılırz
        //Her bir sınıf için ayrı bir interface olusturabılırm (DAL)
        //Yada generic bir yapıdan devam edip gıdebılırım 

        int Insert(T p);
        int Update(T p);

        int Delete(T p);

        List<T> List();   

        T GetById(int id);
    }
}
