using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;

namespace DAL
{
    public class DAInstance
    {
        private static DAInstance _instance;
        private static object _locker;

        public string ConnectionStr = ConfigurationManager.ConnectionStrings["honglinEntities"].ConnectionString;

        public static DAInstance Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock(_locker)
                    {
                        if (_instance == null)
                        {
                            _instance = new DAInstance();                            
                        }
                    }
                }

                return _instance;
            }
        }

        public UserBasicInfo GetUserBasic(int PhoneNum)
        {
            UserBasicInfo user = new UserBasicInfo();
            using (Entities.honglinEntities _hl = new Entities.honglinEntities())
            {
                Entities.user userBasic = _hl.users.Where(u => u.PhoneNum == PhoneNum).SingleOrDefault();

                if (userBasic != null)
                {
                    user.UserId = userBasic.UserId;
                    user.FedId = userBasic.FedId;
                    user.PhoneNum = userBasic.PhoneNum;
                    user.Name = userBasic.Name;
                    user.LastAccessTime = userBasic.LastAccessTime;
                    user.Pwd = userBasic.Pwd;
                }
            }
            return user;
        }

        public int InsertUserBasic(UserBasicInfo userBasic)
        {
            int ret = -1;
            using (Entities.honglinEntities _hl = new Entities.honglinEntities())
            {
                Entities.user user = new Entities.user();
                if (userBasic != null)
                {
                    user.UserId = userBasic.UserId;
                    user.FedId = userBasic.FedId;
                    user.PhoneNum = userBasic.PhoneNum;
                    user.Name = userBasic.Name;
                    user.LastAccessTime = userBasic.LastAccessTime;
                    user.Pwd = userBasic.Pwd;
                    ret = 0;
                    _hl.users.Add(user);
                }
                ret = _hl.SaveChanges();
            }
            return ret;
        }        
    }
}
