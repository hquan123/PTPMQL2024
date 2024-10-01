using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMvc.Models
{
    public class Employee : Person
    {
        public int NamSinh { get; set; }

        public double Luong { get; set; }
    }
}