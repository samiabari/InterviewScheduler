using Microsoft.EntityFrameworkCore;
using SchedulerCoreRazorEntityApp.DAL;
using SchedulerCoreRazorEntityApp.Models;
using SchedulerCoreRazorEntityApp.Repositories.Interface;

namespace SchedulerCoreRazorEntityApp.Repositories.Implements
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        protected readonly AppDbContext appDbContext;
        private DbSet<T> dbSet {  get; set; }
        public GenericRepo(AppDbContext _appDbContext)
        {
            this.appDbContext = _appDbContext;
            this.dbSet = this.appDbContext.Set<T>();
        }

        public async Task<T> Add(T t)
        {
            var obj= await dbSet.AddAsync(t);
            return obj.Entity;
        }

        public async Task<bool> Delete(int id)
        {
            var obj = await dbSet.FindAsync(id);

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

        public async Task<IEnumerable<T>> GetAll()
        {
            var objs = await dbSet.ToListAsync();
            return objs;

        }

        public async Task<T> GetById(int id)
        {
            var obj = await dbSet.FindAsync(id);
            return obj;
        }

        public async Task<T> Update(int id, T t)
        {
            var obj = await dbSet.FindAsync(id);

            if (obj == null)
            {
                throw new Exception("No Data found to be updated");
            }
            var updatedData = dbSet.Update(t);
            return updatedData.Entity;
        }
    }
}
