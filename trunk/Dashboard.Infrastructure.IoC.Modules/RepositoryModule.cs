using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dashboard.Domain.UserModule;
using Dashboard.Infrastructure.Repository.Contexts;
using Dashboard.Infrastructure.Repository.Implementations;
using Ninject.Modules;
using Vianalk.Framework.SeeSharp.Domain.Common;
using Vianalk.Framework.SeeSharp.Infrastructure.Repository;

namespace Dashboard.Infrastructure.IoC.Modules
{
    public class RepositoryModule : NinjectModule
    {
        public override void Load()
        {
            this.Bind<IUnitOfWork>().To<DashboardUnitOfWork>().InThreadScope();
            this.Bind<IRepository>().To<BaseRepository>().InThreadScope();
            this.Bind<IUserRepository>().To<UserRepository>().InThreadScope();
        }
    }
}
