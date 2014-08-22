using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vianalk.Framework.SeeSharp.Domain.Common
{
    public abstract class BaseDomainService
    {
        protected readonly IRepository repository;

        public BaseDomainService(IRepository repository)
        {
            this.repository = repository;
        }
    }    
}
