using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace EmloyeManagement.Data.Concrats
{
   public interface IRepositoryBase<T> where T:class,new()
   {
       IQueryable<T> GetAll(Expression<Func<T, bool>>filter=null,Func<IQueryable<T>,IOrderedQueryable<T>>orderBy=null,string inculudeProperties=null);

       T Get(int id);

       T GetOfDefault(Expression<Func<T, bool>>filter=null,string inculudeProperties=null);

       void Add(T entity);

       void Remove(T entity);

       void Update(T entity);
   }
}
