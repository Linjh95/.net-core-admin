using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Linjh.Repositories.Admin;
using Linjh.Models;
using Linjh.Utility;

namespace Linjh.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private AdminUserRepository adminUserRepository;

        //构造函数注入仓储
        public LoginController(AdminUserRepository _adminUserRepository)
        {
            adminUserRepository = _adminUserRepository;
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                //检查用户信息
                var user = adminUserRepository.CheckUser(model.Name, model.Password);
                if (user != null)
                {
                    //记录Session
                    HttpContext.Session.SetString("CurrentUserId", user.Id.ToString());
                    HttpContext.Session.Set("CurrentUser", ByteConvertHelper.Object2Bytes(user));
                    //跳转到系统首页
                    return RedirectToAction("Index", "AdminHome");
                }
                ViewBag.ErrorInfo = "用户名或密码错误。";
                return View();
            }
            foreach (var item in ModelState.Values)
            {
                if (item.Errors.Count > 0)
                {
                    ViewBag.ErrorInfo = item.Errors[0].ErrorMessage;
                    break;
                }
            }
            return View(model);
        }
    }
}