using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dashboard.Infrastructure.Repository.Contexts.Mapping;
using Vianalk.Framework.SeeSharp.Infrastructure.Repository;

namespace Dashboard.Infrastructure.Repository.Contexts
{
    public class DashboardUnitOfWork : BaseUnitOfWork
    {
        public DashboardUnitOfWork()
            : base("DashboardUnitOfWork")
        {
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new PhoneTypeMap());
            modelBuilder.Configurations.Add(new UserPhoneMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
