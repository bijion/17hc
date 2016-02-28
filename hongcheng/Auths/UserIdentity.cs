using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace hongcheng
{
    public class IdentityUser : IUser
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string PasswordHash { get; set; }

        public override string ToString()
        {
            return string.Format("{0},{1},{2}", this.Id, this.UserName, this.PasswordHash);
        }

        public static IdentityUser FromString(string strUser)
        {
            if (string.IsNullOrWhiteSpace(strUser))
            {
                throw new ArgumentNullException("user");
            }

            var arr = strUser.Split(',');
            if (arr.Length != 3)
            {
                throw new InvalidOperationException("user is not valid");
            }
            var user = new IdentityUser();
            user.Id = arr[0];
            user.UserName = arr[1];
            user.PasswordHash = arr[2];

            return user;
        }
    }
}
