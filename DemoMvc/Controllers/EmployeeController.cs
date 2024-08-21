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
    public class EmployeeController : Controller
    {
        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Employee em)
        {
            string message = "Id của bạn là: " +em.PersonId + 
            ", tên của bạn là: " + em.FullName + 
            ", Địa chi: " + em.Address +  
            ", Id của Employee: " + em.EmployeeId +  
            ", Tuổi: " + em.Age +  
            " nhé";
            ViewBag.Message = message;
            return View();
        }
    }
}