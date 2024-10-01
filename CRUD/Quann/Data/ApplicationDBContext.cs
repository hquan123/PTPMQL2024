using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Quann.Models;

namespace Quann.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        //Khai báo đối tượng để tạo database

        public DbSet<Student> Students { get; set; }
        
        //Kết thúc khai báo đối tượng để tạo database
    }
}