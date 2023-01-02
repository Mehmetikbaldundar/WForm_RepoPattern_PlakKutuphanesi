using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Abstract;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class BaseRepository<T> : IRepository<T> where T : class, IBaseEntity
    {
        private readonly MyDbContext _sirketDbContext;
        private DbSet<T> _table;

        public BaseRepository(MyDbContext sirketDbContext)
        {
            _sirketDbContext = sirketDbContext;
            _table = _sirketDbContext.Set<T>();
        }
        public bool Add(T entity)
        {
            _table.Add(entity);
            return Save() > 0;
        }

        public bool AddRange(List<T> entities)
        {
            _table.AddRange(entities);
            return Save() > 0;
        }

        public bool Delete(T entity)
        {
            entity.Status = Status.Deleted;
            return Update(entity);
        }

        public List<T> GetAll()
        {
            return _table.Where(x => x.Status == Status.Active || x.Status == Status.Modified).ToList();
        }

        public T GetById(int Id)
        {
            return _table.Find(Id);
        }

        public int Save()
        {
            return _sirketDbContext.SaveChanges();
        }

        public bool Update(T entity)
        {
            _sirketDbContext.Entry<T>(entity).State = EntityState.Modified;
            return Save() > 0;
        }
    }
}
