using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vianalk.Framework.SeeSharp.Utils.Assertions;

namespace Dashboard.Domain.UserModule
{
    public sealed class UserDomainService
    {
        private readonly IUserRepository repository;

        public UserDomainService(IUserRepository repository)
        {
            this.repository = Check.IsNull(repository, "repository");
        }

        public IEnumerable<PhoneType> GetPhoneTypes()
        {
            return this.repository.Query<PhoneType>().ToArray();
        }

        public void SavePhoneType(PhoneType phoneType)
        {
            Check.IsNull(phoneType, "phoneType");
            if(phoneType.Id == 0)
            {
                this.repository.Insert(phoneType);
            }
            else
            {
                this.repository.Update(phoneType);
            }
        }
    }
}
