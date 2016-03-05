using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace DAL.Models
{
    public partial class UserBasicInfo
    {
        public int UserId { get; set; }
        public string FedId { get; set; }
        public int PhoneNum { get; set; }
        public string Name { get; set; }
        public string Pwd { get; set; }
        public EnumGender Gender { get; set; }       
        public UserRole Role { get; set; }
        public EnumUVStatus IsVerified { get; set; }
        public DateTime? RegisterTime { get; set; }
        public DateTime? LastAccessTime { get; set; }

    }
}
