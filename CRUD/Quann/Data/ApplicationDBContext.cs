using Microsoft.EntityFrameworkCore;
using Quann.Models;

public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        //Khai báo đối tượng để tạo database

        public DbSet<Student> Students { get; set; }
        
        //Kết thúc khai báo đối tượng để tạo database
    }