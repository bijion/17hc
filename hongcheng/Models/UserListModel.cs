using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace hongcheng.Models
{
    public class UserListModel
    {
        private List<UserBasicInfo> _list;

        public UserListModel()
        {
            _list = new List<UserBasicInfo>();
        }

        public UserListModel(List<UserBasicInfo> uList)
        {
            this._list = uList;
        }

        public List<UserBasicInfo> List
        {
            get
            {
                return _list;
            }            
        }
        
        public List<UserBasicInfo> PendingUserList
        {
            get
            {
                if (_list != null)
                {
                    return _list.FindAll(t => t.IsVerified == Common.EnumUVStatus.未审核);
                }
                return new List<UserBasicInfo>();
            }
        }
    }
}
