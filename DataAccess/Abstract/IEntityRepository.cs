using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{ //generic constrait T yi sınırlandırmak istiyorum Where ile T ye sadece class-->(referans tip) yazsın in yazarsan olmaz mesela, 
    //ya da IEntity ile imlemente olan bir şey olabilir ve IEntity olabilir ama yanına new koyarsan kabul etmez
    //new() newlwnwbilie olmalı. IEntity newlenemez o yüzden onu yazma onu yazdırmaz örneğin IcarDal 

    public interface IEntityRepository<T> where T:class,IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); //filtreleme için(ayrı ayrı renk ıd sine göre getir, markasına göre getir dememize gerek kalmayacak) (filter=null fitre vermeyebilirsin demek)

        T Get(Expression<Func<T, bool>> filter); //(filter gerekli burada)
        
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        //List<T> GetCarsByBrandId(int brandId);
        //List<T> GetCarsByColorId(int carColorId);



    }
}
