using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LogisticsVehicleManagementMVC.Controllers
{
    public class CostController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        public IActionResult GetList()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Upt(int ids)
        {
            ViewBag.Is = ids;
            return View();
        }
    }
}
