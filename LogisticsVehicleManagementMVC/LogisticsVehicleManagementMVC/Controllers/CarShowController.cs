using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LogisticsVehicleManagementMVC.Controllers
{
    public class CarShowController : Controller
    {
        
        public IActionResult Show()
        {
            return View();
        }
        public IActionResult CarAdd(string ids)
        {
            ViewBag.ls = ids;
            return View();
        }
        public IActionResult CarUpt()
        {
            return View();
        }
        public IActionResult Motorcade()
        {
            return View();
        }
        public IActionResult MotorcadeAdd(string ids)
        {
            ViewBag.ls = ids;
            return View();
        }
    }
}
