using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dashboard.Domain.UserModule;

namespace Dashboard.Infrastructure.Repository.Contexts.Mapping
{
    public class UserPhoneMap : EntityTypeConfiguration<UserPhone>
    {
        public UserPhoneMap()
        {
            this.HasRequired(t => t.PhoneType).WithMany(t => t.UserPhones).HasForeignKey(t => t.PhoneTypeId);
            this.HasRequired(t => t.User).WithMany(t => t.Phones).HasForeignKey(t => t.UserId);
        }
    }
}
