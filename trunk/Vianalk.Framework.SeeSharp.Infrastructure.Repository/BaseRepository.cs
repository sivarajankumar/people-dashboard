using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vianalk.Framework.SeeSharp.Domain.Common;

namespace Vianalk.Framework.SeeSharp.Infrastructure.Repository
{
    public class BaseRepository : IRepository
    {
        private readonly DbContext unitOfWork;
        public BaseRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork as BaseUnitOfWork;
        }

        public IQueryable<T> Query<T>() where T : BaseEntity
        {
            return this.unitOfWork.Set<T>();
        }

        public void Insert<T>(T item) where T : BaseEntity
        {
            this.unitOfWork.Set<T>().Add(item);
        }

        public void Delete<T>(T item) where T : BaseEntity
        {
            this.unitOfWork.Set<T>().Remove(item);
        }

        public T GetById<T>(int id) where T : BaseEntity
        {
            return this.unitOfWork.Set<T>().Find(id);
        }

        public void Update<T>(T item) where T : BaseEntity
        {            
            var dbEntity = this.GetById<T>(item.Id);
            var dbEntry = this.unitOfWork.Entry<T>(dbEntity);
            dbEntry.CurrentValues.SetValues(item);
            dbEntry.State = EntityState.Modified;
        }
    }
}
