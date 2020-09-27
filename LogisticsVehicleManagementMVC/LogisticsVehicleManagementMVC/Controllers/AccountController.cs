using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LogisticsVehicleManagementMVC.Controllers
{
    public class AccountController : Controller
    {
        //登录
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Amend()
        {
            return View();
        }

        public IActionResult It()
        {
            return View();
        }
    }
}
