using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vianalk.Framework.SeeSharp.Domain.Common
{
    public interface IEntityRepository<T> : IRepository where T : BaseEntity
    {
        IQueryable<T> Query();
        void Insert(T item);
        void Delete(T item);
        void Update(T item);
        T GetById(int id);
    }
}
