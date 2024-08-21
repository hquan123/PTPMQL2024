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
    public class DaiLyController : Controller
    {
        private readonly ILogger<DaiLyController> _logger;

        public DaiLyController(ILogger<DaiLyController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(DaiLy ly)
        {
            string message = "Mã đại lý là: " + ly.MaDaiLy + 
            ", tên đại lý: " + ly.TenDaiLy + 
            ", người đại diện: " + ly.NguoiDaiDien + 
            ", số điện thoại: " + ly.DienThoai + 
            ", mã phân phối: " + ly.MaHTPP + 
            " nhé";
            ViewBag.Message = message;
            return View();
        }

    }
}