using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dashboard.Domain.UserModule;
using Vianalk.Framework.SeeSharp.Domain.Common;
using Vianalk.Framework.SeeSharp.Infrastructure.Repository;

namespace Dashboard.Infrastructure.Repository.Implementations
{
    public class UserRepository: BaseEntityRepository<User>, IUserRepository
    {
        public UserRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
