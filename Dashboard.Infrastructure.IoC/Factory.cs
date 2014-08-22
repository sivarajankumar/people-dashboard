using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dashboard.Infrastructure.IoC.Modules;
using Ninject;
using Ninject.Parameters;

namespace Dashboard.Infrastructure.IoC
{
    public class Factory : IFactory
    {
        private static IFactory instance;
 
        public static IFactory Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Factory();
                }

                return instance;
            }
        }

        private StandardKernel kernel;

        public Factory()
        {
            var repositoryModule = new RepositoryModule();
            this.kernel = new StandardKernel(repositoryModule);
        }

        public T Get<T>()
        {
            return this.kernel.Get<T>();
        }

        public T Get<T>(object unitOfWork)
        {
            return this.kernel.Get<T>(new ConstructorArgument("unitOfWork", unitOfWork));
        }
    }
}
