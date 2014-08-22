using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vianalk.Framework.SeeSharp.Domain.Common;

namespace Dashboard.Domain.UserModule
{
    public class PhoneType : BaseEntity
    {
        public PhoneType()
        {
            this.UserPhones = new List<UserPhone>();
        }

        public string Name { get; set; }

        public virtual List<UserPhone> UserPhones { get; set; }
    }
}
