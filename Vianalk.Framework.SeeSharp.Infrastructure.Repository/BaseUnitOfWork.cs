using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vianalk.Framework.SeeSharp.Domain.Common;

namespace Vianalk.Framework.SeeSharp.Infrastructure.Repository
{
    public class BaseUnitOfWork : DbContext, IUnitOfWork
    {
        public BaseUnitOfWork(string connectionStringName)
            : base(connectionStringName)
        {
        }

        public int Commit()
        {
            return this.SaveChanges();
        }
    }
}
