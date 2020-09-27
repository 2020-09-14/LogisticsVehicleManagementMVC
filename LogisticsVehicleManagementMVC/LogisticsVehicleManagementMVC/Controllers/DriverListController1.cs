using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LogisticsVehicleManagementMVC.Controllers
{
    public class DriverListController1 : Controller
    {
        //显示驾驶员
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Show()
        {
            return View();
        }
        //添加驾驶员
        public IActionResult Add()
        {
            return View();
        }
        //更新驾驶员
        public IActionResult Upt(int Did) 
        {
            ViewBag.Id = Did;
            return View();
        }
    }
}
