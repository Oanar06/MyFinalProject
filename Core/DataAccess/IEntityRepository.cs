
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint
    //class = referans tip
    //IEntity= IEntity olabilir veya IEntity implemente eden bir nesne olabilr
    //new()= new lenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity,new() //kısıtlama yapmak için where/IEntity olanlar t olabilir
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);//filtrelemeler için kullanılır p=>p.productId vs.
        T Get(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity); 

    
    }
}
