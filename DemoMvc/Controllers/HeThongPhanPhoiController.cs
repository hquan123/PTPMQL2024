using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DemoMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DemoMvc.Controllers
{
    [Route("[controller]")]
    public class HeThongPhanPhoiController : Controller
    {
        private readonly ILogger<HeThongPhanPhoiController> _logger;

        public HeThongPhanPhoiController(ILogger<HeThongPhanPhoiController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(HeThongPhanPhoi htpp)
        {
            string message = "Mã của bạn là: " + htpp.MaHTPP + ", tên hệ thống phân phối là: " + htpp.TenHTPP + " nhé";
            ViewBag.Message = message;
            return View();
        }

    }
}