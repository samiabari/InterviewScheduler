using Microsoft.EntityFrameworkCore;
using SchedulerCoreRazorEntityApp.DAL;
using SchedulerCoreRazorEntityApp.Models;
using SchedulerCoreRazorEntityApp.Repositories.Interface;

namespace SchedulerCoreRazorEntityApp.Repositories.Implements
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly AppDbContext appDbContext;
        private readonly DbSet<T> dbSet=null;
        public GenericRepo(AppDbContext _appDbContext)
        {
            this.appDbContext = _appDbContext;
            dbSet = this.appDbContext.Set<T>();
        }

        public T Add(T t)
        {
            var obj=dbSet.Add(t);
            return obj.Entity;
        }

        public bool Delete(int id)
        {
            var obj = dbSet.Find(id);

            if (obj == null)
            {
                throw new Exception("No Data found to be updated");
            }

            try
            {
                dbSet.Remove(obj);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<T> GetAll()
        {
            var objs = dbSet.ToList();
            return objs;

        }

        public T GetById(int id)
        {
            var obj = dbSet.Find(id);
            return obj;
        }

        public bool Save()
        {
            try
            {
                appDbContext.SaveChanges();
                return true;
            }
            catch {
                return false;
            }
        }

        public T Update(int id, T t)
        {
            var obj = dbSet.Find(id);

            if (obj == null)
            {
                throw new Exception("No Data found to be updated");
            }
            var updatedData = dbSet.Update(t);
            return updatedData.Entity;
        }
    }
}
