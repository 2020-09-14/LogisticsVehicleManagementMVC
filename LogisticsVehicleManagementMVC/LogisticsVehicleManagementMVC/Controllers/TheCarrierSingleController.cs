using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LogisticsVehicleManagementMVC.Controllers
{
    public class TheCarrierSingleController : Controller
    {
        public IActionResult GettheCarrierSingles()
        {
            return View();
        }
    }
}
