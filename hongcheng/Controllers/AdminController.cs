using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hongcheng.Models;

namespace hongcheng.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        //用户列表，用于删除和更改权限
        public ActionResult UserList()
        {
            UserListModel model = new UserListModel();
            model.List.Add(new DAL.Models.UserBasicInfo() {  Name="张三", PhoneNum=18901, RegisterTime = DateTime.Now});
            model.List.Add(new DAL.Models.UserBasicInfo() { Name = "张er", PhoneNum = 18901, RegisterTime = DateTime.Now });

            return View(model);
        }

        //所有申请，包括新用户确认，子分销确认，积分变现审批
        public ActionResult Requests()
        {
            return View();
        }

        //新用户确认
        public ActionResult NUConfirm(int userId)
        {
            return View();
        }

        //分销新成员确认, 通过usc表的rid取信息
        public ActionResult NMConfirm(int RId)
        {
            return View();
        }

        //变现审批, 通过userscorehistory的isaffected来判断有没有申请
        public ActionResult S2MConfirm(int UId)
        {
            return View();
        }
    }
}