using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBrandDal : IEntityRepository<Brand> //IEntityRepositoryde  sadece kendi sınıflarımızın referans tiplerinin yazılması için sınırladık (referans tip olarak)
    {
       
    }
}
