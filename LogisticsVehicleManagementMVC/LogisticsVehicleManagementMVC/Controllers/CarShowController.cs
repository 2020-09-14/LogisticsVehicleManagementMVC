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
        public IActionResult CarAdd()
        {
            return View();
        }
    }
}
