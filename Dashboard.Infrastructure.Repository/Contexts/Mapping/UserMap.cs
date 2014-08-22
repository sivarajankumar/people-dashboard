using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dashboard.Domain.UserModule;

namespace Dashboard.Infrastructure.Repository.Contexts.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {            
        }
    }
}
