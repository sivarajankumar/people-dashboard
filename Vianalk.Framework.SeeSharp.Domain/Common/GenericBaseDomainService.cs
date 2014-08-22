using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vianalk.Framework.SeeSharp.Domain.Common
{
    public class BaseDomainService<T> where T : BaseEntity
    {
        protected readonly IEntityRepository<T> repository;

        public BaseDomainService(IEntityRepository<T> repository)
        {
            this.repository = repository;
        }        
    }
}
