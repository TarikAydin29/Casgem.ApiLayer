using Casgem.DAL.Abstract;
using Casgem.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem.DAL.GenericRepositories
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        private readonly Context context;

        public GenericRepository(Context context)
        {
            this.context = context;
        }
        public void Delete(T t)
        {
            context.Remove(t);
            context.SaveChanges();
        }

        public T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            context.Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            context.Update(t);
            context.SaveChanges();
        }
    }
}
