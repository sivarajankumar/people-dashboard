using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vianalk.Framework.SeeSharp.Domain.Common;

namespace Dashboard.Domain.UserModule
{
    public interface IUserRepository : IEntityRepository<User>
    {
    }
}
