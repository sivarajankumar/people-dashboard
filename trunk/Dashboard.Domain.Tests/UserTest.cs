using System;
using Dashboard.Domain.UserModule;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vianalk.Framework.SeeSharp.Domain.Common;

namespace Dashboard.Domain.Tests
{
    [TestClass]
    public class UserTest : TestBase
    {
        private readonly UserDomainService userDomainService;

        public UserTest()
            : base()
        {
            userDomainService = this.factory.Get<UserDomainService>();
        }
        [TestMethod]
        public void ListPhoneTypesTest()
        {
            this.WrapTest(() =>
            {                
                var phoneTypes = userDomainService.GetPhoneTypes();
                Assert.IsNotNull(phoneTypes);
            });
        }

        [TestMethod]
        public void SavePhoneType()
        {
            this.WrapTest(() =>
            {
                var phoneType = new PhoneType();
                phoneType.Name = "Celular";

                this.userDomainService.SavePhoneType(phoneType);

                factory.Get<IUnitOfWork>().Commit();
            });
        }
    }
}
