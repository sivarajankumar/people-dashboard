using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dashboard.Infrastructure.IoC;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vianalk.Framework.SeeSharp.Domain.Common;

namespace Dashboard.Domain.Tests
{
    public class TestBase : IDisposable
    {
        protected readonly IFactory factory;

        public TestBase()
        {
            factory = Factory.Instance;
        }

        protected void WrapTest(Action testAction)
        {
            try
            {
                testAction();
            }
            catch (UnitTestAssertException)
            {
                throw;
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        public void Dispose()
        {
            this.factory.Get<IUnitOfWork>().Dispose();
        }
    }
}
