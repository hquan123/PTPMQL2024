using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMvc.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // tự tăng 
        public int Id { get; set; }

        public string HoTen { get; set; }
        public string CCCD { get; set; }
        public string QueQuan { get; set; }
    }
}