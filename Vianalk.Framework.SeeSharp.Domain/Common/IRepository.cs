using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vianalk.Framework.SeeSharp.Domain.Common
{
    public interface IRepository
    {
        IQueryable<T> Query<T>() where T : BaseEntity;
        void Insert<T>(T item) where T : BaseEntity;
        void Delete<T>(T item) where T : BaseEntity;
        void Update<T>(T item) where T : BaseEntity;
        T GetById<T>(int id) where T : BaseEntity;
    }
}
