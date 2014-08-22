using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vianalk.Framework.SeeSharp.Domain.Common;

namespace Dashboard.Domain.UserModule
{
    public class User : BaseEntity
    {
        public User()
        {
            this.Phones = new List<UserPhone>();
        }

        [Required]        
        [StringLength(200)]
        public string Email { get; set; }

        [Required]
        [StringLength(200)]
        public string Password { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        
        [StringLength(400)]
        public string HomeAddress { get; set; }

        [StringLength(400)]
        public string WorkAddress { get; set; }

        public virtual List<UserPhone> Phones { get; set; }
    }
}
