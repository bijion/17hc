using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public partial class UserBasicInfo
    {
        public int UserId { get; set; }
        public string FedId { get; set; }
        public int PhoneNum { get; set; }

        public string Name { get; set; }
        public string Pwd { get; set; }

        public DateTime? LastAccessTime { get; set; }

    }
}
