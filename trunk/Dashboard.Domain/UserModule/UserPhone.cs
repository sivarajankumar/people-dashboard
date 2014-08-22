using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vianalk.Framework.SeeSharp.Domain.Common;

namespace Dashboard.Domain.UserModule
{
    public class UserPhone : BaseEntity
    {
        public int UserId { get; set; }

        public virtual User User { get; set; }

        public int PhoneTypeId { get; set; }

        public virtual PhoneType PhoneType { get; set; }
    }
}
