using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vianalk.Framework.SeeSharp.Domain.Common;

namespace Vianalk.Framework.SeeSharp.Infrastructure.Repository
{
    public class BaseEntityRepository<T> : BaseRepository, IEntityRepository<T> where T : BaseEntity
    {        
        public BaseEntityRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {            
        }

        public virtual IQueryable<T> Query()
        {
            return this.Query<T>();
        }

        public virtual void Insert(T item)
        {
            this.Insert(item);
        }

        public virtual void Delete(T item)
        {
            this.Delete(item);
        }

        public virtual void Update(T item)
        {
            this.Update(item);
        }

        public virtual T GetById(int id)
        {
            return this.GetById<T>(id);
        }
    }
}
