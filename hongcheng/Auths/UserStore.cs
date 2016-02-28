using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hongcheng
{
    public class UserStore:Microsoft.AspNet.Identity.IUserStore<IdentityUser>
    {
        // 创建用户
        public async Task CreateAsync(IdentityUser user)
        {
            //DAL.DAInstance.Instance.InsertUserBasic(new DAL.Models.UserBasicInfo());
            throw new NotImplementedException();
        }

        public Task DeleteAsync(IdentityUser user)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IdentityUser> FindByIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        // 根据用户名找用户
        public async Task<IdentityUser> FindByNameAsync(string userName)
        {
            //using (var stream = new IO.StreamReader(_filePath))
            //{
            //    string line;
                IdentityUser result = null;
            //    while ((line = await stream.ReadLineAsync()) != null)
            //    {
            //        var user = IdentityUser.FromString(line);
            //        if (user.UserName == userName)
            //        {
            //            result = user;
            //            break;
            //        }
            //    }
                return result;
            //}
        }

        public Task UpdateAsync(IdentityUser user)
        {
            throw new NotImplementedException();
        }
    }
}

