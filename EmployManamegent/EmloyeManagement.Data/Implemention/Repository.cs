using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using EmloyeManagement.Data.Concrats;
using EmloyeManagement.Data.DataContext;
using Microsoft.EntityFrameworkCore;

namespace EmloyeManagement.Data.Implemention
{
    class Repository<T>:IRepositoryBase<T> where T:class ,new()
    {
        private readonly MustafaEmployeManamegentContext _ctx;
        internal DbSet<T> dbSet;

        public Repository(MustafaEmployeManamegentContext ctx)
        {
            _ctx = ctx;
            this.dbSet = _ctx.Set<T>();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (filter!=null)
                query = query.Where(filter);
            if (includeProperties!=null)
            {
                foreach (var item in includeProperties.Split(new char[]{','},StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(item);
                }
            }

            if (orderBy!=null)
            {
                return orderBy(query);
            }

            return query;

        }

        public T Get(int id)
        {
            return dbSet.Find(id);
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string inculudeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
                query = query.Where(filter);
            if (inculudeProperties == null) return query.FirstOrDefault();
            foreach (var item in inculudeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(item);
            }

            return query.FirstOrDefault();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void Update(T entity)
        {
            dbSet.Update(entity);
        }
    }
}
